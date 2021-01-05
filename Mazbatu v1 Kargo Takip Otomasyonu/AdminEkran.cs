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
    public partial class AdminEkran : Form
    {
        public AdminEkran()
        {
            InitializeComponent();
        }

        private void kargoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wqdqdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uyeİslemleri Uyeİslemleri = new Uyeİslemleri();
            Uyeİslemleri.ShowDialog();
        }

        private void kargolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKargo frm = new AdminKargo();
            frm.ShowDialog();
        }

        private void mesajOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestekMesajOku form = new DestekMesajOku();
            form.ShowDialog();
        }

        private void mesajCevaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestekMesajCevapla form = new DestekMesajCevapla();
            form.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisMenu GirisMenu = new GirisMenu();
            GirisMenu.Show();
            this.Close();
        }
    }
}
