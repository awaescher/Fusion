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
			: base(Lexer.Null)
		{
		}


		public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
		{
			// Comments begin with ***, === or ---



			var backColor = Color.FromArgb(30, 30, 30);
			var foreColor = Color.FromArgb(220, 220, 220);

			foreach (var style in scintilla.Styles)
			{
				style.BackColor = backColor;
				style.ForeColor = foreColor;
			}

			scintilla.Styles[Style.IndentGuide].ForeColor = Color.FromArgb(105, 105, 105);
			scintilla.Styles[Style.LineNumber].ForeColor = Color.FromArgb(146, 206, 255); // Bright Blue
			scintilla.Styles[Style.Cpp.Word].BackColor = Color.DarkOrange;
			scintilla.Styles[Style.Cpp.Word2].BackColor = Color.DarkRed;

			scintilla.CaretForeColor = foreColor;

			scintilla.SetFoldMarginHighlightColor(true, backColor);
			scintilla.SetFoldMarginColor(true, backColor);

			scintilla.SetSelectionBackColor(true, Color.FromArgb(38, 79, 120));
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