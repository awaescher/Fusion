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
	public partial class LoadingOverlay : UserControl
	{
		public event EventHandler CancelRequested;

		public LoadingOverlay()
		{
			InitializeComponent();
		}

		public static LoadingOverlay PutOn(Control parent)
		{
			var overlay = new LoadingOverlay();

			overlay.Parent = parent;
			parent.Controls.Add(overlay);

			overlay.Dock = DockStyle.Fill;

			return overlay;
		}

		public void Remove()
		{
			Parent.Controls.Remove(this);
		}

		private void LblCancel_Click(object sender, EventArgs e)
		{
			CancelRequested?.Invoke(sender, e);
		}

		internal void SetProgress(int current, int total)
		{
			Invoke((Action)(() =>
			{
				progress.Properties.Maximum = total;
				progress.EditValue = current;
				progress.Visible = current > 0 && current < total;
			}));
		}
	}
}
