namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class AdminEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkran));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wqdqdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kargolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajOkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajCevaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wqdqdToolStripMenuItem,
            this.kargolarToolStripMenuItem,
            this.destekToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wqdqdToolStripMenuItem
            // 
            this.wqdqdToolStripMenuItem.Name = "wqdqdToolStripMenuItem";
            this.wqdqdToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.wqdqdToolStripMenuItem.Text = "Üye İşlemleri";
            this.wqdqdToolStripMenuItem.Click += new System.EventHandler(this.wqdqdToolStripMenuItem_Click);
            // 
            // kargolarToolStripMenuItem
            // 
            this.kargolarToolStripMenuItem.Name = "kargolarToolStripMenuItem";
            this.kargolarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.kargolarToolStripMenuItem.Text = "Kargolar";
            this.kargolarToolStripMenuItem.Click += new System.EventHandler(this.kargolarToolStripMenuItem_Click);
            // 
            // destekToolStripMenuItem
            // 
            this.destekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesajOkuToolStripMenuItem,
            this.mesajCevaplaToolStripMenuItem});
            this.destekToolStripMenuItem.Name = "destekToolStripMenuItem";
            this.destekToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.destekToolStripMenuItem.Text = "Destek";
            // 
            // mesajOkuToolStripMenuItem
            // 
            this.mesajOkuToolStripMenuItem.Name = "mesajOkuToolStripMenuItem";
            this.mesajOkuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mesajOkuToolStripMenuItem.Text = "Mesaj Oku";
            this.mesajOkuToolStripMenuItem.Click += new System.EventHandler(this.mesajOkuToolStripMenuItem_Click);
            // 
            // mesajCevaplaToolStripMenuItem
            // 
            this.mesajCevaplaToolStripMenuItem.Name = "mesajCevaplaToolStripMenuItem";
            this.mesajCevaplaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mesajCevaplaToolStripMenuItem.Text = "Mesaj Cevapla";
            this.mesajCevaplaToolStripMenuItem.Click += new System.EventHandler(this.mesajCevaplaToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // AdminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 386);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminEkran";
            this.Text = "Mazbatu v1 Kargo Takip Otomasyonu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wqdqdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kargolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajOkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajCevaplaToolStripMenuItem;
    }
}