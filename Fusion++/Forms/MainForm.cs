using DevExpress.XtraEditors;
using System;
using FusionPlusPlus.Engine.Fusion;
using FusionPlusPlus.Engine.IO;
using FusionPlusPlus.Engine.Model;
using FusionPlusPlus.Engine.Parser;
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
using DevExpress.XtraBars.ToolbarForm;
using FusionPlusPlus.Engine.Helper;

namespace FusionPlusPlus.Forms
{
	public partial class MainForm : ToolbarForm, ILogItemNavigator
	{
		private bool _loading = false;
		private LogFileParser _parser;
		private RegistryFusionService _fusionService;
		private List<AggregateLogItem> _aggregatedLogs;
		private string _lastLogPath;
		private string _lastUsedFilePath;
		private FusionSession _session;
		private Dictionary<OverlayState, Control> _overlays;
		private System.Threading.Timer _updateTimer;
		private LoadingOverlay _loadingOverlay;
		private ItemDetailForm _detailForm;

		public MainForm()
		{
			InitializeComponent();

			_fusionService = new RegistryFusionService();
		}

		protected override void OnShown(EventArgs e)
		{
			_loadingOverlay = LoadingOverlay.PutOn(this);
			_loadingOverlay.CancelRequested += LoadingOverlay_CancelRequested;

			_overlays = new Dictionary<OverlayState, Control>();
			_overlays[OverlayState.Empty] = EmptyOverlay.PutOn(this);
			_overlays[OverlayState.Loading] = _loadingOverlay;
			var recordingOverlay = RecordingOverlay.PutOn(this);
			recordingOverlay.StopRequested += btnRecord_Click;
			_overlays[OverlayState.Recording] = recordingOverlay;

			_overlays[OverlayState.Empty].SendToBack();
			_overlays[OverlayState.Loading].BringToFront();
			_overlays[OverlayState.Recording].BringToFront();

			_updateTimer = new System.Threading.Timer(async state => await CheckForUpdatesAsync(), null, 5000, Timeout.Infinite);

			_parser = new LogFileParser(new LogItemParser(), new FileReader(), null)
			{
				Progress = (current, total) => _loadingOverlay.SetProgress(current, total)
			};

			Text = GetAppNameWithVersion();

			base.OnShown(e);

			SetControlVisiblityByContext();
			SetOverlayState(OverlayState.Empty);

			ShowSocialFlyout();
		}

		private string GetAppNameWithVersion()
		{
			var name = this.GetType().Assembly.GetName();
			return $"{name.Name} {name.Version.Major}.{name.Version.Minor}" + (name.Version.Build == 0 ? "" : $".{name.Version.Build}");
		}

		private async Task<List<LogItem>> ReadLogsAsync(ILogStore store)
		{
			_loading = true;

			_parser.FileService = new LogFileService(store);

			var watch = Stopwatch.StartNew();
			var logs = await _parser.ParseAsync();
			watch.Stop();
			Debug.WriteLine("Finished parsing in " + watch.Elapsed);

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

			List<LogItem> logs = null;

			await Task.Run(async () => logs = await ReadLogsAsync(logStore).ConfigureAwait(false));

			while (logs == null)
				Thread.Sleep(50);

			var success = Validate(logs);
			if (!success)
				logs.Clear();

			_aggregatedLogs = aggregator.Aggregate(logs);
			_lastLogPath = logStore.Path;

			// Generate a data table and bind the date-time client to it.
			dateTimeChartRangeControlClient1.DataProvider.DataSource = _aggregatedLogs;

			// Specify data members to bind the client.
			dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = nameof(RangeDatasourceItem.TimeStampLocal);
			dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = nameof(RangeDatasourceItem.ItemCount);
			dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = nameof(RangeDatasourceItem.State);
			dateTimeChartRangeControlClient1.DataProvider.TemplateView = new BarChartRangeControlClientView() { };
			dateTimeChartRangeControlClient1.PaletteName = "Solstice";

			var allStates = Enum.GetValues(typeof(LogItem.State)).OfType<LogItem.State>().ToArray();
			var timestamps = logs.Select(l => l.TimeStampLocal).Distinct();
			var rangeSource = timestamps.SelectMany(localTime =>
			{
				return allStates.Select(state => new RangeDatasourceItem
				{
					TimeStampLocal = localTime,
					State = state,
					ItemCount = _aggregatedLogs.Count(l => l.TimeStampLocal == localTime && l.AccumulatedState >= state)
				});
			});

			dateTimeChartRangeControlClient1.DataProvider.DataSource = rangeSource;

			SetControlVisiblityByContext();

			if (_aggregatedLogs.Any())
				SetOverlayState(OverlayState.None);
			else
				SetOverlayState(OverlayState.Empty);

			var logName = logStore.GetLogName(logStore.Path);
			Text = string.IsNullOrEmpty(logName) ? GetAppNameWithVersion() : $"{logName} - {GetAppNameWithVersion()}";
		}

		private bool Validate(IEnumerable<LogItem> logs)
		{
			var logWitoutDate = logs.FirstOrDefault(l => !l.HasTimeStamp);
			if (logWitoutDate != null)
			{
				var message = "I'm sorry but I could not parse the date format of the assembly binding logs" + Environment.NewLine +
					"with the current Windows date format settings and 'en-US' as fallback." + Environment.NewLine;

				if (!string.IsNullOrEmpty(logWitoutDate.FullMessage))
				{
					var details = logWitoutDate.FullMessage.Length > 200 ? logWitoutDate.FullMessage.Substring(0, 200) + " ..." : logWitoutDate.FullMessage;
					message += Environment.NewLine + Environment.NewLine + "Example binding log:" + Environment.NewLine + Environment.NewLine + details;
				}

				XtraMessageBox.Show(this, message, "Parser error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void SetControlVisiblityByContext()
		{
			var hasData = _aggregatedLogs?.Any() ?? false;
			gridLog.Visible = hasData;
			rangeData.Visible = hasData;
			btnSession.Enabled = true;
		}

		private void rangeData_RangeChanged(object sender, RangeControlRangeEventArgs range)
		{
			DateTime from = ((DateTime)range.Range.Minimum).ToUniversalTime();
			DateTime till = ((DateTime)range.Range.Maximum).ToUniversalTime();

			gridLog.DataSource = _aggregatedLogs?.Where(l => l.TimeStampUtc >= from && l.TimeStampUtc <= till).ToList();
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

		private void ViewLog_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (viewLog.IsDataRow(viewLog.FocusedRowHandle))
				{
					var item = (AggregateLogItem)viewLog.GetFocusedRow();
					ShowDetailForm(item);
				}
			}
		}

		private void ViewLog_CustomScrollAnnotation(object sender, DevExpress.XtraGrid.Views.Grid.GridCustomScrollAnnotationsEventArgs e)
		{
			if (e.Annotations == null)
				e.Annotations = new List<DevExpress.XtraGrid.Views.Grid.GridScrollAnnotationInfo>();
			else
				e.Annotations.Clear();

			if (_aggregatedLogs == null)
				return;

			SetRowAnnotations(e, LogItem.State.Error, Color.Red);
			SetRowAnnotations(e, LogItem.State.Warning, Color.Orange);
		}

		private void SetRowAnnotations(DevExpress.XtraGrid.Views.Grid.GridCustomScrollAnnotationsEventArgs e, LogItem.State state, Color color)
		{
			var errorDatasourceIndexes = _aggregatedLogs
				.Where(l => l.AccumulatedState == state)
				.Select(l => _aggregatedLogs.IndexOf(l))
				.ToArray();

			var errorRowHandles = errorDatasourceIndexes
				.Select(i => viewLog.GetRowHandle(i))
				.Select(h => new DevExpress.XtraGrid.Views.Grid.GridScrollAnnotationInfo() { Color = color, RowHandle = h })
				.ToArray();

			e.Annotations.AddRange(errorRowHandles);
		}

		private void ShowDetailForm(AggregateLogItem item)
		{
			const int FORM_Y_OFFSET = 5;

			if (_detailForm == null)
			{
				using (var hint = HintForm.Show(this, "Initializing Editor ..."))
				{
					_detailForm = new ItemDetailForm();
					hint.Close();
				}
			}

			_detailForm.Bounds = new Rectangle(
				this.Left + ((this.Width - _detailForm.Width) / 2),
				this.Top + FORM_Y_OFFSET,
				Math.Max(_detailForm.Width, this.Width / 2),
				this.Height - FORM_Y_OFFSET * 2);

			_detailForm.Item = item;
			_detailForm.ItemNavigator = this;

			_detailForm.ShowDialog(this);
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

				btnSession.Enabled = false;
			}
			else
			{
				_session.End();
				await LoadLogsAsync(_session.Store.Path);
				_session = null;

			}
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
			{
				this.Invoke((Action)(() =>
					{
						biUpdate.Visibility = BarItemVisibility.Always;
						biUpdate.Hint = $"Version {availableUpdate.ShortestVersionString} is available.";
						biUpdate.Tag = availableUpdate.Url;
					}));
			}
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

			string[] sessionPaths = null;

			if (Directory.Exists(topLevelPath))
			{
				sessionPaths = Directory
					.GetDirectories(topLevelPath)
					.OrderByDescending(dir => dir)
					.Take(20) // limit to max to keep the menu fast
					.ToArray();
			}

			if ((sessionPaths?.Length ?? 0) == 0)
			{
				var button = new BarButtonItem();
				button.Caption = "(no sessions yet)";
				button.Enabled = false;
				popupLastSessions.AddItem(button);
			}
			else
			{
				foreach (var sessionPath in sessionPaths)
				{
					var button = new BarButtonItem();
					button.Caption = store.GetLogName(sessionPath);
					button.ItemClick += async (s, e) => await ImportFromDirectoryAsync(sessionPath);
					popupLastSessions.AddItem(button);
				}
			}

			if (popupLastSessions.ItemLinks.Count > 0)
			{
				var topLevelButton = new BarButtonItem();
				topLevelButton.Caption = "Show in Windows Explorer";
				topLevelButton.ItemClick += (s, e) => Process.Start("explorer.exe", topLevelPath);
				popupLastSessions.AddItem(topLevelButton).BeginGroup = true;
			}

			var importButton = new BarButtonItem();
			importButton.Caption = "Import from folder";
			importButton.ItemClick += async (s, e) => await ImportWithDirectoryDialogAsync();
			popupLastSessions.AddItem(importButton).BeginGroup = true;
		}

		private void BiGitHub_ItemClick(object sender, ItemClickEventArgs e)
		{
			Navigate("https://fusionproject.sodacore.net");
		}

		private void BiTwitter_ItemClick(object sender, ItemClickEventArgs e)
		{
			Navigate("https://twitter.com/Waescher");
		}

		private void BiUpdate_ItemClick(object sender, ItemClickEventArgs e)
		{
			var url = biUpdate.Tag?.ToString() ?? "";
			if (!string.IsNullOrEmpty(url))
				Navigate(url);
		}

		private void Navigate(string url)
		{
			Process.Start(new ProcessStartInfo(url)
			{
				UseShellExecute = true
			});
		}

		public void MovePrevious()
		{
			viewLog.MovePrev();

			if (viewLog.GetFocusedRow() is AggregateLogItem item && item != _detailForm?.Item)
				_detailForm.Item = item;
		}

		public void MoveNext()
		{
			viewLog.MoveNext();

			if (viewLog.GetFocusedRow() is AggregateLogItem item && item != _detailForm?.Item)
				_detailForm.Item = item;
		}

		private void ShowSocialFlyout()
		{
			var socialScreenBounds = biTwitter.Links[0].ScreenBounds;
			socialScreenBounds.Width += biGitHub.Links[0].ScreenBounds.Width;

			var flyout = new DevExpress.Utils.FlyoutPanel { OwnerControl = this };
			flyout.Controls.Add(beakPanel);
			flyout.Size = beakPanel.Size;
			beakPanel.Dock = DockStyle.Fill;
			flyout.OptionsBeakPanel.BorderColor = Color.FromArgb(214, 255, 241);
			labelControl1.ForeColor = flyout.OptionsBeakPanel.BorderColor;
			beakPanel.Show();
			flyout.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Top;
			flyout.ShowBeakForm(socialScreenBounds);
		}

		private class RangeDatasourceItem
		{
			public DateTime TimeStampLocal { get; set; }
			public LogItem.State State { get; set; }
			public int? ItemCount { get; set; }
		}
	}
}