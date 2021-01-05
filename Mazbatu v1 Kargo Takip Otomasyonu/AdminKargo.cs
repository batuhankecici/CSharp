using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    public partial class AdminKargo : Form
    {
        public AdminKargo()
        {
            InitializeComponent();
        }
        KargoIslemleri islem = new KargoIslemleri();
        void veriGuncelle()
        {
            dgvKargolar.DataSource = islem.kargolariListele();
        }

        private void dgvKargolar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int kargoNo = int.Parse(dgvKargolar.SelectedRows[0].Cells[0].Value.ToString());
            string durum = dgvKargolar.SelectedRows[0].Cells[4].Value.ToString();
            durum = durum.TrimEnd();
            if (durum != "Teslim Edildi")
            {
                if (MessageBox.Show("Durum güncellensin mi?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (durum == "Çıkış Adresinde") durum = "Varış Adresinde";
                    else if (durum == "Varış Adresinde") durum = "Teslim Edildi";
                    islem.kargoGuncelle(kargoNo, durum);
                    veriGuncelle();
                }
            }
        }

        private void AdminKargo_Load(object sender, EventArgs e)
        {
            veriGuncelle();
        }
    }
}
