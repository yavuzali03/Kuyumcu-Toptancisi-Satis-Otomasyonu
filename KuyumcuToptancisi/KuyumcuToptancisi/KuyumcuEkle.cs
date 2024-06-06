using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class KuyumcuEkle : Form
    {
        public KuyumcuEkle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        Veritabanı veritabanıKE = new Veritabanı();

        private void Kaydet_Click(object sender, EventArgs e)
        {
            veritabanıKE.musteriEkle(this);
            this.Close();
        }
    }
}
