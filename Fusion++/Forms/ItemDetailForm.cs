using DevExpress.Office.Utils;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Services;
using FusionPlusPlus.Helper;
using FusionPlusPlus.Model;
using FusionPlusPlus.Syntax;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FusionPlusPlus.Forms
{
	public partial class ItemDetailForm : ToolbarForm
	{
		private AggregateLogItem _item;

		public ItemDetailForm()
		{
			InitializeComponent();
			richLog.ReplaceService<ISyntaxHighlightService>(new FusionLogSyntaxHighlightService(richLog.Document));
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			if (e.KeyCode == Keys.Escape)
				this.Close();
		}


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

		private void BiPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ItemNavigator.MovePrevious();
		}

		private void BiNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ItemNavigator.MoveNext();
		}

		public AggregateLogItem Item
		{
			get => _item;
			set
			{
				_item = value;

				if (_item != null)
				{
					var itemBreak = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
					richLog.Text = string.Join(itemBreak, _item.Items.Select(i => i.FullMessage));
					Text = _item.ShortAssemblyName;
				}
				else
				{
					richLog.Text = "";
					Text = "";
				}

				ActiveGlowColor = InactiveGlowColor = ColorService.GetColor(_item?.AccumulatedState ?? LogItem.State.Information);
			}
		}

		public ILogItemNavigator ItemNavigator { get; set; }
	}
}