namespace FusionPlusPlus.Controls
{
	partial class RecordingOverlay
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
			this.lblRecording = new DevExpress.XtraEditors.LabelControl();
			this.lblDuration = new DevExpress.XtraEditors.LabelControl();
			this.lblStop = new DevExpress.XtraEditors.LabelControl();
			this.SuspendLayout();
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
			this.lblRecording.TabIndex = 0;
			this.lblRecording.Text = "Recording";
			// 
			// lblDuration
			// 
			this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDuration.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDuration.Appearance.Options.UseFont = true;
			this.lblDuration.Appearance.Options.UseTextOptions = true;
			this.lblDuration.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lblDuration.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.lblDuration.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.lblDuration.Location = new System.Drawing.Point(523, 270);
			this.lblDuration.Margin = new System.Windows.Forms.Padding(4);
			this.lblDuration.Name = "lblDuration";
			this.lblDuration.Padding = new System.Windows.Forms.Padding(0, 6, 0, 15);
			this.lblDuration.Size = new System.Drawing.Size(157, 52);
			this.lblDuration.TabIndex = 1;
			this.lblDuration.Text = "00:05:24";
			// 
			// lblStop
			// 
			this.lblStop.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblStop.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStop.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblStop.Appearance.Options.UseFont = true;
			this.lblStop.Appearance.Options.UseForeColor = true;
			this.lblStop.Appearance.Options.UseTextOptions = true;
			this.lblStop.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lblStop.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.lblStop.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.lblStop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblStop.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblStop.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
			this.lblStop.Location = new System.Drawing.Point(527, 330);
			this.lblStop.Margin = new System.Windows.Forms.Padding(4);
			this.lblStop.Name = "lblStop";
			this.lblStop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lblStop.Size = new System.Drawing.Size(151, 29);
			this.lblStop.TabIndex = 2;
			this.lblStop.Text = "Stop";
			this.lblStop.Click += new System.EventHandler(this.LblStop_Click);
			// 
			// RecordingOverlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblStop);
			this.Controls.Add(this.lblDuration);
			this.Controls.Add(this.lblRecording);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RecordingOverlay";
			this.Size = new System.Drawing.Size(1200, 600);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl lblRecording;
        private DevExpress.XtraEditors.LabelControl lblDuration;
        private DevExpress.XtraEditors.LabelControl lblStop;
	}
}
