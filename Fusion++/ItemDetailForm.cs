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

			memoItems.Styler = new FusionLogStyler();

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

		public AggregateLogItem Item { get; set; }
	}

	public class FusionLogStyler : ScintillaStyler
	{
		public FusionLogStyler()
			: base(Lexer.Cpp)
		{
		}

		public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
		{
			// Comments begin with ***, === or ---

			scintilla.Styles[Style.Cpp.Word].BackColor = Color.Orange;
			scintilla.Styles[Style.Cpp.Word2].BackColor = Color.Red;
		}

		public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
		{
		}

		public override void SetKeywords(ScintillaNET.Scintilla scintilla)
		{
			// TODO case-insensitive
			scintilla.SetKeywords(0, "WRN warning warnung");
			scintilla.SetKeywords(1, "ERR error failed fail Fehler");
		}
	}
}