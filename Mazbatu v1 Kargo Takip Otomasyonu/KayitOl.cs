using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

  

namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtMailAdresi.Text.Contains("@") && txtMailAdresi.Text.Contains(".com"))
            {
                if (txtKayitSifre.Text == txtKayitSifreTekrar.Text)
                {
                    Uyeler uye = new Uyeler();
                    uye.Sifre = txtKayitSifre.Text;
                    uye.SAd = txtAd.Text;
                    uye.Mailadres = txtMailAdresi.Text;
                    uye.Kullaniciadi = txtKayitKullaniciAdi.Text;
                    uye.SSoyad = txtSoyad.Text;
                    uye.Tckimliknumara = txtKimlikNumarasi.Text;
                    uye.DogumTarihi = dtpDogumTarihi.Value;
                    KargoIslemleri islem = new KargoIslemleri();
                    islem.uyeKayit(uye);
                }
                else
                {
                    MessageBox.Show("Şifreniz eşleşmedi lütfen her iki alanada aynı şifreyi girin", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            { 
             MessageBox.Show("Mail Adresinizi lütfen doğru giriniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               

           
        }
    }
}
