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
    public partial class UyeOncekiKargo : Form
    {
        public UyeOncekiKargo()
        {
            InitializeComponent();
        }

        public Uyeler uye;

        private void UyeOncekiKargo_Load(object sender, EventArgs e)
        {
            KargoIslemleri islem = new KargoIslemleri();
            dataGridView1.DataSource = islem.oncekiKargo(uye.Tckimliknumara);
            dataGridView1.Columns[6].Visible = false;
        }
    }
}
