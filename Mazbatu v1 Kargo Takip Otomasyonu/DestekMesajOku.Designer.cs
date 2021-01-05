namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class DestekMesajOku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestekMesajOku));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.dgvDestekMesajlari = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailAdresi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestekMesajlari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesaj:";
            // 
            // rtxtMesaj
            // 
            this.rtxtMesaj.Location = new System.Drawing.Point(142, 278);
            this.rtxtMesaj.Name = "rtxtMesaj";
            this.rtxtMesaj.Size = new System.Drawing.Size(178, 96);
            this.rtxtMesaj.TabIndex = 2;
            this.rtxtMesaj.Text = "";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(142, 241);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(178, 20);
            this.txtKonu.TabIndex = 3;
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(347, 278);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(75, 23);
            this.btnOnceki.TabIndex = 5;
            this.btnOnceki.Text = "Önceki";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(347, 328);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(75, 23);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // dgvDestekMesajlari
            // 
            this.dgvDestekMesajlari.AllowUserToAddRows = false;
            this.dgvDestekMesajlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestekMesajlari.Location = new System.Drawing.Point(28, 47);
            this.dgvDestekMesajlari.Name = "dgvDestekMesajlari";
            this.dgvDestekMesajlari.Size = new System.Drawing.Size(475, 150);
            this.dgvDestekMesajlari.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail Adresi:";
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(142, 210);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(178, 20);
            this.txtMailAdresi.TabIndex = 9;
            // 
            // DestekMesajOku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 396);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDestekMesajlari);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.rtxtMesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DestekMesajOku";
            this.Text = "Mazbatu v1 Kargo Takip Otomasyonu";
            this.Load += new System.EventHandler(this.DestekMesajOku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestekMesajlari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtMesaj;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.DataGridView dgvDestekMesajlari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMailAdresi;
    }
}