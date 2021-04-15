namespace FusionPlusPlus.Forms
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetailForm));
			this.richLog = new DevExpress.XtraRichEdit.RichEditControl();
			this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.biPrevious = new DevExpress.XtraBars.BarButtonItem();
			this.biNext = new DevExpress.XtraBars.BarButtonItem();
			this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// richLog
			// 
			this.richLog.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
			this.richLog.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.richLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richLog.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
			this.richLog.Location = new System.Drawing.Point(0, 27);
			this.richLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richLog.MenuManager = this.toolbarFormManager1;
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
			this.richLog.ReadOnly = true;
			this.richLog.Size = new System.Drawing.Size(800, 423);
			this.richLog.TabIndex = 0;
			this.richLog.Views.DraftView.AdjustColorsToSkins = true;
			this.richLog.Views.DraftView.AllowDisplayLineNumbers = true;
			this.richLog.Views.DraftView.Padding = new DevExpress.Portable.PortablePadding(80, 4, 0, 0);
			this.richLog.InitializeDocument += new System.EventHandler(this.RichLog_InitializeDocument);
			// 
			// toolbarFormManager1
			// 
			this.toolbarFormManager1.AllowCustomization = false;
			this.toolbarFormManager1.AllowGlyphSkinning = true;
			this.toolbarFormManager1.AllowQuickCustomization = false;
			this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
			this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
			this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
			this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
			this.toolbarFormManager1.Form = this;
			this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.biPrevious,
            this.biNext});
			this.toolbarFormManager1.MaxItemId = 2;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 27);
			this.barDockControlTop.Manager = this.toolbarFormManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
			this.barDockControlBottom.Manager = this.toolbarFormManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
			this.barDockControlLeft.Manager = this.toolbarFormManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(800, 27);
			this.barDockControlRight.Manager = this.toolbarFormManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
			// 
			// biPrevious
			// 
			this.biPrevious.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.biPrevious.Caption = "Previous";
			this.biPrevious.Id = 0;
			this.biPrevious.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biPrevious.ImageOptions.SvgImage")));
			this.biPrevious.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up));
			this.biPrevious.Name = "biPrevious";
			this.biPrevious.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
			this.biPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BiPrevious_ItemClick);
			// 
			// biNext
			// 
			this.biNext.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.biNext.Caption = "Next";
			this.biNext.Id = 1;
			this.biNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biNext.ImageOptions.SvgImage")));
			this.biNext.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down));
			this.biNext.Name = "biNext";
			this.biNext.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
			this.biNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BiNext_ItemClick);
			// 
			// toolbarFormControl1
			// 
			this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
			this.toolbarFormControl1.Manager = this.toolbarFormManager1;
			this.toolbarFormControl1.Name = "toolbarFormControl1";
			this.toolbarFormControl1.Size = new System.Drawing.Size(800, 27);
			this.toolbarFormControl1.TabIndex = 1;
			this.toolbarFormControl1.TabStop = false;
			this.toolbarFormControl1.TitleItemLinks.Add(this.biNext);
			this.toolbarFormControl1.TitleItemLinks.Add(this.biPrevious);
			this.toolbarFormControl1.ToolbarForm = this;
			// 
			// ItemDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richLog);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Controls.Add(this.toolbarFormControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "ItemDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Detail";
			this.ToolbarFormControl = this.toolbarFormControl1;
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraRichEdit.RichEditControl richLog;
		private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
		private DevExpress.XtraBars.BarButtonItem biNext;
		private DevExpress.XtraBars.BarButtonItem biPrevious;
	}
}