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

namespace FusionPlusPlus
{
	public partial class MainForm : XtraForm
	{
		private bool _loading = false;
		private RegistryFusionService _fusionService;
		private List<AggregateLogItem> _logs;
		private string _lastUsedFilePath;
		private FusionSession _session;
        private Dictionary<OverlayState, Control> _overlays;

		public MainForm()
		{
			InitializeComponent();

			_fusionService = new RegistryFusionService();
		}

		protected override void OnShown(EventArgs e)
		{
            _overlays = new Dictionary<OverlayState, Control>();
            _overlays[OverlayState.Empty] = EmptyOverlay.PutOn(this);
			_overlays[OverlayState.Loading] = LoadingOverlay.PutOn(this);
			var recordingOverlay = RecordingOverlay.PutOn(this);
			recordingOverlay.StopRequested += btnCapture_Click;
			_overlays[OverlayState.Recording] = recordingOverlay;

			_overlays[OverlayState.Empty].SendToBack();
			_overlays[OverlayState.Loading].BringToFront();
			_overlays[OverlayState.Recording].BringToFront();

			var name = this.GetType().Assembly.GetName();
			Text = $"{name.Name} {name.Version.Major}.{name.Version.Minor}";

			base.OnShown(e);

			LoadLogs();
		}

		private List<LogItem> ReadLogs(ILogStore store)
		{
			_loading = true;

			var parser = new LogFileParser(new LogFileService(store), new LogItemParser(), new FileReader());

			var sw = Stopwatch.StartNew();

			var logs = parser.Parse();

			_loading = false;

			return logs;
		}

		private void ClearLogs() => LoadLogs("");

		private void LoadLogs() => LoadLogs(_fusionService.LogPath);

		private void LoadLogs(string path) => LoadLogs(new TransparentLogStore(path));

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

		private void LoadLogs(ILogStore logStore)
		{
            var hasPath = !string.IsNullOrEmpty(logStore.Path);
            if (hasPath)
                SetOverlayState(OverlayState.Loading);

			var aggregator = new LogAggregator();
			var treeBuilder = new LogTreeBuilder();

			var logs = ReadLogs(logStore);
			_logs = aggregator.Aggregate(logs);

			// Generate a data table and bind the date-time client to it.
			dateTimeChartRangeControlClient1.DataProvider.DataSource = _logs;

			// Specify data members to bind the client.
			dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = nameof(AggregateLogItem.TimeStampLocal);
			dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = nameof(AggregateLogItem.ItemCount);
			//dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = nameof(AggregateLogItem.AppName);

			gridLog.DataSource = _logs;


			var hasData = _logs.Any();
			gridLog.Visible = hasData;
			rangeData.Visible = hasData;
			btnOpen.Enabled = true;
			btnSave.Enabled = hasData && !string.IsNullOrEmpty(logStore.Path);
			btnSave.Tag = logStore.Path;

            if (hasData)
                SetOverlayState(OverlayState.None);
            else
                SetOverlayState(OverlayState.Empty);
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

		private void MainForm_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			var files = (string[])e.Data.GetData(DataFormats.FileDrop);

			if (files.Length == 1)
			{
				_lastUsedFilePath = files[0];
				LoadLogs(files[0]);
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.I && e.Control)
				ImportWithDirectoryDialog();
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

		private void btnCapture_Click(object sender, EventArgs e)
		{
			if (_fusionService == null || _loading)
				return;

			if (_session == null)
			{
                ClearLogs();

                SetOverlayState(OverlayState.Recording);

				_session = new FusionSession(_fusionService);
				_session.Start();

                btnOpen.Enabled = false;
                btnSave.Enabled = false;
			}
			else
			{
				_session.End();
				LoadLogs(_session.Store.Path);
				_session = null;

			}

			btnCapture.Text = _session == null ? "Capture" : "Stop";
			btnCapture.ImageOptions.SvgImage = _session == null ? Properties.Resources.Capture : Properties.Resources.Stop;
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			ImportWithDirectoryDialog();
		}

		private void ImportWithDirectoryDialog()
		{
			using (var dialog = new FolderBrowserDialog())
			{
				dialog.SelectedPath = _lastUsedFilePath ?? new TemporaryLogStore().TopLevelPath ?? "";
				if (dialog.ShowDialog() == DialogResult.OK)
					ImportFromDirectory(dialog.SelectedPath);
			}
		}

		private void ImportFromDirectory(string directory)
		{
			_lastUsedFilePath = directory;
			LoadLogs(directory);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var currentPath = btnSave.Tag.ToString();

			if (!Directory.Exists(currentPath))
				return;

			using (var dialog = new FolderBrowserDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
					DirectoryCloner.Clone(currentPath, dialog.SelectedPath);
			}
		}

		private void popupLastSessions_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
		{
			PopulateLastSessions();
		}

		private void PopulateLastSessions()
		{
			popupLastSessions.ClearLinks();

			var topLevelPath = new TemporaryLogStore().TopLevelPath;

			if (!Directory.Exists(topLevelPath))
				return;

			foreach (var sessionPath in Directory.GetDirectories(topLevelPath).OrderByDescending(dir => dir))
			{
				var button = new BarButtonItem();
				button.Caption = Path.GetFileName(sessionPath);
				button.ItemClick += (s, e) => ImportFromDirectory(sessionPath);
				popupLastSessions.AddItem(button);
			}
		}
	}
}