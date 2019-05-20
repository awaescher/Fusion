namespace FusionPlusPlus
{
	partial class ItemDetailForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetailForm));
			this.richLog = new DevExpress.XtraRichEdit.RichEditControl();
			this.SuspendLayout();
			// 
			// richLog
			// 
			this.richLog.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
			this.richLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richLog.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
			this.richLog.Location = new System.Drawing.Point(0, 0);
			this.richLog.Name = "richLog";
			this.richLog.Options.AutoCorrect.ReplaceTextAsYouType = false;
			this.richLog.Options.Behavior.CreateNew = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.Behavior.Open = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.Behavior.Save = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.Behavior.SaveAs = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.Bookmarks.Visibility = DevExpress.XtraRichEdit.RichEditBookmarkVisibility.Hidden;
			this.richLog.Options.Comments.Visibility = DevExpress.XtraRichEdit.RichEditCommentVisibility.Hidden;
			this.richLog.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.Comments = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.EndNotes = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.Fields = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.FloatingObjects = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.FootNotes = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.InlinePictures = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.InlineShapes = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.Numbering.Bulleted = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.Numbering.MultiLevel = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.Numbering.Simple = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.ParagraphFormatting = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.ParagraphFrames = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.ParagraphStyle = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.ParagraphTabs = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.Sections = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.Tables = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.DocumentCapabilities.TableStyle = DevExpress.XtraRichEdit.DocumentCapability.Hidden;
			this.richLog.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
			this.richLog.Options.SpellChecker.AutoDetectDocumentCulture = false;
			this.richLog.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
			this.richLog.Size = new System.Drawing.Size(933, 554);
			this.richLog.TabIndex = 0;
			this.richLog.Views.DraftView.AdjustColorsToSkins = true;
			this.richLog.Views.DraftView.AllowDisplayLineNumbers = true;
			this.richLog.Views.DraftView.Padding = new System.Windows.Forms.Padding(80, 4, 0, 0);
			this.richLog.InitializeDocument += new System.EventHandler(this.RichLog_InitializeDocument);
			// 
			// ItemDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 554);
			this.Controls.Add(this.richLog);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ItemDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Detail";
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraRichEdit.RichEditControl richLog;
	}
}