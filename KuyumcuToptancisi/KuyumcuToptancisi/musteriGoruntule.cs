using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class musteriGoruntule : Form
    {
        public musteriGoruntule()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        Veritabanı veritabanı = new Veritabanı();
        private void musteriGoruntule_Load(object sender, EventArgs e)
        {

            veritabanı.musteriler(this);
            veritabanı.sehirListesi(this);

            musteriListesi.Columns[1].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            musteriListesi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            musteriListesi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            musteriListesi.Columns[0].Visible = false;

        }

        private void musteriListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow seciliSatir = musteriListesi.Rows[e.RowIndex];

                int musteri_id = Convert.ToInt32(musteriListesi.Rows[e.RowIndex].Cells["ID"].Value);

                Console.WriteLine("ilk veri : " + musteri_id);

                MusteriAyrintılari musteriAyrintılari = new MusteriAyrintılari(musteri_id);
                musteriAyrintılari.Show();
                this.Hide();

            }
        }

        private void aramaBtn_Click(object sender, EventArgs e)
        {

            /*normal listeleme*/
            if (string.IsNullOrEmpty(musteri_arama.Text) && string.IsNullOrEmpty(sehirler.Text)) { veritabanı.arama_islemi(this); }

            else if (string.IsNullOrEmpty(musteri_arama.Text) && !string.IsNullOrEmpty(sehirler.Text)) { veritabanı.arama_islemi(this, sehirler.Text); }
            /*şehir + müşteri arama */
            else if (!string.IsNullOrEmpty(musteri_arama.Text) && !string.IsNullOrWhiteSpace(sehirler.Text)) { veritabanı.arama_islemi(this, musteri_arama.Text, sehirler.Text); }

            else { MessageBox.Show("lütfen geçerli bir arama yapınız"); }
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            Secenekler secenekler = new Secenekler();
            Program.geriDon(secenekler);
            this.Hide();
        }
    }
}
