namespace FusionPlusPlus
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetailForm));
			this.memoItems = new DevExpress.XtraEditors.MemoEdit();
			((System.ComponentModel.ISupportInitialize)(this.memoItems.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// memoItems
			// 
			this.memoItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.memoItems.Location = new System.Drawing.Point(0, 0);
			this.memoItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.memoItems.Name = "memoItems";
			this.memoItems.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.memoItems.Properties.Appearance.Options.UseFont = true;
			this.memoItems.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.memoItems.Size = new System.Drawing.Size(933, 554);
			this.memoItems.TabIndex = 0;
			// 
			// ItemDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 554);
			this.Controls.Add(this.memoItems);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ItemDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Detail";
			((System.ComponentModel.ISupportInitialize)(this.memoItems.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.MemoEdit memoItems;
	}
}