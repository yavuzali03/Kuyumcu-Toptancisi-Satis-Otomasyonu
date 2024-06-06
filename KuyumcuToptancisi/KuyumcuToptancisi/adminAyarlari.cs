using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class adminAyarlari : Form
    {
        public adminAyarlari()
        {
            InitializeComponent();
        }

        Veritabanı veritabanı = new Veritabanı();
        private void adminAyarlari_Load(object sender, EventArgs e)
        {

            veritabanı.adminListele(this);
            adminler.Columns[0].Visible = false;

        }


        private void adminEkle_Click(object sender, EventArgs e)
        {
            try
            {
                veritabanı.adminEkle(this);
                MessageBox.Show("İşlem başarıyla gerçekleşmiştir.");
            }
            catch
            {
                MessageBox.Show("İşlem gerçekleştirilemedi. Tekrar deneyiniz");
            }
        }


        private void yenile_Click(object sender, EventArgs e)
        {
            try
            {
                veritabanı.adminListele(this);

            }
            catch
            { MessageBox.Show("İşlem gerçekleştirilemedi. Tekrar deneyiniz"); }
        }

        private void adminler_SelectionChanged(object sender, EventArgs e)
        {
            if (adminler.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = adminler.SelectedRows[0];

                kullaniciAdi.Text = selectedRow.Cells["Kullanıcı Adı"].Value.ToString();
                sifre.Text = selectedRow.Cells["Şifre"].Value.ToString();
                telno.Text = selectedRow.Cells["Telefon No"].Value.ToString();
            }
        }

        private void guncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (adminler.SelectedRows.Count > 0)
                {
                    int adminId = Convert.ToInt32(adminler.SelectedRows[0].Cells["No"].Value);
                    Console.WriteLine("admin güncelle : " + adminId);
                    veritabanı.adminGuncelle(this, adminId);
                    MessageBox.Show("İşlem başarıyla gerçekleşmiştir.");
                }
            }
            catch
            {
                MessageBox.Show("İşlem gerçekleştirilemedi. Tekrar deneyiniz");
            }
        }

        private void adminSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (adminler.SelectedRows.Count > 0)
                {
                    int adminId = Convert.ToInt32(adminler.SelectedRows[0].Cells["No"].Value);

                    Console.WriteLine("admin sil : " + adminId);
                    veritabanı.adminSil(this, adminId);
                    MessageBox.Show("İşlem başarıyla gerçekleşmiştir.");
                }
            }
            catch
            {
                MessageBox.Show("İşlem gerçekleştirilemedi. Tekrar deneyiniz");
            }
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            Secenekler secenekler = new Secenekler();
            Program.geriDon(secenekler);
            this.Hide();
        }
    }
}
