using DevExpress.LookAndFeel;

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
			//UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.OfficeBlack);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
