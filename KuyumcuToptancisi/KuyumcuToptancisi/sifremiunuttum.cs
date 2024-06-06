using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        string YenilemeMaili = "denemelikhesap03@hotmail.com"; //yeni şifreyi gönderecek mailin adresi
        string YenilemeSifresi = "Denemelik003"; // yeni şifreyi gönderecek mail hesabının şifresi
        string yeniSifre;

        Veritabanı veritabanıAdmin = new Veritabanı();

        private void sifreYenileBTN_Click(object sender, EventArgs e)
        {
            veritabanıAdmin.baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From adminBilgileri where kullanici_adi = '" + dogrulamaTxtBox.Text + "' And email_adres ='" + emailAdress.Text + "' ", veritabanıAdmin.baglanti);

            SqlDataReader veriOkuma = komut.ExecuteReader();

            string girilenKod = dogrulamaTxtBox.Text;
            string dogrulamaKodu = dogrulamaKod.Text;

            if (girilenKod.Equals(dogrulamaKodu))
            {
                if (veriOkuma.Read())
                {
                    //rastgele yeni şifre oluşturma
                    Random rand = new Random();
                    yeniSifre = rand.Next(10000, 100000).ToString();

                    veriOkuma.Close();

                    //oluşturulan kodu yeni şifre olarak atama
                    komut = new SqlCommand("UPDATE adminBilgileri SET sifre = @YeniSifre WHERE kullanici_adi = @K_Adi", veritabanıAdmin.baglanti);
                    komut.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                    komut.Parameters.AddWithValue("@K_Adi", kullaniciAdi.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Şifre Yenileme İşleminiz Başarılı . E-Postanızı kontrol ediniz.");
                }

                else
                {
                    MessageBox.Show("Bilgilerin Yanlış");
                }

                //mail gönderme işlemi
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.outlook.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(YenilemeMaili, YenilemeSifresi);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(YenilemeMaili, "Şifre Sıfırlama");
                mail.To.Add(emailAdress.Text); //kodun gönderildiği mail adresi
                mail.Subject = "Şifre Sıfırlama İsteği";
                mail.IsBodyHtml = true;
                mail.Body = $" Sistemimiz tarafından oluşturulan yeni şifreniz : {yeniSifre} ";

                sc.Send(mail);
            }

            else
            {

                MessageBox.Show("Girilen kod yanlış.Lütfen tekrar deneyiniz");
                sifreYenileBTN.Visible = true;
                dogrulamaKod.Visible = false;
            }

        }


        private void dogrulamaKodu_Click(object sender, EventArgs e)
        {
            //rastgele 4 haneli kod oluşturma
            Random random = new Random();
            int kod = random.Next(0000, 9999);


            dogrulamaKodu.Visible = false; //butonu gizleme

            dogrulamaKod.Text = kod.ToString("D4");
            dogrulamaKod.Visible = true; //kodun yazılı oldığu katmanı görünür hale getirme
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            girisEkrani girisEkrani = new girisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
