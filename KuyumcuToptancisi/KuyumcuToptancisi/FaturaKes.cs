using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class FaturaKes : Form
    {

        public FaturaKes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        Hesaplamalar hesaplamalar = new Hesaplamalar();
        Veritabanı veritabanı = new Veritabanı();
        sonFaturalar sonfaturalar = new sonFaturalar();

        private void FaturaKes_Load(object sender, EventArgs e)
        {
            veritabanı.musteriListesi(this);

        }

        private void fisiKes_Click(object sender, EventArgs e)
        {
            if (tarih.ValidateText() == null) { MessageBox.Show("Tarih girilmeden fiş kesilemez! Lütfen tarihi giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {

                try
                {
                    veritabanı.FaturaEkle(this,hesaplamalar);

                    MessageBox.Show("Fiş başarıyla kesildi. Hayırlı olsun.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Fiş kesilemedi. Lütfen tekrar deneyiniz. " + ex);
                }

            }


        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            hesaplamalar.hesaplamaYap(this);
            hesaplamalar.yazdir(this);
        }

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            KuyumcuEkle ekle = new KuyumcuEkle();
            ekle.Show();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            Secenekler geriDon = new Secenekler();
            Program.geriDon(geriDon);
            this.Hide();
        }
    }
}

