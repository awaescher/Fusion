using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionPlusPlus.Forms
{
	public class HintForm : Form
	{
		public static HintForm Show(Form parent, string hint)
		{
			var form = new HintForm
			{
				Size = new Size(30, 30),
				TopMost = true,
				FormBorderStyle = FormBorderStyle.None,
				StartPosition = FormStartPosition.Manual,
				BackColor = Color.Black,
				Opacity = 0.85
			};
			var label = new Label()
			{
				Text = hint,
				TextAlign = ContentAlignment.MiddleCenter,
				Dock = DockStyle.Fill,
				ForeColor = Color.White,
				BorderStyle = BorderStyle.FixedSingle,
				Visible = true
			};
			form.Controls.Add(label);

			form.MinimumSize = new Size(label.PreferredWidth + 20, form.Height);
			form.MaximumSize = form.MinimumSize;

			form.Location = new Point(parent.Left + parent.Width / 2 - form.Width / 2, parent.Top + parent.Height / 2 - form.Height / 2);
			form.Show(parent);

			Application.DoEvents();

			return form;
		}
	}
}
