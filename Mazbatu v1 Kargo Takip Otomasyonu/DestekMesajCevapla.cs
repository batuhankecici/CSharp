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
    public partial class DestekMesajCevapla : Form
    {
        public DestekMesajCevapla()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
        
        }

        private void btnGonder_Click_1(object sender, EventArgs e)
        {
            KargoIslemleri islem = new KargoIslemleri();
            islem.destekmesajcevap(txtMailAdresi.Text, rtxtMesaj.Text);
        }
    }
}
