using DevExpress.XtraEditors;
using EasyScintilla.Stylers;
using FusionPlusPlus.Model;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionPlusPlus
{
	public partial class ItemDetailForm : XtraForm
	{
		public ItemDetailForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Item != null)
				Text = Item.ShortAssemblyName;
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			if (Item != null)
			{
				var itemBreak = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
				memoItems.Text = string.Join(itemBreak, Item.Items.Select(i => i.FullMessage));
				memoItems.SelectionStart = 0;
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			if (e.KeyCode == Keys.Escape)
				this.Close();
		}

		public AggregateLogItem Item { get; set; }
	}
}