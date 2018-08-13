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
			this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
			this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.diagramLog = new DevExpress.XtraDiagram.DiagramControl();
			this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
			this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
			this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
			this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
			this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
			this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
			this.diagramShape5 = new DevExpress.XtraDiagram.DiagramShape();
			this.btnCapture = new DevExpress.XtraEditors.SimpleButton();
			this.btnOpen = new DevExpress.XtraEditors.DropDownButton();
			this.popupLastSessions = new DevExpress.XtraBars.PopupMenu(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.rangeData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
			this.tabPane1.SuspendLayout();
			this.tabNavigationPage1.SuspendLayout();
			this.tabNavigationPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.diagramLog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupLastSessions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// rangeData
			// 
			this.rangeData.AllowDrop = true;
			this.rangeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rangeData.Client = this.dateTimeChartRangeControlClient1;
			this.rangeData.Location = new System.Drawing.Point(127, 16);
			this.rangeData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rangeData.Name = "rangeData";
			rangeControlRange1.Maximum = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
			rangeControlRange1.Minimum = new System.DateTime(2018, 6, 26, 0, 0, 0, 0);
			rangeControlRange1.Owner = this.rangeData;
			this.rangeData.SelectedRange = rangeControlRange1;
			this.rangeData.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.ThumbAndFlag;
			this.rangeData.Size = new System.Drawing.Size(1125, 98);
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
			this.viewLog.OptionsDetail.EnableMasterViewMode = false;
			this.viewLog.OptionsMenu.ShowConditionalFormattingItem = true;
			this.viewLog.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTimeStamp, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.viewLog.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewLog_RowClick);
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
			// tabPane1
			// 
			this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
			this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabPane1.Controls.Add(this.tabNavigationPage1);
			this.tabPane1.Controls.Add(this.tabNavigationPage3);
			this.tabPane1.Location = new System.Drawing.Point(12, 119);
			this.tabPane1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPane1.Name = "tabPane1";
			this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage3});
			this.tabPane1.RegularSize = new System.Drawing.Size(1240, 618);
			this.tabPane1.SelectedPage = this.tabNavigationPage1;
			this.tabPane1.Size = new System.Drawing.Size(1240, 618);
			this.tabPane1.TabIndex = 4;
			this.tabPane1.Text = "Linear";
			// 
			// tabNavigationPage1
			// 
			this.tabNavigationPage1.Caption = "List";
			this.tabNavigationPage1.Controls.Add(this.gridLog);
			this.tabNavigationPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabNavigationPage1.Name = "tabNavigationPage1";
			this.tabNavigationPage1.Size = new System.Drawing.Size(1240, 591);
			// 
			// tabNavigationPage3
			// 
			this.tabNavigationPage3.Caption = "Flow diagram";
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
            this.diagramShape4,
            this.diagramShape5});
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
			this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "DisplayName"));
			this.diagramShape1.CanCopy = false;
			this.diagramShape1.CanCopyWithoutParent = false;
			this.diagramShape1.CanEdit = false;
			this.diagramShape1.CanMove = false;
			this.diagramShape1.CanResize = false;
			this.diagramShape1.CanRotate = false;
			this.diagramShape1.CanSelect = false;
			this.diagramShape1.CanSnapToOtherItems = false;
			this.diagramShape1.CanSnapToThisItem = false;
			this.diagramShape1.Position = new DevExpress.Utils.PointFloat(10F, 39F);
			this.diagramShape1.Size = new System.Drawing.SizeF(370F, 30F);
			this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Subtle1;
			// 
			// diagramShape2
			// 
			this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
			this.diagramShape2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "AppName"));
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
			this.diagramShape3.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "TimeStampLocal"));
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
			this.diagramShape4.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "AccumulatedState"));
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
			// diagramShape5
			// 
			this.diagramShape5.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right)));
			this.diagramShape5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.diagramShape5.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "ShortAssemblyName"));
			this.diagramShape5.CanCopy = false;
			this.diagramShape5.CanCopyWithoutParent = false;
			this.diagramShape5.CanEdit = false;
			this.diagramShape5.CanMove = false;
			this.diagramShape5.CanResize = false;
			this.diagramShape5.CanRotate = false;
			this.diagramShape5.CanSelect = false;
			this.diagramShape5.CanSnapToOtherItems = false;
			this.diagramShape5.CanSnapToThisItem = false;
			this.diagramShape5.Size = new System.Drawing.SizeF(380F, 30F);
			this.diagramShape5.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1;
			this.diagramShape5.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
			// 
			// btnCapture
			// 
			this.btnCapture.AllowFocus = false;
			this.btnCapture.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.btnCapture.ImageOptions.SvgImage = global::FusionPlusPlus.Properties.Resources.Capture;
			this.btnCapture.Location = new System.Drawing.Point(12, 16);
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Size = new System.Drawing.Size(109, 72);
			this.btnCapture.TabIndex = 5;
			this.btnCapture.Text = "Capture";
			this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.AllowFocus = false;
			this.btnOpen.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.SplitButton;
			this.btnOpen.DropDownButtonPadding = new System.Windows.Forms.Padding(-4, 0, -4, 0);
			this.btnOpen.DropDownControl = this.popupLastSessions;
			this.btnOpen.Location = new System.Drawing.Point(12, 89);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(60, 25);
			this.btnOpen.TabIndex = 5;
			this.btnOpen.Text = "Import";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// popupLastSessions
			// 
			this.popupLastSessions.Manager = this.barManager1;
			this.popupLastSessions.Name = "popupLastSessions";
			this.popupLastSessions.BeforePopup += new System.ComponentModel.CancelEventHandler(this.popupLastSessions_BeforePopup);
			// 
			// barManager1
			// 
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.MaxItemId = 0;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(1264, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 746);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1264, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 746);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1264, 0);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 746);
			// 
			// btnSave
			// 
			this.btnSave.AllowFocus = false;
			this.btnSave.Location = new System.Drawing.Point(73, 89);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(48, 25);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Export";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 746);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnCapture);
			this.Controls.Add(this.tabPane1);
			this.Controls.Add(this.rangeData);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
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
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
			this.tabPane1.ResumeLayout(false);
			this.tabNavigationPage1.ResumeLayout(false);
			this.tabNavigationPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.diagramLog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupLastSessions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridLog;
		private DevExpress.XtraGrid.Views.Grid.GridView viewLog;
		private DevExpress.XtraGrid.Columns.GridColumn colTimeStamp;
		private DevExpress.XtraGrid.Columns.GridColumn colState;
		private DevExpress.XtraGrid.Columns.GridColumn colAppName;
		private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
		private DevExpress.XtraEditors.RangeControl rangeData;
		private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
		private DevExpress.XtraBars.Navigation.TabPane tabPane1;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
		private DevExpress.XtraDiagram.DiagramControl diagramLog;
		private DevExpress.XtraDiagram.DiagramDataBindingController diagramDataBindingController1;
		private DevExpress.XtraDiagram.DiagramContainer diagramContainer1;
		private DevExpress.XtraDiagram.DiagramShape diagramShape1;
		private DevExpress.XtraDiagram.DiagramShape diagramShape2;
		private DevExpress.XtraDiagram.DiagramShape diagramShape3;
		private DevExpress.XtraDiagram.DiagramShape diagramShape4;
		private DevExpress.XtraDiagram.DiagramShape diagramShape5;
		private DevExpress.XtraEditors.SimpleButton btnCapture;
		private DevExpress.XtraEditors.DropDownButton btnOpen;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraBars.PopupMenu popupLastSessions;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}

