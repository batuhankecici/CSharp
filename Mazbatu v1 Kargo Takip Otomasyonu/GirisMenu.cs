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
using System.IO;

namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    public partial class GirisMenu : Form
    {
        public GirisMenu()
        {
            InitializeComponent();
        }
       
        
        private void Form2_Load(object sender, EventArgs e)
        {
            beniHatirlaOku();
        }

        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum SifremiUnuttum = new SifremiUnuttum();
            SifremiUnuttum.ShowDialog();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl KayitOl = new KayitOl();
            KayitOl.ShowDialog();
        }
        void beniHatirlaYaz()
        {
            StreamWriter sw = new StreamWriter("hatirla.txt", false);
            if (cbBeniHatirla.Checked)
            {   
                sw.WriteLine(txtKullaniciAdi.Text);
                sw.WriteLine(txtSifre.Text);
            }
            sw.Close();
        }
        void beniHatirlaOku()
        {
            StreamReader sr = new StreamReader("hatirla.txt");
            while (!sr.EndOfStream)
            {
                txtKullaniciAdi.Text = sr.ReadLine();
                txtSifre.Text = sr.ReadLine();
                cbBeniHatirla.Checked = true;
            }
            sr.Close();
        }
        private void btnUyeGiris_Click(object sender, EventArgs e)
        {
            KargoIslemleri islem = new KargoIslemleri();
            Uyeler uye = islem.uyeGiris(txtKullaniciAdi.Text, txtSifre.Text);
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "admin")
            {
                beniHatirlaYaz();
                AdminEkran adminekran = new AdminEkran();
                adminekran.Show();
                this.Close();
            }
            else if (uye.SAd != null)
            {
                beniHatirlaYaz();
                MessageBox.Show("Giriş İşlemi Başarıyla Gerçekleşti", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UyeEkran uyeekran = new UyeEkran();
                uyeekran.uye = uye;
                uyeekran.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanici Adiniz ve Şifreniz Eşleşmedi!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }


       private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       private void txtSifre_TextChanged(object sender, EventArgs e)
       {

       }

       private void txtSifre_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               btnUyeGiris.PerformClick();
           }
       }

       private void cbBeniHatirla_CheckedChanged(object sender, EventArgs e)
       {

       }
    }
}
