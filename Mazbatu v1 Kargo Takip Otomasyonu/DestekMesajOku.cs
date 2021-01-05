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
    public partial class DestekMesajOku : Form
    {
        public DestekMesajOku()
        {
            InitializeComponent();
        }
        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DestekMesajOku_Load(object sender, EventArgs e)
        {
            KargoIslemleri islem = new KargoIslemleri();
            dgvDestekMesajlari.DataSource = islem.destekmesajoku();

        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {

            if (i != 0) i--;

            txtMailAdresi.Text = dgvDestekMesajlari.Rows[i].Cells[0].Value.ToString();
            txtKonu.Text = dgvDestekMesajlari.Rows[i].Cells[1].Value.ToString();
            rtxtMesaj.Text = dgvDestekMesajlari.Rows[i].Cells[2].Value.ToString();

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (i < dgvDestekMesajlari.Rows.Count - 1) i++;
            txtMailAdresi.Text = dgvDestekMesajlari.Rows[i].Cells[0].Value.ToString();
            txtKonu.Text = dgvDestekMesajlari.Rows[i].Cells[1].Value.ToString();
            rtxtMesaj.Text = dgvDestekMesajlari.Rows[i].Cells[2].Value.ToString();
        }
    }
}
