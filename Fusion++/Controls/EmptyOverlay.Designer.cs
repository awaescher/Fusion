namespace FusionPlusPlus.Controls
{
	partial class EmptyOverlay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyOverlay));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.linkCopyright = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(900, 488);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// linkCopyright
			// 
			this.linkCopyright.BackColor = System.Drawing.Color.Transparent;
			this.linkCopyright.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.linkCopyright.Font = new System.Drawing.Font("Tahoma", 9F);
			this.linkCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
			this.linkCopyright.Location = new System.Drawing.Point(0, 447);
			this.linkCopyright.Name = "linkCopyright";
			this.linkCopyright.Size = new System.Drawing.Size(900, 41);
			this.linkCopyright.TabIndex = 2;
			this.linkCopyright.Text = "Icons made by Freepik from Flaticon are licensed by Creative Commons BY 3.0";
			this.linkCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkCopyright.Click += new System.EventHandler(this.linkCopyright_Click);
			// 
			// EmptyOverlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.linkCopyright);
			this.Controls.Add(this.pictureBox1);
			this.Name = "EmptyOverlay";
			this.Size = new System.Drawing.Size(900, 488);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label linkCopyright;
    }
}
