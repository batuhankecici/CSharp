namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class UyeFiyatHesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeFiyatHesaplama));
            this.btnHesapla = new System.Windows.Forms.Button();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.cmbCikis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(200, 223);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(107, 23);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Fiyat Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.cmbVaris.Location = new System.Drawing.Point(164, 175);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(173, 21);
            this.cmbVaris.TabIndex = 4;
            // 
            // cmbCikis
            // 
            this.cmbCikis.FormattingEnabled = true;
            this.cmbCikis.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.cmbCikis.Location = new System.Drawing.Point(164, 148);
            this.cmbCikis.Name = "cmbCikis";
            this.cmbCikis.Size = new System.Drawing.Size(173, 21);
            this.cmbCikis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gönderilen Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gönderilecek Şehir:";
            // 
            // UyeFiyatHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MazBatu_v1_Kargo_Takip_Otomasyonu.Properties.Resources.fiyatHesaplama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbVaris);
            this.Controls.Add(this.cmbCikis);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeFiyatHesaplama";
            this.Text = "Mazbatu v1 Kargo Takip Otomasyonu";
            this.Load += new System.EventHandler(this.UyeFiyatHesaplama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.ComboBox cmbCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}