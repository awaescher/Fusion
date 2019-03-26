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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingOverlay));
            this.lblRecording = new DevExpress.XtraEditors.LabelControl();
            this.lblDuration = new DevExpress.XtraEditors.LabelControl();
            this.lblStop = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblRecording
            // 
            this.lblRecording.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRecording.Appearance.Options.UseFont = true;
            this.lblRecording.Appearance.Options.UseTextOptions = true;
            this.lblRecording.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRecording.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblRecording.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecording.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecording.Location = new System.Drawing.Point(0, 0);
            this.lblRecording.Name = "lblRecording";
            this.lblRecording.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblRecording.Size = new System.Drawing.Size(728, 139);
            this.lblRecording.TabIndex = 0;
            this.lblRecording.Text = "Recording";
            // 
            // lblDuration
            // 
            this.lblDuration.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Appearance.Options.UseFont = true;
            this.lblDuration.Appearance.Options.UseTextOptions = true;
            this.lblDuration.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDuration.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblDuration.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDuration.Location = new System.Drawing.Point(0, 139);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(728, 146);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "00:05:24";
            // 
            // lblStop
            // 
            this.lblStop.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStop.Appearance.Options.UseFont = true;
            this.lblStop.Appearance.Options.UseForeColor = true;
            this.lblStop.Appearance.Options.UseTextOptions = true;
            this.lblStop.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblStop.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStop.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl3.ImageOptions.SvgImage")));
            this.lblStop.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.lblStop.Location = new System.Drawing.Point(331, 174);
            this.lblStop.Name = "lblStop";
            this.lblStop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblStop.Size = new System.Drawing.Size(84, 31);
            this.lblStop.TabIndex = 2;
            this.lblStop.Text = "Stop";
            this.lblStop.Click += new System.EventHandler(this.LblStop_Click);
            // 
            // RecordingOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblRecording);
            this.Controls.Add(this.lblDuration);
            this.Name = "RecordingOverlay";
            this.Size = new System.Drawing.Size(728, 285);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl lblRecording;
        private DevExpress.XtraEditors.LabelControl lblDuration;
        private DevExpress.XtraEditors.LabelControl lblStop;
    }
}
