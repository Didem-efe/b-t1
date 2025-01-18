namespace OkulOtomasyon
{
    partial class FrmNufusCuzdani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNufusCuzdani));
            this.lbltc = new DevExpress.XtraEditors.LabelControl();
            this.lblsoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblad = new DevExpress.XtraEditors.LabelControl();
            this.lbldogtar = new DevExpress.XtraEditors.LabelControl();
            this.lblcinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltc
            // 
            this.lbltc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Appearance.Options.UseFont = true;
            this.lbltc.Location = new System.Drawing.Point(51, 109);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(85, 16);
            this.lbltc.TabIndex = 0;
            this.lbltc.Text = "labelControl1";
            // 
            // lblsoyad
            // 
            this.lblsoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Appearance.Options.UseFont = true;
            this.lblsoyad.Location = new System.Drawing.Point(225, 109);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(85, 16);
            this.lblsoyad.TabIndex = 1;
            this.lblsoyad.Text = "labelControl2";
            // 
            // lblad
            // 
            this.lblad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Appearance.Options.UseFont = true;
            this.lblad.Location = new System.Drawing.Point(225, 160);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(85, 16);
            this.lblad.TabIndex = 2;
            this.lblad.Text = "labelControl3";
            // 
            // lbldogtar
            // 
            this.lbldogtar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogtar.Appearance.Options.UseFont = true;
            this.lbldogtar.Location = new System.Drawing.Point(225, 211);
            this.lbldogtar.Name = "lbldogtar";
            this.lbldogtar.Size = new System.Drawing.Size(85, 16);
            this.lbldogtar.TabIndex = 3;
            this.lbldogtar.Text = "labelControl4";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.Appearance.BackColor = System.Drawing.Color.White;
            this.lblcinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Appearance.Options.UseBackColor = true;
            this.lblcinsiyet.Appearance.Options.UseFont = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(356, 211);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(85, 16);
            this.lblcinsiyet.TabIndex = 4;
            this.lblcinsiyet.Text = "labelControl5";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(73, 148);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(124, 149);
            this.pictureEdit1.TabIndex = 5;
            // 
            // FrmNufusCuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 350);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lbldogtar);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lbltc);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNufusCuzdani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNufusCuzdani";
            this.Load += new System.EventHandler(this.FrmNufusCuzdani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbltc;
        private DevExpress.XtraEditors.LabelControl lblsoyad;
        private DevExpress.XtraEditors.LabelControl lblad;
        private DevExpress.XtraEditors.LabelControl lbldogtar;
        private DevExpress.XtraEditors.LabelControl lblcinsiyet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}