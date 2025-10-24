namespace SistemBilgiToplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            txtIsletimSistemi = new TextBox();
            label2 = new Label();
            txtIslemciTuru = new TextBox();
            lblIslemciTuru = new Label();
            txtDepolamaAlani = new TextBox();
            lblDepolamaAlani = new Label();
            txtOfficeSurum = new TextBox();
            lblOfficeSurum = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciAdi.Location = new Point(7, 26);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(127, 25);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(186, 26);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(253, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtIsletimSistemi
            // 
            txtIsletimSistemi.Location = new Point(186, 72);
            txtIsletimSistemi.Name = "txtIsletimSistemi";
            txtIsletimSistemi.Size = new Size(253, 23);
            txtIsletimSistemi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(7, 67);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 2;
            label2.Text = "İşletim Sistemi:";
            // 
            // txtIslemciTuru
            // 
            txtIslemciTuru.Location = new Point(186, 116);
            txtIslemciTuru.Name = "txtIslemciTuru";
            txtIslemciTuru.Size = new Size(253, 23);
            txtIslemciTuru.TabIndex = 5;
            // 
            // lblIslemciTuru
            // 
            lblIslemciTuru.AutoSize = true;
            lblIslemciTuru.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIslemciTuru.Location = new Point(7, 111);
            lblIslemciTuru.Name = "lblIslemciTuru";
            lblIslemciTuru.Size = new Size(124, 25);
            lblIslemciTuru.TabIndex = 4;
            lblIslemciTuru.Text = "İşlemci Türü:";
            // 
            // txtDepolamaAlani
            // 
            txtDepolamaAlani.Location = new Point(186, 164);
            txtDepolamaAlani.Name = "txtDepolamaAlani";
            txtDepolamaAlani.Size = new Size(253, 23);
            txtDepolamaAlani.TabIndex = 7;
            // 
            // lblDepolamaAlani
            // 
            lblDepolamaAlani.AutoSize = true;
            lblDepolamaAlani.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDepolamaAlani.Location = new Point(7, 159);
            lblDepolamaAlani.Name = "lblDepolamaAlani";
            lblDepolamaAlani.Size = new Size(157, 25);
            lblDepolamaAlani.TabIndex = 6;
            lblDepolamaAlani.Text = "Depolama Alanı:";
            // 
            // txtOfficeSurum
            // 
            txtOfficeSurum.Location = new Point(186, 213);
            txtOfficeSurum.Name = "txtOfficeSurum";
            txtOfficeSurum.Size = new Size(253, 23);
            txtOfficeSurum.TabIndex = 9;
            // 
            // lblOfficeSurum
            // 
            lblOfficeSurum.AutoSize = true;
            lblOfficeSurum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOfficeSurum.Location = new Point(7, 208);
            lblOfficeSurum.Name = "lblOfficeSurum";
            lblOfficeSurum.Size = new Size(146, 25);
            lblOfficeSurum.TabIndex = 8;
            lblOfficeSurum.Text = "Office Sürümü:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(146, 293);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(158, 23);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 328);
            Controls.Add(btnKaydet);
            Controls.Add(txtOfficeSurum);
            Controls.Add(lblOfficeSurum);
            Controls.Add(txtDepolamaAlani);
            Controls.Add(lblDepolamaAlani);
            Controls.Add(txtIslemciTuru);
            Controls.Add(lblIslemciTuru);
            Controls.Add(txtIsletimSistemi);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sistem Bİlgi Toplama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private TextBox txtIsletimSistemi;
        private Label label2;
        private TextBox txtIslemciTuru;
        private Label lblIslemciTuru;
        private TextBox txtDepolamaAlani;
        private Label lblDepolamaAlani;
        private TextBox txtOfficeSurum;
        private Label lblOfficeSurum;
        private Button btnKaydet;
    }
}
