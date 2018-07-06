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

namespace FusionPlusPlus
{
	public partial class MainForm : XtraForm
	{
		private bool _loading = false;
		private RegistryFusionService _fusionService;
		private string _originalFormText;
		private List<AggregateLogItem> _logs;
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

			var parser = new LogFileParser(new LogFileService(fusionService), new LogItemParser(), new FileReader());


			toggleLog.EditValue = _fusionService.Mode == LogMode.All;

			var sw = Stopwatch.StartNew();

			var logs = parser.Parse();

			_loading = false;

			return logs;
		}

		private void LoadLogs() => LoadLogs(_fusionService);

		private void LoadLogs(IFusionService fusionService)
		{
			var sw = Stopwatch.StartNew();

			var aggregator = new LogAggregator();
			var treeBuilder = new LogTreeBuilder();

			var logs = ReadLogs(fusionService);
			_logs = aggregator.Aggregate(logs);
			var diagramModel = new DiagramViewModel(treeBuilder.Build(_logs));

			// Generate a data table and bind the date-time client to it.
			dateTimeChartRangeControlClient1.DataProvider.DataSource = _logs;

			// Specify data members to bind the client.
			dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = nameof(LogItem.TimeStampLocal);
			dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = nameof(LogItem.Count);
			//dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = nameof(LogItem.AppName);

			gridLog.DataSource = _logs;

			diagramDataBindingController1.KeyMember = "UniqueId";
			diagramDataBindingController1.ConnectorFromMember = "From";
			diagramDataBindingController1.ConnectorToMember = "To";
			diagramDataBindingController1.DataSource = diagramModel.Items;
			diagramDataBindingController1.ConnectorsSource = diagramModel.Connections;

			sw.Stop();
			this.Text = _originalFormText + " (" + sw.ElapsedMilliseconds + " milliseconds)";
		}

		private void rangeData_RangeChanged(object sender, RangeControlRangeEventArgs range)
		{
			DateTime from = ((DateTime)range.Range.Minimum).ToUniversalTime();
			DateTime till = ((DateTime)range.Range.Maximum).ToUniversalTime();

			gridLog.DataSource = _logs?.Where(l => l.TimeStampUtc >= from && l.TimeStampUtc <= till).ToList();
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
	}
}