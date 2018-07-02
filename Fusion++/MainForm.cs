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

namespace FusionPlusPlus
{
	public partial class MainForm : XtraForm
	{
		private bool _loading = false;
		private RegistryFusionService _fusionService;
		private string _originalFormText;
		private List<LogItem> _logs;
		private string _lastUsedFilePath;

		public MainForm()
		{
			InitializeComponent();

			_fusionService = new RegistryFusionService();
			_originalFormText = this.Text;
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			LoadLogs();
		}

		private List<LogItem> ReadLogs(IFusionService fusionService)
		{
			_loading = true;

			var fileService = new LogFileService(fusionService);
			var files = fileService.Get(LogSource.Default);
			var parser = new LogFileParser(new LogItemParser(), new FileReader());

			toggleLog.EditValue = _fusionService.Mode == LogMode.All;

			var sw = Stopwatch.StartNew();
			var logs = parser.Parse(files);

			_loading = false;

			return logs;
		}

		private void LoadLogs() => LoadLogs(_fusionService);

		private void LoadLogs(IFusionService fusionService)
		{
			var sw = Stopwatch.StartNew();

			_logs = ReadLogs(fusionService);

			// Generate a data table and bind the date-time client to it.
			dateTimeChartRangeControlClient1.DataProvider.DataSource = _logs;

			// Specify data members to bind the client.
			dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = nameof(LogItem.TimeStampLocal);
			dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = nameof(LogItem.Count);
			//dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = nameof(LogItem.AppName);

			gridLog.DataSource = _logs;

			sw.Stop();
			this.Text = _originalFormText + " (" + sw.ElapsedMilliseconds + " milliseconds)";
		}

		private void rangeData_RangeChanged(object sender, RangeControlRangeEventArgs range)
		{
			DateTime from = (DateTime)range.Range.Minimum;
			DateTime till = (DateTime)range.Range.Maximum;

			gridLog.DataSource = _logs?.Where(l => l.TimeStampLocal >= from && l.TimeStampLocal <= till).ToList();
		}

		private void toggleLog_Toggled(object sender, EventArgs e)
		{
			if (_fusionService == null || _loading)
				return;

			_fusionService.Mode = (bool)toggleLog.EditValue ? LogMode.All : LogMode.Disabled;
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
				LoadLogs(new DiskReadOnlyFusionService(files[0]));
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.O && e.Control)
			{
				var dialog = new FolderBrowserDialog();
				dialog.SelectedPath = _lastUsedFilePath ?? _fusionService.LogPath ?? "";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					_lastUsedFilePath = dialog.SelectedPath;
					LoadLogs(new DiskReadOnlyFusionService(dialog.SelectedPath));
				}
			}
		}
	}
}