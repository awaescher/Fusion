using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionPlusPlus.Controls
{
	public partial class RecordingOverlay : UserControl
	{
		public RecordingOverlay()
		{
			InitializeComponent();
		}

		public static RecordingOverlay PutOn(Control parent)
		{
			var overlay = new RecordingOverlay();

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
	}
}
