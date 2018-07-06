using DevExpress.XtraEditors;
using FusionPlusPlus.Model;
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
				memoItems.SelectionLength = 0;
			}
		}

		public AggregateLogItem Item { get; set; }
	}
}