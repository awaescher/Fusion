using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			overlay.SendToBack();

			return overlay;
		}

		public void Remove()
		{
			Parent.Controls.Remove(this);
		}

        private void linkCopyright_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icon/hills_119582");
        }
    }
}
