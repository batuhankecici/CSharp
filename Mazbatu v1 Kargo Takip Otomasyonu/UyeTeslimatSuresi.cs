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
    public partial class UyeTeslimatSuresi : Form
    {
        public UyeTeslimatSuresi()
        {
            InitializeComponent();
        }
        public Uyeler uye;
        private void UyeTeslimatSuresi_Load(object sender, EventArgs e)
        {
            KargoIslemleri islem = new KargoIslemleri();
            dataGridView1.DataSource = islem.guncelKargo(uye.Tckimliknumara);
            dataGridView1.Columns[6].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string varis = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string cikis = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string mesaj = (varis == cikis) ? "Tahmini teslimat süresi 1 gün" : "Tahmini teslimat süresi 3 gün";
            MessageBox.Show(mesaj, "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
