namespace FusionPlusPlus
{
	partial class MainForm
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
			DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.rangeData = new DevExpress.XtraEditors.RangeControl();
			this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
			this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridLog = new DevExpress.XtraGrid.GridControl();
			this.viewLog = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTimeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAppName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.toggleLog = new DevExpress.XtraEditors.ToggleSwitch();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
			this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.treeLog = new DevExpress.XtraTreeList.TreeList();
			this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.diagramLog = new DevExpress.XtraDiagram.DiagramControl();
			this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
			this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
			this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
			this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
			this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
			this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
			((System.ComponentModel.ISupportInitialize)(this.rangeData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleLog.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
			this.tabPane1.SuspendLayout();
			this.tabNavigationPage1.SuspendLayout();
			this.tabNavigationPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeLog)).BeginInit();
			this.tabNavigationPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.diagramLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
			this.SuspendLayout();
			// 
			// rangeData
			// 
			this.rangeData.AllowDrop = true;
			this.rangeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rangeData.Client = this.dateTimeChartRangeControlClient1;
			this.rangeData.Location = new System.Drawing.Point(139, 16);
			this.rangeData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rangeData.Name = "rangeData";
			rangeControlRange1.Maximum = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
			rangeControlRange1.Minimum = new System.DateTime(2018, 6, 26, 0, 0, 0, 0);
			rangeControlRange1.Owner = this.rangeData;
			this.rangeData.SelectedRange = rangeControlRange1;
			this.rangeData.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.ThumbAndFlag;
			this.rangeData.Size = new System.Drawing.Size(1113, 98);
			this.rangeData.TabIndex = 2;
			this.rangeData.Text = "rangeControl1";
			this.rangeData.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
			this.rangeData.RangeChanged += new DevExpress.XtraEditors.RangeChangedEventHandler(this.rangeData_RangeChanged);
			this.rangeData.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.rangeData.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			// 
			// colState
			// 
			this.colState.Caption = "State";
			this.colState.FieldName = "AccumulatedState";
			this.colState.Name = "colState";
			this.colState.OptionsColumn.FixedWidth = true;
			this.colState.Visible = true;
			this.colState.VisibleIndex = 1;
			this.colState.Width = 100;
			// 
			// gridLog
			// 
			this.gridLog.AllowDrop = true;
			this.gridLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridLog.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gridLog.Location = new System.Drawing.Point(0, 0);
			this.gridLog.MainView = this.viewLog;
			this.gridLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gridLog.Name = "gridLog";
			this.gridLog.Size = new System.Drawing.Size(1240, 591);
			this.gridLog.TabIndex = 0;
			this.gridLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewLog});
			this.gridLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.gridLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			// 
			// viewLog
			// 
			this.viewLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimeStamp,
            this.colState,
            this.colAppName,
            this.colDisplayName});
			this.viewLog.DetailHeight = 284;
			gridFormatRule1.ApplyToRow = true;
			gridFormatRule1.Column = this.colState;
			gridFormatRule1.Name = "Highlight Warnings";
			formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue1.Value1 = FusionPlusPlus.Model.LogItem.State.Warning;
			gridFormatRule1.Rule = formatConditionRuleValue1;
			gridFormatRule2.ApplyToRow = true;
			gridFormatRule2.Column = this.colState;
			gridFormatRule2.Name = "Highlight Errors";
			formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
			formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue2.Value1 = FusionPlusPlus.Model.LogItem.State.Error;
			gridFormatRule2.Rule = formatConditionRuleValue2;
			this.viewLog.FormatRules.Add(gridFormatRule1);
			this.viewLog.FormatRules.Add(gridFormatRule2);
			this.viewLog.GridControl = this.gridLog;
			this.viewLog.Name = "viewLog";
			this.viewLog.OptionsBehavior.Editable = false;
			this.viewLog.OptionsBehavior.ReadOnly = true;
			this.viewLog.OptionsMenu.ShowConditionalFormattingItem = true;
			this.viewLog.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTimeStamp, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colTimeStamp
			// 
			this.colTimeStamp.Caption = "Time Stamp";
			this.colTimeStamp.DisplayFormat.FormatString = "G";
			this.colTimeStamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colTimeStamp.FieldName = "TimeStampLocal";
			this.colTimeStamp.Name = "colTimeStamp";
			this.colTimeStamp.OptionsColumn.FixedWidth = true;
			this.colTimeStamp.Visible = true;
			this.colTimeStamp.VisibleIndex = 0;
			this.colTimeStamp.Width = 150;
			// 
			// colAppName
			// 
			this.colAppName.FieldName = "AppName";
			this.colAppName.Name = "colAppName";
			this.colAppName.OptionsColumn.FixedWidth = true;
			this.colAppName.Visible = true;
			this.colAppName.VisibleIndex = 2;
			this.colAppName.Width = 200;
			// 
			// colDisplayName
			// 
			this.colDisplayName.FieldName = "DisplayName";
			this.colDisplayName.Name = "colDisplayName";
			this.colDisplayName.Visible = true;
			this.colDisplayName.VisibleIndex = 3;
			this.colDisplayName.Width = 558;
			// 
			// toggleLog
			// 
			this.toggleLog.Location = new System.Drawing.Point(26, 65);
			this.toggleLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.toggleLog.Name = "toggleLog";
			this.toggleLog.Properties.OffText = "Off";
			this.toggleLog.Properties.OnText = "On";
			this.toggleLog.Properties.ShowText = false;
			this.toggleLog.Size = new System.Drawing.Size(71, 24);
			this.toggleLog.TabIndex = 1;
			this.toggleLog.Toggled += new System.EventHandler(this.toggleLog_Toggled);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(26, 41);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(55, 19);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Capture";
			// 
			// tabPane1
			// 
			this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
			this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabPane1.Controls.Add(this.tabNavigationPage1);
			this.tabPane1.Controls.Add(this.tabNavigationPage2);
			this.tabPane1.Controls.Add(this.tabNavigationPage3);
			this.tabPane1.Location = new System.Drawing.Point(12, 119);
			this.tabPane1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPane1.Name = "tabPane1";
			this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
			this.tabPane1.RegularSize = new System.Drawing.Size(1240, 618);
			this.tabPane1.SelectedPage = this.tabNavigationPage2;
			this.tabPane1.Size = new System.Drawing.Size(1240, 618);
			this.tabPane1.TabIndex = 4;
			this.tabPane1.Text = "Linear";
			// 
			// tabNavigationPage1
			// 
			this.tabNavigationPage1.Caption = "Linear";
			this.tabNavigationPage1.Controls.Add(this.gridLog);
			this.tabNavigationPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabNavigationPage1.Name = "tabNavigationPage1";
			this.tabNavigationPage1.Size = new System.Drawing.Size(1240, 591);
			// 
			// tabNavigationPage2
			// 
			this.tabNavigationPage2.Caption = "Hierarchical";
			this.tabNavigationPage2.Controls.Add(this.treeLog);
			this.tabNavigationPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabNavigationPage2.Name = "tabNavigationPage2";
			this.tabNavigationPage2.Size = new System.Drawing.Size(1240, 591);
			// 
			// treeLog
			// 
			this.treeLog.DataSource = typeof(FusionPlusPlus.Services.TreeLogItem);
			this.treeLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeLog.KeyFieldName = "Item.UniqueId";
			this.treeLog.Location = new System.Drawing.Point(0, 0);
			this.treeLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.treeLog.Name = "treeLog";
			this.treeLog.ParentFieldName = "Parent.UniqueId";
			this.treeLog.Size = new System.Drawing.Size(1240, 591);
			this.treeLog.TabIndex = 0;
			// 
			// tabNavigationPage3
			// 
			this.tabNavigationPage3.Caption = "Flow";
			this.tabNavigationPage3.Controls.Add(this.diagramLog);
			this.tabNavigationPage3.Name = "tabNavigationPage3";
			this.tabNavigationPage3.Size = new System.Drawing.Size(1240, 591);
			// 
			// diagramLog
			// 
			this.diagramLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.diagramLog.Location = new System.Drawing.Point(0, 0);
			this.diagramLog.Name = "diagramLog";
			this.diagramLog.OptionsBehavior.EnableProportionalResizing = false;
			this.diagramLog.OptionsBehavior.ScrollMode = DevExpress.Diagram.Core.DiagramScrollMode.Content;
			this.diagramLog.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
			this.diagramLog.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
			this.diagramLog.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
			this.diagramLog.OptionsView.ShowPageBreaks = false;
			this.diagramLog.Size = new System.Drawing.Size(1240, 591);
			this.diagramLog.TabIndex = 0;
			this.diagramLog.Text = "diagramControl1";
			// 
			// diagramDataBindingController1
			// 
			this.diagramDataBindingController1.ConnectorFromMember = "";
			this.diagramDataBindingController1.ConnectorsSource = null;
			this.diagramDataBindingController1.ConnectorToMember = "";
			this.diagramDataBindingController1.Diagram = this.diagramLog;
			this.diagramDataBindingController1.KeyMember = "";
			// 
			// 
			// 
			this.diagramDataBindingController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1});
			this.diagramDataBindingController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
			this.diagramDataBindingController1.TemplateDiagram.Name = "";
			this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
			this.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
			this.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
			this.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
			this.diagramDataBindingController1.TemplateDiagram.TabIndex = 0;
			// 
			// diagramContainer1
			// 
			this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
			this.diagramContainer1.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
			this.diagramContainer1.CanAddItems = false;
			this.diagramContainer1.CanCopyWithoutParent = true;
			this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
			this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
			this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3,
            this.diagramShape4});
			this.diagramContainer1.ItemsCanAttachConnectorBeginPoint = false;
			this.diagramContainer1.ItemsCanAttachConnectorEndPoint = false;
			this.diagramContainer1.ItemsCanChangeParent = false;
			this.diagramContainer1.ItemsCanCopyWithoutParent = false;
			this.diagramContainer1.ItemsCanDeleteWithoutParent = false;
			this.diagramContainer1.ItemsCanEdit = false;
			this.diagramContainer1.ItemsCanMove = false;
			this.diagramContainer1.ItemsCanResize = false;
			this.diagramContainer1.ItemsCanRotate = false;
			this.diagramContainer1.ItemsCanSelect = false;
			this.diagramContainer1.ItemsCanSnapToOtherItems = false;
			this.diagramContainer1.ItemsCanSnapToThisItem = false;
			this.diagramContainer1.MoveWithSubordinates = true;
			this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(-80F, 170F);
			this.diagramContainer1.Size = new System.Drawing.SizeF(380F, 146F);
			this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
			// 
			// diagramShape1
			// 
			this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right)));
			this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
			this.diagramShape1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.diagramShape1.Appearance.BorderSize = 0;
			this.diagramShape1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			this.diagramShape1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.diagramShape1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Item.DisplayName"));
			this.diagramShape1.CanCopy = false;
			this.diagramShape1.CanCopyWithoutParent = false;
			this.diagramShape1.CanEdit = false;
			this.diagramShape1.CanMove = false;
			this.diagramShape1.CanResize = false;
			this.diagramShape1.CanRotate = false;
			this.diagramShape1.CanSelect = false;
			this.diagramShape1.CanSnapToOtherItems = false;
			this.diagramShape1.CanSnapToThisItem = false;
			this.diagramShape1.Position = new DevExpress.Utils.PointFloat(10F, 15F);
			this.diagramShape1.Size = new System.Drawing.SizeF(370F, 54F);
			this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Subtle1;
			// 
			// diagramShape2
			// 
			this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
			this.diagramShape2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Item.AppName"));
			this.diagramShape2.CanCopy = false;
			this.diagramShape2.CanCopyWithoutParent = false;
			this.diagramShape2.CanEdit = false;
			this.diagramShape2.CanMove = false;
			this.diagramShape2.CanResize = false;
			this.diagramShape2.CanRotate = false;
			this.diagramShape2.CanSelect = false;
			this.diagramShape2.CanSnapToOtherItems = false;
			this.diagramShape2.CanSnapToThisItem = false;
			this.diagramShape2.Position = new DevExpress.Utils.PointFloat(0F, 116F);
			this.diagramShape2.Size = new System.Drawing.SizeF(380F, 30F);
			this.diagramShape2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1;
			this.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
			// 
			// diagramShape3
			// 
			this.diagramShape3.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right)));
			this.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
			this.diagramShape3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.diagramShape3.Appearance.BorderSize = 0;
			this.diagramShape3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.diagramShape3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.diagramShape3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.diagramShape3.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Item.TimeStampLocal"));
			this.diagramShape3.CanCopy = false;
			this.diagramShape3.CanCopyWithoutParent = false;
			this.diagramShape3.CanEdit = false;
			this.diagramShape3.CanMove = false;
			this.diagramShape3.CanResize = false;
			this.diagramShape3.CanRotate = false;
			this.diagramShape3.CanSelect = false;
			this.diagramShape3.CanSnapToOtherItems = false;
			this.diagramShape3.CanSnapToThisItem = false;
			this.diagramShape3.Position = new DevExpress.Utils.PointFloat(10F, 70F);
			this.diagramShape3.Size = new System.Drawing.SizeF(370F, 20F);
			this.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Subtle1;
			// 
			// diagramShape4
			// 
			this.diagramShape4.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right)));
			this.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
			this.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.diagramShape4.Appearance.BorderSize = 0;
			this.diagramShape4.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.diagramShape4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.diagramShape4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.diagramShape4.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Item.AccumulatedState"));
			this.diagramShape4.CanCopy = false;
			this.diagramShape4.CanCopyWithoutParent = false;
			this.diagramShape4.CanEdit = false;
			this.diagramShape4.CanMove = false;
			this.diagramShape4.CanResize = false;
			this.diagramShape4.CanRotate = false;
			this.diagramShape4.CanSelect = false;
			this.diagramShape4.CanSnapToOtherItems = false;
			this.diagramShape4.CanSnapToThisItem = false;
			this.diagramShape4.Position = new DevExpress.Utils.PointFloat(10F, 90F);
			this.diagramShape4.Size = new System.Drawing.SizeF(370F, 20F);
			this.diagramShape4.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Subtle1;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 746);
			this.Controls.Add(this.tabPane1);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.rangeData);
			this.Controls.Add(this.toggleLog);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fusion++";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.rangeData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleLog.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
			this.tabPane1.ResumeLayout(false);
			this.tabNavigationPage1.ResumeLayout(false);
			this.tabNavigationPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeLog)).EndInit();
			this.tabNavigationPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.diagramLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridLog;
		private DevExpress.XtraGrid.Views.Grid.GridView viewLog;
		private DevExpress.XtraEditors.ToggleSwitch toggleLog;
		private DevExpress.XtraGrid.Columns.GridColumn colTimeStamp;
		private DevExpress.XtraGrid.Columns.GridColumn colState;
		private DevExpress.XtraGrid.Columns.GridColumn colAppName;
		private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
		private DevExpress.XtraEditors.RangeControl rangeData;
		private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraBars.Navigation.TabPane tabPane1;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
		private DevExpress.XtraTreeList.TreeList treeLog;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
		private DevExpress.XtraDiagram.DiagramControl diagramLog;
		private DevExpress.XtraDiagram.DiagramDataBindingController diagramDataBindingController1;
		private DevExpress.XtraDiagram.DiagramContainer diagramContainer1;
		private DevExpress.XtraDiagram.DiagramShape diagramShape1;
		private DevExpress.XtraDiagram.DiagramShape diagramShape2;
		private DevExpress.XtraDiagram.DiagramShape diagramShape3;
		private DevExpress.XtraDiagram.DiagramShape diagramShape4;
	}
}

