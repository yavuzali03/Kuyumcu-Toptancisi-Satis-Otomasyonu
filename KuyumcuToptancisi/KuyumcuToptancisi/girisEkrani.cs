using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        Veritabanı veritabanı = new Veritabanı();

        private void girisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void girisButonu_Click(object sender, EventArgs e)
        {

            veritabanı.giris(this);


        }

        private void sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum _sifremiunuttum = new sifremiunuttum();

            _sifremiunuttum.Show();
            this.Hide();
        }

    }
}
