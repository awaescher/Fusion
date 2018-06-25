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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
			this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(54, 127);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(350, 200);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// toggleSwitch1
			// 
			this.toggleSwitch1.Location = new System.Drawing.Point(54, 23);
			this.toggleSwitch1.Name = "toggleSwitch1";
			this.toggleSwitch1.Properties.OffText = "Off";
			this.toggleSwitch1.Properties.OnText = "On";
			this.toggleSwitch1.Size = new System.Drawing.Size(83, 28);
			this.toggleSwitch1.TabIndex = 1;
			// 
			// buttonEdit1
			// 
			this.buttonEdit1.Location = new System.Drawing.Point(160, 26);
			this.buttonEdit1.Name = "buttonEdit1";
			this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.buttonEdit1.Size = new System.Drawing.Size(109, 22);
			this.buttonEdit1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 450);
			this.Controls.Add(this.buttonEdit1);
			this.Controls.Add(this.toggleSwitch1);
			this.Controls.Add(this.gridControl1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
		private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
	}
}

