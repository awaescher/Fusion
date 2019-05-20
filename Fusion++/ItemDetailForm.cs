using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Services;
using FusionPlusPlus.Model;
using FusionPlusPlus.Syntax;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FusionPlusPlus
{
	public partial class ItemDetailForm : XtraForm
	{
		public ItemDetailForm()
		{
			InitializeComponent();
			richLog.ReplaceService<ISyntaxHighlightService>(new FusionLogSyntaxHighlightService(richLog.Document));
		}
		
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			if (Item != null)
			{
				var itemBreak = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
				richLog.Text = string.Join(itemBreak, Item.Items.Select(i => i.FullMessage));
				Text = Item.ShortAssemblyName;
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			if (e.KeyCode == Keys.Escape)
				this.Close();
		}

		public AggregateLogItem Item { get; set; }

		private void RichLog_InitializeDocument(object sender, EventArgs e)
		{
			var document = richLog.Document;
			document.BeginUpdate();
			try
			{
				document.DefaultCharacterProperties.FontName = "Consolas";
				document.DefaultCharacterProperties.FontSize = 9;
				document.Sections[0].Page.Width = Units.InchesToDocumentsF(50);
				document.Sections[0].LineNumbering.CountBy = 1;
				document.Sections[0].LineNumbering.RestartType = DevExpress.XtraRichEdit.API.Native.LineNumberingRestart.Continuous;
				document.CharacterStyles["Line Number"].ForeColor = Color.DeepSkyBlue;
			}
			finally
			{
				document.EndUpdate();
			}
		}
	}
}