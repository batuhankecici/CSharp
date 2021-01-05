using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    class KargoIslemleri
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CYBER\\SQLEXPRESS;Initial Catalog=Mazbatu;Integrated Security=True");

        public Uyeler uyeGiris(string kullaniciAdi, string sifre)
        {
            baglanti.Open();
            Uyeler uye = new Uyeler();
            string sorgu = "select * from Uyeler where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@Sifre", sifre);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                uye.DogumTarihi = Convert.ToDateTime(reader[6].ToString());
                uye.Kullaniciadi = kullaniciAdi;
                uye.Sifre = sifre;
                uye.SSoyad = reader[1].ToString();
                uye.SAd = reader[0].ToString();
                uye.Mailadres = reader[5].ToString();
                uye.Tckimliknumara = reader[4].ToString();
            }
            baglanti.Close();
            return uye;
        }

        public void uyeKayit(Uyeler uye)
        {
            baglanti.Open();
            string kayitSorgu = "select * from Uyeler where TCKimlikNo=@TCKimlikNo or KullaniciAdi=@KullaniciAdi";
            SqlCommand komut = new SqlCommand(kayitSorgu, baglanti);
            komut.Parameters.AddWithValue("@TCKimlikNo", uye.Tckimliknumara);
            komut.Parameters.AddWithValue("@KullaniciAdi", uye.Kullaniciadi);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                baglanti.Close();
                reader.Close();
              MessageBox.Show("Girdiğiniz verilere ait üye bulunmakta!","Bilgilendirme Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                reader.Close();
                string sorgu = "insert into Uyeler values(@Ad,@Soyad,@KullaniciAdi,@Sifre,@TCKimlikNo,@MailAdresi,@DogumTarihi)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Ad", uye.SAd);
                komut.Parameters.AddWithValue("@Soyad", uye.SSoyad);
                komut.Parameters.AddWithValue("@KullaniciAdi", uye.Kullaniciadi);
                komut.Parameters.AddWithValue("@Sifre", uye.Sifre);
                komut.Parameters.AddWithValue("@TCKimlikNo", uye.Tckimliknumara);
                komut.Parameters.AddWithValue("@MailAdresi", uye.Mailadres);
                komut.Parameters.AddWithValue("@DogumTarihi", uye.DogumTarihi);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarılı!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void uyeSil(Uyeler uye)
        {
            baglanti.Open();
            string sorgu = "delete from Uyeler where TCKimlikNo=@TCKimlikNo";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TCKimlikNo", uye.Tckimliknumara);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı başarı ile silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void uyeGuncelle(Uyeler uye)
        {
            baglanti.Open();
            string sorgu = "update Uyeler set Ad=@Ad,Soyad=@Soyad,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,MailAdresi=@MailAdresi,DogumTarihi=@DogumTarihi Where TCKimlikNo=@TCKimlikNo";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ad",uye.SAd);
            komut.Parameters.AddWithValue("@Soyad", uye.SSoyad);
            komut.Parameters.AddWithValue("@KullaniciAdi",uye.Kullaniciadi);
            komut.Parameters.AddWithValue("@Sifre", uye.Sifre);
            komut.Parameters.AddWithValue("@MailAdresi",uye.Mailadres);
            komut.Parameters.AddWithValue("@DogumTarihi", uye.DogumTarihi);
            komut.Parameters.AddWithValue("@TCKimlikNo", uye.Tckimliknumara);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı başarı ile güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        public DataTable listele()
        {
            baglanti.Open();
            string sorgu = "select * from Uyeler";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public void sifremiUnuttum(string eMail)
        {
            baglanti.Open();
            string sorgu = "select * from Uyeler where MailAdresi=@MailAdresi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MailAdresi", eMail);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                int iYeniSifre;

                Random rastgele = new Random();
                int sayi = rastgele.Next();

                iYeniSifre = rastgele.Next(100000, 999999);
                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("MazBatuv1@gmail.com", "MazbatayiVer");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mesaj.To.Add(eMail);
                mesaj.From = new MailAddress("MazBatuv1@gmail.com");
                mesaj.Subject = "MazBatu Kargo Takip Sistemi Sifre Yenileme";
                mesaj.Body = "Yeni Sifreniz: " + iYeniSifre;
                istemci.Send(mesaj);
                reader.Close();
                sorgu = "update Uyeler set Sifre=@Sifre where MailAdresi=@MailAdresi";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Sifre", iYeniSifre);
                komut.Parameters.AddWithValue("@MailAdresi", eMail);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni şifreniz E-mail adresinize gönderilmiştir.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                reader.Close();
                baglanti.Close();
                MessageBox.Show("Girdiğiniz E-mail'e ait veri bulunmamakta!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void kargoYolla(string cikis, string varis, string tc, int fiyat)
        {
            baglanti.Open();
            string sorgu = "insert into Kargolar(KargoVarisYer,KargoCikisYer,KargoUcreti,KargoDurum,TCKimlikNo) values(@KargoVarisYer,@KargoCikisYer,@KargoUcreti,@KargoDurum,@TCKimlikNo)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KargoVarisYer", varis);
            komut.Parameters.AddWithValue("@KargoCikisYer", cikis);
            komut.Parameters.AddWithValue("@KargoUcreti", fiyat);
            komut.Parameters.AddWithValue("@KargoDurum", "Çıkış Adresinde");
            komut.Parameters.AddWithValue("@TCKimlikNo", tc);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kargo yollandı!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public DataTable guncelKargo(string tc)
        {
            baglanti.Open();
            string sorgu = "select * from Kargolar where TCKimlikNo=@tc and not KargoDurum=@KargoDurum";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@KargoDurum", "Teslim Edildi");
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public DataTable oncekiKargo(string tc)
        {
            baglanti.Open();
            string sorgu = "select * from Kargolar where TCKimlikNo=@tc and KargoDurum=@KargoDurum";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@KargoDurum", "Teslim Edildi");
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public void sifreGuncelle(string tc, string sifre)
        {
            baglanti.Open();
            string sorgu = "update Uyeler set Sifre=@Sifre where TCKimlikNo=@TCKimlikNo";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Sifre", sifre);
            komut.Parameters.AddWithValue("@TCKimlikNo", tc);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifreniz güncellendi!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public DataTable kargolariListele()
        {
            baglanti.Open();
            string sorgu = "select * from Kargolar";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public void kargoGuncelle(int kargoNo, string durum)
        {
            baglanti.Open();
            string sorgu = "update Kargolar set KargoDurum=@KargoDurum where KargoNumara=@KargoNumara";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KargoDurum", durum);
            komut.Parameters.AddWithValue("@KargoNumara", kargoNo);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void destekmesajgonder(string Konu, string Mesaj,Uyeler uye)
    {
         baglanti.Open();
         string sorgu = "insert into Ticketler(MailAdresi,Konu,Mesaj) values(@MailAdresi,@Konu,@Mesaj)";
         SqlCommand komut = new SqlCommand(sorgu,baglanti);
         komut.Parameters.AddWithValue("@MailAdresi",uye.Mailadres);
         komut.Parameters.AddWithValue("@Konu",Konu);
         komut.Parameters.AddWithValue("@Mesaj", Mesaj);
         komut.ExecuteNonQuery();
         baglanti.Close();
         MessageBox.Show("Ticketiniz Yollandı, 24 saat içerisinde mail adresinize cevap gelecektir.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }


        public DataTable destekmesajoku()
        {
            baglanti.Open();
            string sorgu = "select * from Ticketler";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public void destekmesajcevap(string Mail,string mesaj)
        {
            MailMessage message = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("MazBatuv1@gmail.com", "MazbatayiVer");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            message.To.Add(Mail);
            message.From = new MailAddress("MazBatuv1@gmail.com");
            message.Subject = "MazBatu Kargo Takip Sistemi Destek Cevabı";
            message.Body = mesaj;
            istemci.Send(message);
            MessageBox.Show("Başarılı");
        }

    }
}
