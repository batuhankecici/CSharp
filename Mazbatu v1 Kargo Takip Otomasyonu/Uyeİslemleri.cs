using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    public partial class Uyeİslemleri : Form
    {
        public Uyeİslemleri()
        {
            InitializeComponent();
        }
        KargoIslemleri kargo = new KargoIslemleri();
        private void Uyeİslemleri_Load(object sender, EventArgs e)
        {
            dgvUyeler.DataSource = kargo.listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uyeler uye = new Uyeler();
            uye.Tckimliknumara = txtKimlikNumarasi.Text;
            kargo.uyeSil(uye);
            dgvUyeler.DataSource = kargo.listele();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                Uyeler uye = new Uyeler();
                uye.Sifre = txtSifre.Text;
                uye.SAd = txtAd.Text;
                uye.Mailadres = txtMailAdresi.Text;
                uye.Kullaniciadi = txtKullaniciAdi.Text;
                uye.SSoyad = txtSoyad.Text;
                uye.Tckimliknumara = txtKimlikNumarasi.Text;
                uye.DogumTarihi = dtpDogumTarihi.Value;
                kargo.uyeKayit(uye);
                dgvUyeler.DataSource = kargo.listele();
            }
            else
            {
                MessageBox.Show("Şifreniz eşleşmedi lütfen her iki alanada aynı şifreyi girin", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Uyeler uye = new Uyeler();
            uye.Sifre = txtSifre.Text;
            uye.SAd = txtAd.Text;
            uye.Mailadres = txtMailAdresi.Text;
            uye.Kullaniciadi = txtKullaniciAdi.Text;
            uye.SSoyad = txtSoyad.Text;
            uye.Tckimliknumara = txtKimlikNumarasi.Text;
            uye.DogumTarihi = dtpDogumTarihi.Value;
            kargo.uyeGuncelle(uye);
            dgvUyeler.DataSource = kargo.listele();
        }

        private void dgvUyeler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            txtAd.Text = dgvUyeler.CurrentRow.Cells[0].Value.ToString();
            txtSoyad.Text = dgvUyeler.CurrentRow.Cells[1].Value.ToString();
            txtKullaniciAdi.Text = dgvUyeler.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dgvUyeler.CurrentRow.Cells[3].Value.ToString();
            txtKimlikNumarasi.Text = dgvUyeler.CurrentRow.Cells[4].Value.ToString();
            txtMailAdresi.Text = dgvUyeler.CurrentRow.Cells[5].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dgvUyeler.CurrentRow.Cells[6].Value); 


        }
    }
}
