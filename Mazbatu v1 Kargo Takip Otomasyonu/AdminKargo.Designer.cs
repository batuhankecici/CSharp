namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    partial class AdminKargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminKargo));
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKargolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKargolar.Location = new System.Drawing.Point(12, 221);
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKargolar.Size = new System.Drawing.Size(767, 296);
            this.dgvKargolar.TabIndex = 0;
            this.dgvKargolar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKargolar_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tüm Kargolar";
            // 
            // AdminKargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MazBatu_v1_Kargo_Takip_Otomasyonu.Properties.Resources.adminKargolar;
            this.ClientSize = new System.Drawing.Size(791, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKargolar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminKargo";
            this.Text = "Mazbatu v1 Kargo Takip Otomasyonu";
            this.Load += new System.EventHandler(this.AdminKargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKargolar;
        private System.Windows.Forms.Label label1;
    }
}