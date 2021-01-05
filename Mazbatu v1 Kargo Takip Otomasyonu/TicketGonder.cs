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
    public partial class TicketGonder : Form
    {
        public Uyeler uye;
        public TicketGonder()
        {
            InitializeComponent();
        }

        private void btnTicketGonder_Click(object sender, EventArgs e)
        {
            KargoIslemleri islem = new KargoIslemleri();
            islem.destekmesajgonder(txtKonu.Text,rtxtMesaj.Text,uye);
        }
    }
}
