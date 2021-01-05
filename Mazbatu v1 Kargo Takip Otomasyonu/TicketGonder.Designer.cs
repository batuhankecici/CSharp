namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class TicketGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketGonder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTicketGonder = new System.Windows.Forms.Button();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.rtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesaj:";
            // 
            // btnTicketGonder
            // 
            this.btnTicketGonder.Location = new System.Drawing.Point(109, 239);
            this.btnTicketGonder.Name = "btnTicketGonder";
            this.btnTicketGonder.Size = new System.Drawing.Size(75, 23);
            this.btnTicketGonder.TabIndex = 2;
            this.btnTicketGonder.Text = "Gönder";
            this.btnTicketGonder.UseVisualStyleBackColor = true;
            this.btnTicketGonder.Click += new System.EventHandler(this.btnTicketGonder_Click);
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(109, 69);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(161, 20);
            this.txtKonu.TabIndex = 3;
            // 
            // rtxtMesaj
            // 
            this.rtxtMesaj.Location = new System.Drawing.Point(109, 119);
            this.rtxtMesaj.Name = "rtxtMesaj";
            this.rtxtMesaj.Size = new System.Drawing.Size(161, 96);
            this.rtxtMesaj.TabIndex = 4;
            this.rtxtMesaj.Text = "";
            // 
            // TicketGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 310);
            this.Controls.Add(this.rtxtMesaj);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.btnTicketGonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketGonder";
            this.Text = "Mazbatu v1 Kargo Takip Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTicketGonder;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.RichTextBox rtxtMesaj;
    }
}