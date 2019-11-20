using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace FusionPlusPlus.Controls
{
	public partial class EmptyOverlay : UserControl
	{
		public EmptyOverlay()
		{
			InitializeComponent();
		}

		public static EmptyOverlay PutOn(Control parent)
		{
			var overlay = new EmptyOverlay();

			overlay.Parent = parent;
			parent.Controls.Add(overlay);

			overlay.Dock = DockStyle.Fill;

			return overlay;
		}

		public void Remove()
		{
			Parent.Controls.Remove(this);
		}

		private void linkCopyright_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo("https://www.flaticon.com/free-icon/hills_119582")
			{
				UseShellExecute = true
			});
		}
	}
}
