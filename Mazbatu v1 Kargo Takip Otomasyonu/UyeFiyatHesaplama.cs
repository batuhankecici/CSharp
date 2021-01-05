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
    public partial class UyeFiyatHesaplama : Form
    {
        public UyeFiyatHesaplama()
        {
            InitializeComponent();
        }


        private void UyeFiyatHesaplama_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fiyat = (cmbCikis.SelectedIndex == cmbVaris.SelectedIndex) ? 5 : 20;
            MessageBox.Show("Fiyat: "+fiyat, "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
