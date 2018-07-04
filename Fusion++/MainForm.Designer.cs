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
			this.SuspendLayout();
			// 
			// rangeData
			// 
			this.rangeData.AllowDrop = true;
			this.rangeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rangeData.Client = this.dateTimeChartRangeControlClient1;
			this.rangeData.Location = new System.Drawing.Point(162, 20);
			this.rangeData.Name = "rangeData";
			rangeControlRange1.Maximum = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
			rangeControlRange1.Minimum = new System.DateTime(2018, 6, 26, 0, 0, 0, 0);
			rangeControlRange1.Owner = this.rangeData;
			this.rangeData.SelectedRange = rangeControlRange1;
			this.rangeData.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.ThumbAndFlag;
			this.rangeData.Size = new System.Drawing.Size(1299, 120);
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
			this.colState.MinWidth = 23;
			this.colState.Name = "colState";
			this.colState.OptionsColumn.FixedWidth = true;
			this.colState.Visible = true;
			this.colState.VisibleIndex = 1;
			this.colState.Width = 117;
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
			this.gridLog.Size = new System.Drawing.Size(1447, 730);
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
			this.colTimeStamp.MinWidth = 23;
			this.colTimeStamp.Name = "colTimeStamp";
			this.colTimeStamp.OptionsColumn.FixedWidth = true;
			this.colTimeStamp.Visible = true;
			this.colTimeStamp.VisibleIndex = 0;
			this.colTimeStamp.Width = 175;
			// 
			// colAppName
			// 
			this.colAppName.FieldName = "AppName";
			this.colAppName.MinWidth = 23;
			this.colAppName.Name = "colAppName";
			this.colAppName.OptionsColumn.FixedWidth = true;
			this.colAppName.Visible = true;
			this.colAppName.VisibleIndex = 2;
			this.colAppName.Width = 233;
			// 
			// colDisplayName
			// 
			this.colDisplayName.FieldName = "DisplayName";
			this.colDisplayName.MinWidth = 23;
			this.colDisplayName.Name = "colDisplayName";
			this.colDisplayName.Visible = true;
			this.colDisplayName.VisibleIndex = 3;
			this.colDisplayName.Width = 651;
			// 
			// toggleLog
			// 
			this.toggleLog.Location = new System.Drawing.Point(30, 80);
			this.toggleLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.toggleLog.Name = "toggleLog";
			this.toggleLog.Properties.OffText = "Off";
			this.toggleLog.Properties.OnText = "On";
			this.toggleLog.Properties.ShowText = false;
			this.toggleLog.Size = new System.Drawing.Size(83, 28);
			this.toggleLog.TabIndex = 1;
			this.toggleLog.Toggled += new System.EventHandler(this.toggleLog_Toggled);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(30, 51);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(70, 24);
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
			this.tabPane1.Location = new System.Drawing.Point(14, 146);
			this.tabPane1.Name = "tabPane1";
			this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
			this.tabPane1.RegularSize = new System.Drawing.Size(1447, 760);
			this.tabPane1.SelectedPage = this.tabNavigationPage2;
			this.tabPane1.Size = new System.Drawing.Size(1447, 760);
			this.tabPane1.TabIndex = 4;
			this.tabPane1.Text = "Linear";
			// 
			// tabNavigationPage1
			// 
			this.tabNavigationPage1.Caption = "Linear";
			this.tabNavigationPage1.Controls.Add(this.gridLog);
			this.tabNavigationPage1.Name = "tabNavigationPage1";
			this.tabNavigationPage1.Size = new System.Drawing.Size(1447, 730);
			// 
			// tabNavigationPage2
			// 
			this.tabNavigationPage2.Caption = "Hierarchical";
			this.tabNavigationPage2.Controls.Add(this.treeLog);
			this.tabNavigationPage2.Name = "tabNavigationPage2";
			this.tabNavigationPage2.Size = new System.Drawing.Size(1447, 730);
			// 
			// treeLog
			// 
			this.treeLog.DataSource = typeof(FusionPlusPlus.Services.TreeLogItem);
			this.treeLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeLog.KeyFieldName = "Item.UniqueId";
			this.treeLog.Location = new System.Drawing.Point(0, 0);
			this.treeLog.Name = "treeLog";
			this.treeLog.ParentFieldName = "Parent.UniqueId";
			this.treeLog.Size = new System.Drawing.Size(1447, 730);
			this.treeLog.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1475, 918);
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
	}
}

