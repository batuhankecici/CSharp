namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class KargoYolla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KargoYolla));
            this.cmbCikis = new System.Windows.Forms.ComboBox();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.btnYolla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCikis
            // 
            this.cmbCikis.FormattingEnabled = true;
            this.cmbCikis.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.cmbCikis.Location = new System.Drawing.Point(115, 74);
            this.cmbCikis.Name = "cmbCikis";
            this.cmbCikis.Size = new System.Drawing.Size(160, 21);
            this.cmbCikis.TabIndex = 0;
            this.cmbCikis.SelectedIndexChanged += new System.EventHandler(this.cmbCikis_SelectedIndexChanged);
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.cmbVaris.Location = new System.Drawing.Point(115, 110);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(160, 21);
            this.cmbVaris.TabIndex = 1;
            // 
            // btnYolla
            // 
            this.btnYolla.Location = new System.Drawing.Point(153, 158);
            this.btnYolla.Name = "btnYolla";
            this.btnYolla.Size = new System.Drawing.Size(75, 23);
            this.btnYolla.TabIndex = 2;
            this.btnYolla.Text = "Yolla";
            this.btnYolla.UseVisualStyleBackColor = true;
            this.btnYolla.Click += new System.EventHandler(this.btnYolla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gönderilen Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gönderilecek Şehir:";
            // 
            // KargoYolla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MazBatu_v1_Kargo_Takip_Otomasyonu.Properties.Resources.kargoYolla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYolla);
            this.Controls.Add(this.cmbVaris);
            this.Controls.Add(this.cmbCikis);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KargoYolla";
            this.Text = "MazBatu v1 Kargo Takip Otomasyonu";
            this.Load += new System.EventHandler(this.KargoYolla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCikis;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.Button btnYolla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}