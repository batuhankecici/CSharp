using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }


               
        private void btnGonder_Click(object sender, EventArgs e)
        {
            KargoIslemleri islem = new KargoIslemleri();
            islem.sifremiUnuttum(txtMailAdresi.Text);
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
        
        }

        private void txtMailAdresi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMailAdresi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGonder.PerformClick();
            }
        } 
    }
}
