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
    public partial class KargoYolla : Form
    {
        public KargoYolla()
        {
            InitializeComponent();
        }

        public Uyeler uye;

        private void btnYolla_Click(object sender, EventArgs e)
        {
            int fiyat = (cmbCikis.SelectedIndex == cmbVaris.SelectedIndex) ? 5 : 20;
            KargoIslemleri islem = new KargoIslemleri();
            islem.kargoYolla(cmbCikis.SelectedItem.ToString(), cmbVaris.SelectedItem.ToString(), uye.Tckimliknumara, fiyat);

        }

        private void cmbCikis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KargoYolla_Load(object sender, EventArgs e)
        {

        }
    }
}
