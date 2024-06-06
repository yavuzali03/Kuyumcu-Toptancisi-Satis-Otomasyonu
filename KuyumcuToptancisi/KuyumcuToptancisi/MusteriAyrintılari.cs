using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class MusteriAyrintılari : Form
    {

        private int _musteriId;

        public MusteriAyrintılari(int musteriID)
        {
            InitializeComponent();

            _musteriId = musteriID;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        Veritabanı veritabanı = new Veritabanı();

        public int musteri_ID { get { return _musteriId; } set { value = _musteriId; } }

        private void MusteriAyrintılari_Load(object sender, EventArgs e)
        {
            veritabanı.faturaListele(this, musteri_ID);
            veritabanı.musteriListele(this, musteri_ID);




        }
        private void musteriFaturalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = musteriFaturalar.Rows[e.RowIndex];

                int faturaID = Convert.ToInt32(musteriFaturalar.Rows[e.RowIndex].Cells["Fatura No"].Value);

                Console.WriteLine("ilk veri : " + faturaID);
                //Fatura fatura = new Fatura(faturaID);
                //fatura.Show();

                FaturaOrnek faturaOrnek = new FaturaOrnek(faturaID);
                faturaOrnek.Show();
            }
        }

        private void aramaBtn_Click(object sender, EventArgs e)
        {
            DateTime tarih = TarihSecimi.Value.Date;
            string tarihSql = tarih.ToString("yyyy-MM-dd");

            veritabanı.faturaListele(this, musteri_ID, tarihSql);

        }


        private void geriDon_Click(object sender, EventArgs e)
        {
            musteriGoruntule musteriGoruntule = new musteriGoruntule();
            Program.geriDon(musteriGoruntule);
            this.Hide();
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            veritabanı.faturaListele(this, musteri_ID);
            musteriFaturalar.Visible = true;

        }

    }
}
