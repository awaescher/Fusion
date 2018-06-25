using DevExpress.LookAndFeel;
using FusionPlusPlus.Model;
using FusionPlusPlus.Parser;
using FusionPlusPlus.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FusionPlusPlus
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier);

			var fusionService = new RegistryFusionService();
			var fileService = new LogFileService(fusionService);
			var files = fileService.Get(LogSource.Default);
			var parser = new LogFileParser(new LogItemParser());
			var parsed = parser.Parse(files.First());

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
