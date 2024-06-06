using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class Secenekler : Form
    {
        public Secenekler()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void faturaKes_Click(object sender, EventArgs e)
        {
            FaturaKes frm2 = new FaturaKes();
            frm2.Show();
            this.Hide();
        }

        private void sonFaturalar_Click(object sender, EventArgs e)
        {
            sonFaturalar frm = new sonFaturalar();
            frm.Show();
            this.Hide();
        }

        private void faturalarıListele_Click(object sender, EventArgs e)
        {
            musteriGoruntule frFaturalarListesi = new musteriGoruntule();
            frFaturalarListesi.Show();
            this.Hide();
        }

        private void adminAyarlari_Click(object sender, EventArgs e)
        {
            adminAyarlari frm = new adminAyarlari();
            frm.Show();
            this.Hide();
        }
    }
}
