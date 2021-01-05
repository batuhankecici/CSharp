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
    public partial class UyeEkran : Form
    {
        public UyeEkran()
        {
            InitializeComponent();
        }
        public Uyeler uye;
        private void bilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UyeEkran_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text += " " + uye.SAd + " " + uye.SSoyad;
        }

        private void kargoYollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KargoYolla frm = new KargoYolla();
            frm.uye = uye;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void güncelKargolarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeGuncelKargo frm = new UyeGuncelKargo();
            frm.uye = uye;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void öncekiKargolarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeOncekiKargo frm = new UyeOncekiKargo();
            frm.uye = uye;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void teslimatSüreleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeTeslimatSuresi frm = new UyeTeslimatSuresi();
            frm.uye = uye;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void fiyatHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeFiyatHesaplama frm = new UyeFiyatHesaplama();
          
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void bilgilerimiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeSifremiGuncelle frm = new UyeSifremiGuncelle();
            frm.uye = uye;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ticketYollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketGonder frm = new TicketGonder();
            frm.uye = uye;
            frm.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisMenu GirisMenu = new GirisMenu();
            GirisMenu.Show();
            this.Close();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
