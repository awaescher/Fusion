using DevExpress.XtraEditors;
using System;
using FusionPlusPlus.IO;
using FusionPlusPlus.Model;
using FusionPlusPlus.Parser;
using FusionPlusPlus.Services;
using DevExpress.XtraGrid.Columns;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using DevExpress.XtraBars;
using FusionPlusPlus.Controls;
using System.Threading;
using System.Threading.Tasks;
using TinySoup.Model;
using TinySoup;

namespace FusionPlusPlus
{
	public partial class MainForm : XtraForm
	{
		private bool _loading = false;
		private LogFileParser _parser;
		private RegistryFusionService _fusionService;
		private List<AggregateLogItem> _logs;
		private string _lastLogPath;
		private string _lastUsedFilePath;
		private FusionSession _session;
		private Dictionary<OverlayState, Control> _overlays;
		private System.Threading.Timer _updateTimer;

		public MainForm()
		{
			InitializeComponent();

			_fusionService = new RegistryFusionService();
		}

		protected override void OnShown(EventArgs e)
		{
			var loadingOverlay = LoadingOverlay.PutOn(this);
			loadingOverlay.CancelRequested += LoadingOverlay_CancelRequested;

			_overlays = new Dictionary<OverlayState, Control>();
			_overlays[OverlayState.Empty] = EmptyOverlay.PutOn(this);
			_overlays[OverlayState.Loading] = loadingOverlay;
			var recordingOverlay = RecordingOverlay.PutOn(this);
			recordingOverlay.StopRequested += btnRecord_Click;
			_overlays[OverlayState.Recording] = recordingOverlay;

			_overlays[OverlayState.Empty].SendToBack();
			_overlays[OverlayState.Loading].BringToFront();
			_overlays[OverlayState.Recording].BringToFront();

			_updateTimer = new System.Threading.Timer(async state => await CheckForUpdatesAsync(), null, 5000, Timeout.Infinite);

			_parser = new LogFileParser(new LogItemParser(), new FileReader(), null)
			{
				Progress = (current, total) => this.Invoke((Action)(() => this.Text = $"{current}/{total}"))
			};

			var name = this.GetType().Assembly.GetName();
			Text = $"{name.Name} {name.Version.Major}.{name.Version.Minor}" + (name.Version.Build == 0 ? "" : $".{name.Version.Build}");

			base.OnShown(e);

			SetControlVisiblityByContext();
			SetOverlayState(OverlayState.Empty);
		}
		
		private async Task<List<LogItem>> ReadLogsAsync(ILogStore store)
		{
			_loading = true;

			_parser.FileService = new LogFileService(store);
			var logs = await _parser.ParseAsync();

			_loading = false;

			return logs;
		}

		private async Task ClearLogsAsync() => await LoadLogsAsync("");

		private async Task LoadLogsAsync(string path) => await LoadLogsAsync(new TransparentLogStore(path));

		private enum OverlayState
		{
			None,
			Empty,
			Recording,
			Loading
		}

		private void SetOverlayState(OverlayState state)
		{
			foreach (var pair in _overlays)
				pair.Value.Visible = pair.Key == state;

			var loadingOverlay = (_overlays[OverlayState.Recording] as RecordingOverlay);
			if (state == OverlayState.Recording)
				loadingOverlay.StartTimer();
			else
				loadingOverlay.StopTimer();

			this.Refresh();
		}

		private async Task LoadLogsAsync(ILogStore logStore)
		{
			var hasPath = !string.IsNullOrEmpty(logStore.Path);
			if (hasPath)
				SetOverlayState(OverlayState.Loading);

			var aggregator = new LogAggregator();
			var treeBuilder = new LogTreeBuilder();

			var logs = await ReadLogsAsync(logStore);
			_logs = aggregator.Aggregate(logs);
			_lastLogPath = logStore.Path;

			// Generate a data table and bind the date-time client to it.
			dateTimeChartRangeControlClient1.DataProvider.DataSource = _logs;

			// Specify data members to bind the client.
			dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = nameof(SourceItem.TimeStampLocal);
			dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = nameof(SourceItem.ItemCount);
			dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = nameof(SourceItem.State);
			dateTimeChartRangeControlClient1.DataProvider.TemplateView = new BarChartRangeControlClientView() { };
			dateTimeChartRangeControlClient1.PaletteName = "Solstice";

			var allStates = Enum.GetValues(typeof(LogItem.State)).OfType<LogItem.State>().ToArray();
			var stamps = logs.Select(l => l.TimeStampLocal).Distinct();
			var source = stamps.SelectMany(stamp =>
			{
				return allStates.Select(state => new SourceItem
				{
					TimeStampLocal = stamp,
					State = state,
					ItemCount = _logs.Where(l => l.TimeStampLocal == stamp && l.AccumulatedState >= state).Sum(l => /*l.ItemCount*/ 1)
				});
			});

			dateTimeChartRangeControlClient1.DataProvider.DataSource = source;

			SetControlVisiblityByContext();

			if (_logs.Any())
				SetOverlayState(OverlayState.None);
			else
				SetOverlayState(OverlayState.Empty);
		}

		private class SourceItem
		{
			public DateTime TimeStampLocal { get; set; }
			public LogItem.State State { get; set; }
			public int? ItemCount { get; set; }
		}

		private void SetControlVisiblityByContext()
		{
			var hasData = _logs?.Any() ?? false;
			gridLog.Visible = hasData;
			rangeData.Visible = hasData;
			btnImport.Enabled = true;
			btnExport.Enabled = hasData && !string.IsNullOrEmpty(_lastLogPath);
			btnExport.Tag = _lastLogPath;
		}

		private void rangeData_RangeChanged(object sender, RangeControlRangeEventArgs range)
		{
			DateTime from = ((DateTime)range.Range.Minimum).ToUniversalTime();
			DateTime till = ((DateTime)range.Range.Maximum).ToUniversalTime();

			gridLog.DataSource = _logs?.Where(l => l.TimeStampUtc >= from && l.TimeStampUtc <= till).ToList();
		}

		private void MainForm_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private async void MainForm_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			var files = (string[])e.Data.GetData(DataFormats.FileDrop);

			if (files.Length == 1)
			{
				_lastUsedFilePath = files[0];
				await LoadLogsAsync(files[0]);
			}
		}

		private async void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.I && e.Control)
				await ImportWithDirectoryDialogAsync();
		}

		private void viewLog_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (!viewLog.IsDataRow(e.RowHandle))
				return;

			if (e.Clicks == 2)
			{
				var item = (AggregateLogItem)viewLog.GetRow(e.RowHandle);
				ShowDetailForm(item);
			}
		}

		private void ShowDetailForm(AggregateLogItem item)
		{
			const int FORM_Y_OFFSET = 30;

			var form = new ItemDetailForm();
			form.Item = item;
			form.Height = this.Height - FORM_Y_OFFSET;
			form.Top = this.Top + FORM_Y_OFFSET;
			form.Left = this.Left + ((this.Width - form.Width) / 2);

			form.Show(this);
		}

		private async void btnRecord_Click(object sender, EventArgs e)
		{
			if (_fusionService == null || _loading)
				return;

			if (_session == null)
			{
				await ClearLogsAsync();

				SetOverlayState(OverlayState.Recording);

				_session = new FusionSession(_fusionService);
				_session.Start();

				btnImport.Enabled = false;
				btnExport.Enabled = false;
			}
			else
			{
				_session.End();
				await LoadLogsAsync(_session.Store.Path);
				_session = null;

			}

			btnRecord.Text = _session == null ? "Record" : "Stop";
			btnRecord.ImageOptions.SvgImage = _session == null ? Properties.Resources.Capture : Properties.Resources.Stop;
		}

		private async void btnImport_Click(object sender, EventArgs e)
		{
			await ImportWithDirectoryDialogAsync();
		}

		private async Task ImportWithDirectoryDialogAsync()
		{
			using (var dialog = new FolderBrowserDialog())
			{
				dialog.SelectedPath = _lastUsedFilePath ?? new TemporaryLogStore().TopLevelPath ?? "";
				if (dialog.ShowDialog() == DialogResult.OK)
					await ImportFromDirectoryAsync(dialog.SelectedPath);
			}
		}

		private async Task ImportFromDirectoryAsync(string directory)
		{
			_lastUsedFilePath = directory;
			await LoadLogsAsync(directory);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			var currentPath = btnExport.Tag.ToString();

			if (!Directory.Exists(currentPath))
				return;

			using (var dialog = new FolderBrowserDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
					DirectoryCloner.Clone(currentPath, dialog.SelectedPath);
			}
		}

		private async Task CheckForUpdatesAsync()
		{
			_updateTimer.Change(Timeout.Infinite, Timeout.Infinite);

			var request = new UpdateRequest()
				.WithNameAndVersionFromEntryAssembly()
				.AsAnonymousClient()
				.OnChannel("stable")
				.OnPlatform(new OperatingSystemIdentifier());

			var client = new WebSoupClient();
			var updates = await client.CheckForUpdatesAsync(request);

			var availableUpdate = updates.FirstOrDefault();
			if (availableUpdate != null)
				this.Invoke((Action)(() => this.Text += $"  »  Version {availableUpdate.ShortestVersionString} available."));
		}


		private void LoadingOverlay_CancelRequested(object sender, EventArgs e)
		{
			_parser?.Cancel();
		}

		private void popupLastSessions_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
		{
			PopulateLastSessions();
		}

		private void PopulateLastSessions()
		{
			popupLastSessions.ClearLinks();

			var store = new TemporaryLogStore();
			var topLevelPath = store.TopLevelPath;

			if (!Directory.Exists(topLevelPath))
				return;

			foreach (var sessionPath in Directory.GetDirectories(topLevelPath).OrderByDescending(dir => dir))
			{
				var button = new BarButtonItem();
				button.Caption = store.GetLogName(sessionPath);
				button.ItemClick += async (s, e) => await ImportFromDirectoryAsync(sessionPath);
				popupLastSessions.AddItem(button);
			}

			if (popupLastSessions.ItemLinks.Count > 0)
			{
				var topLevelButton = new BarButtonItem();
				topLevelButton.Caption = "Locate logs";
				topLevelButton.ItemClick += (s, e) => Process.Start(topLevelPath);
				popupLastSessions.AddItem(topLevelButton).BeginGroup = true;
			}
		}
	}
}