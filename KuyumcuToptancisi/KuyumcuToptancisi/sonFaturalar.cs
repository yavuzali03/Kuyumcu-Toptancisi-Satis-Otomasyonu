using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class sonFaturalar : Form
    {


        public sonFaturalar()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        Veritabanı veritabanı = new Veritabanı();
        Hesaplamalar hesaplamalar = new Hesaplamalar();


        private void sonFaturalar_Load(object sender, EventArgs e)
        {
            veritabanı.sehirListesi(this);
            veritabanı.faturaListele(this);

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
        }

        private void geriDon_Click_1(object sender, EventArgs e)
        {
            Secenekler secenekler = new Secenekler();
            Program.geriDon(secenekler);
            this.Hide();
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


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow seciliSatir = dataGridView1.Rows[e.RowIndex];

                int faturaID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Fatura No"].Value);

                FaturaOrnek faturaOrnek = new FaturaOrnek(faturaID);
                faturaOrnek.Show();
            }
        }
    }
}
