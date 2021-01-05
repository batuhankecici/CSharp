namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class GirisMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisMenu));
            this.btnKayitaGit = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUyeGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifremiUnuttum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbBeniHatirla = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKayitaGit
            // 
            this.btnKayitaGit.BackColor = System.Drawing.SystemColors.Control;
            this.btnKayitaGit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKayitaGit.Location = new System.Drawing.Point(480, 294);
            this.btnKayitaGit.Name = "btnKayitaGit";
            this.btnKayitaGit.Size = new System.Drawing.Size(59, 36);
            this.btnKayitaGit.TabIndex = 14;
            this.btnKayitaGit.Text = "Kayit Ol";
            this.btnKayitaGit.UseVisualStyleBackColor = false;
            this.btnKayitaGit.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(441, 190);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(136, 20);
            this.txtKullaniciAdi.TabIndex = 10;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(441, 226);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(136, 20);
            this.txtSifre.TabIndex = 11;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(351, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanici Adi:";
            // 
            // btnUyeGiris
            // 
            this.btnUyeGiris.BackColor = System.Drawing.SystemColors.Control;
            this.btnUyeGiris.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUyeGiris.Location = new System.Drawing.Point(388, 294);
            this.btnUyeGiris.Name = "btnUyeGiris";
            this.btnUyeGiris.Size = new System.Drawing.Size(55, 36);
            this.btnUyeGiris.TabIndex = 13;
            this.btnUyeGiris.Text = "Giriş";
            this.btnUyeGiris.UseVisualStyleBackColor = false;
            this.btnUyeGiris.Click += new System.EventHandler(this.btnUyeGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(385, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sifre:";
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.AutoSize = true;
            this.lblSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.lblSifremiUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSifremiUnuttum.ForeColor = System.Drawing.Color.Aqua;
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(444, 275);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(115, 13);
            this.lblSifremiUnuttum.TabIndex = 12;
            this.lblSifremiUnuttum.Text = "Şifrenizi mi unuttunuz? ";
            this.lblSifremiUnuttum.Click += new System.EventHandler(this.lblSifremiUnuttum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cbBeniHatirla
            // 
            this.cbBeniHatirla.AutoSize = true;
            this.cbBeniHatirla.BackColor = System.Drawing.Color.Transparent;
            this.cbBeniHatirla.ForeColor = System.Drawing.Color.White;
            this.cbBeniHatirla.Location = new System.Drawing.Point(497, 252);
            this.cbBeniHatirla.Name = "cbBeniHatirla";
            this.cbBeniHatirla.Size = new System.Drawing.Size(80, 17);
            this.cbBeniHatirla.TabIndex = 16;
            this.cbBeniHatirla.Text = "Beni Hatırla";
            this.cbBeniHatirla.UseVisualStyleBackColor = false;
            this.cbBeniHatirla.CheckedChanged += new System.EventHandler(this.cbBeniHatirla_CheckedChanged);
            // 
            // GirisMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::MazBatu_v1_Kargo_Takip_Otomasyonu.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.cbBeniHatirla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSifremiUnuttum);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnUyeGiris);
            this.Controls.Add(this.btnKayitaGit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisMenu";
            this.Text = "MazBatu v1.0 Kargo Takip Otomasyonu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitaGit;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUyeGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbBeniHatirla;
    }
}