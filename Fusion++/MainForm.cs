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

namespace FusionPlusPlus
{
	public partial class MainForm : XtraForm
	{
		private bool _loading = false;
		private RegistryFusionService _fusionService;
		private List<LogItem> _logs;

		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			_loading = true;

			_fusionService = new RegistryFusionService();
			var fileService = new LogFileService(_fusionService);
			var files = fileService.Get(LogSource.Default);
			var parser = new LogFileParser(new LogItemParser(), new FileReader());

			toggleLog.EditValue = _fusionService.Mode == LogMode.All;

			var sw = Stopwatch.StartNew();
			_logs = parser.Parse(files);

			// Generate a data table and bind the date-time client to it.
			dateTimeChartRangeControlClient1.DataProvider.DataSource = _logs;

			// Specify data members to bind the client.
			dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = nameof(LogItem.TimeStampLocal);
			dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = nameof(LogItem.Count);
			//dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = nameof(LogItem.AppName);

			gridLog.DataSource = _logs;
			sw.Stop();
			this.Text += " (" + sw.ElapsedMilliseconds + " milliseconds)";

			_loading = false;
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
	}

}