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
			this.lblCancel = new DevExpress.XtraEditors.LabelControl();
			this.progress = new DevExpress.XtraEditors.ProgressBarControl();
			this.lblRecording = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.progress.Properties)).BeginInit();
			this.SuspendLayout();
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
			this.lblCancel.Location = new System.Drawing.Point(527, 330);
			this.lblCancel.Margin = new System.Windows.Forms.Padding(4);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lblCancel.Size = new System.Drawing.Size(151, 29);
			this.lblCancel.TabIndex = 3;
			this.lblCancel.Text = "Cancel";
			this.lblCancel.Click += new System.EventHandler(this.LblCancel_Click);
			// 
			// progress
			// 
			this.progress.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progress.Cursor = System.Windows.Forms.Cursors.Hand;
			this.progress.Location = new System.Drawing.Point(547, 278);
			this.progress.Margin = new System.Windows.Forms.Padding(4);
			this.progress.Name = "progress";
			this.progress.ShowProgressInTaskBar = true;
			this.progress.Size = new System.Drawing.Size(107, 29);
			this.progress.TabIndex = 4;
			this.progress.Visible = false;
			// 
			// lblRecording
			// 
			this.lblRecording.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblRecording.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lblRecording.Appearance.Options.UseFont = true;
			this.lblRecording.Appearance.Options.UseTextOptions = true;
			this.lblRecording.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lblRecording.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
			this.lblRecording.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblRecording.Location = new System.Drawing.Point(523, 217);
			this.lblRecording.Margin = new System.Windows.Forms.Padding(4);
			this.lblRecording.Name = "lblRecording";
			this.lblRecording.Size = new System.Drawing.Size(155, 54);
			this.lblRecording.TabIndex = 5;
			this.lblRecording.Text = "Parsing";
			// 
			// LoadingOverlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblRecording);
			this.Controls.Add(this.progress);
			this.Controls.Add(this.lblCancel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoadingOverlay";
			this.Size = new System.Drawing.Size(1200, 600);
			((System.ComponentModel.ISupportInitialize)(this.progress.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.LabelControl lblCancel;
		private DevExpress.XtraEditors.ProgressBarControl progress;
		private DevExpress.XtraEditors.LabelControl lblRecording;
	}
}
