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
    public partial class UyeSifremiGuncelle : Form
    {
        public UyeSifremiGuncelle()
        {
            InitializeComponent();
        }
        public Uyeler uye;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYSifre.Text == txtYSifreTekrar.Text)
            {
                KargoIslemleri islem = new KargoIslemleri();
                islem.sifreGuncelle(uye.Tckimliknumara, txtYSifre.Text);
            }
            else MessageBox.Show("Şifreler aynı değil!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
