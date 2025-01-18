namespace OkulOtomasyon
{
    partial class FrmVeliler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeliler));
            this.msktelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.msktelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.txtbabaad = new DevExpress.XtraEditors.TextEdit();
            this.txtannead = new DevExpress.XtraEditors.TextEdit();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkayitet = new DevExpress.XtraEditors.SimpleButton();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtbabaad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtannead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // msktelefon2
            // 
            this.msktelefon2.Location = new System.Drawing.Point(85, 116);
            this.msktelefon2.Mask = "(999) 000-0000";
            this.msktelefon2.Name = "msktelefon2";
            this.msktelefon2.Size = new System.Drawing.Size(227, 21);
            this.msktelefon2.TabIndex = 12;
            // 
            // msktelefon1
            // 
            this.msktelefon1.Location = new System.Drawing.Point(85, 92);
            this.msktelefon1.Mask = "(999) 000-0000";
            this.msktelefon1.Name = "msktelefon1";
            this.msktelefon1.Size = new System.Drawing.Size(227, 21);
            this.msktelefon1.TabIndex = 11;
            // 
            // txtbabaad
            // 
            this.txtbabaad.Location = new System.Drawing.Point(85, 65);
            this.txtbabaad.Name = "txtbabaad";
            this.txtbabaad.Size = new System.Drawing.Size(227, 20);
            this.txtbabaad.TabIndex = 10;
            // 
            // txtannead
            // 
            this.txtannead.Location = new System.Drawing.Point(85, 41);
            this.txtannead.Name = "txtannead";
            this.txtannead.Size = new System.Drawing.Size(227, 20);
            this.txtannead.TabIndex = 9;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(85, 17);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(227, 20);
            this.txtid.TabIndex = 8;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(829, 15);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(338, 618);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(336, 574);
            this.xtraTabPage1.Text = "Veli Bilgileri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkayitet);
            this.groupControl1.Controls.Add(this.txtmail);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.msktelefon2);
            this.groupControl1.Controls.Add(this.msktelefon1);
            this.groupControl1.Controls.Add(this.txtbabaad);
            this.groupControl1.Controls.Add(this.txtannead);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(329, 567);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btntemizle
            // 
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(85, 284);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(189, 26);
            this.btntemizle.TabIndex = 21;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(85, 252);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(189, 26);
            this.btnguncelle.TabIndex = 20;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(85, 220);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(189, 26);
            this.btnsil.TabIndex = 19;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkayitet
            // 
            this.btnkayitet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkayitet.ImageOptions.Image")));
            this.btnkayitet.Location = new System.Drawing.Point(85, 188);
            this.btnkayitet.Name = "btnkayitet";
            this.btnkayitet.Size = new System.Drawing.Size(189, 26);
            this.btnkayitet.TabIndex = 18;
            this.btnkayitet.Text = "Kaydet";
            this.btnkayitet.Click += new System.EventHandler(this.btnkayitet_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(85, 143);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(227, 20);
            this.txtmail.TabIndex = 14;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(35, 142);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 18);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "MAİL :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TELEFON2 :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "TELEFON1 :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "BABA AD :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ANNE AD :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 14);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(810, 619);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmVeliler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 646);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmVeliler";
            this.Text = "FrmVeliler";
            this.Load += new System.EventHandler(this.FrmVeliler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtbabaad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtannead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox msktelefon2;
        private System.Windows.Forms.MaskedTextBox msktelefon1;
        private DevExpress.XtraEditors.TextEdit txtbabaad;
        private DevExpress.XtraEditors.TextEdit txtannead;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkayitet;
    }
}