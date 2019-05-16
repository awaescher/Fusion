namespace FusionPlusPlus.Controls
{
	partial class LoadingOverlay
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.lblCancel = new DevExpress.XtraEditors.LabelControl();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelControl1.Location = new System.Drawing.Point(0, 0);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(728, 285);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Reading and parsing all the fusion log files.\r\nI know it could be faster but hey " +
    "...\r\n\r\n¯\\_(ツ)_/¯";
			// 
			// lblCancel
			// 
			this.lblCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblCancel.Appearance.Options.UseFont = true;
			this.lblCancel.Appearance.Options.UseForeColor = true;
			this.lblCancel.Appearance.Options.UseTextOptions = true;
			this.lblCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lblCancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.lblCancel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCancel.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCancel.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
			this.lblCancel.Location = new System.Drawing.Point(310, 194);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.lblCancel.Size = new System.Drawing.Size(113, 23);
			this.lblCancel.TabIndex = 3;
			this.lblCancel.Text = "Cancel";
			this.lblCancel.Click += new System.EventHandler(this.LblCancel_Click);
			// 
			// LoadingOverlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblCancel);
			this.Controls.Add(this.labelControl1);
			this.Name = "LoadingOverlay";
			this.Size = new System.Drawing.Size(728, 285);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl lblCancel;
	}
}
