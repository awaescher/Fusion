using DevExpress.XtraEditors;
using System;
using FusionPlusPlus.IO;
using FusionPlusPlus.Model;
using FusionPlusPlus.Parser;
using FusionPlusPlus.Services;
using DevExpress.XtraGrid.Columns;
using System.Diagnostics;

namespace FusionPlusPlus
{
	public partial class MainForm : XtraForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			var fusionService = new RegistryFusionService();
			var fileService = new LogFileService(fusionService);
			var files = fileService.Get(LogSource.Default);
			var parser = new LogFileParser(new LogItemParser(), new FileReader());

			var sw = Stopwatch.StartNew();
			gridLog.DataSource = parser.Parse(files);
			sw.Stop();
			this.Text += " (" + sw.ElapsedMilliseconds + " milliseconds)";
		}
	}
}