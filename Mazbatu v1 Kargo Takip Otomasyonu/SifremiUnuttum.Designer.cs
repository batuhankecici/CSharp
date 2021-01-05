namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtMailAdresi = new System.Windows.Forms.TextBox();
            this.lblMailAdresi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lütfen Mail Adresinizi Giriniz";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.SystemColors.Control;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGonder.Location = new System.Drawing.Point(84, 199);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(84, 173);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(184, 20);
            this.txtMailAdresi.TabIndex = 5;
            this.txtMailAdresi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailAdresi_KeyDown);
            // 
            // lblMailAdresi
            // 
            this.lblMailAdresi.AutoSize = true;
            this.lblMailAdresi.BackColor = System.Drawing.Color.Transparent;
            this.lblMailAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailAdresi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMailAdresi.Location = new System.Drawing.Point(1, 176);
            this.lblMailAdresi.Name = "lblMailAdresi";
            this.lblMailAdresi.Size = new System.Drawing.Size(77, 13);
            this.lblMailAdresi.TabIndex = 4;
            this.lblMailAdresi.Text = "Mail Adresi :";
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MazBatu_v1_Kargo_Takip_Otomasyonu.Properties.Resources.SifremiUnuttum;
            this.ClientSize = new System.Drawing.Size(552, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.lblMailAdresi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremiUnuttum";
            this.Text = "Mazbatu v1 Kargo Takip Otomasyonu";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtMailAdresi;
        private System.Windows.Forms.Label lblMailAdresi;
    }
}