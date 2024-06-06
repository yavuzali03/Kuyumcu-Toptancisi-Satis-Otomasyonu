using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public partial class FaturaOrnek : Form

    {
        private Stack<Form> formGecmisi = new Stack<Form>();

        private int _faturaID;
        public FaturaOrnek(int FaturaID)
        {
            InitializeComponent();

            _faturaID = FaturaID;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public int FaturaID { get { return _faturaID; } set { value = _faturaID; } }

        Veritabanı veritabanı = new Veritabanı();

        private void FaturaOrnek_Load(object sender, EventArgs e)
        {


            try
            {
                veritabanı.faturaBilgileri(this, FaturaID);
                veritabanı.satilanAltin(this, FaturaID);
                veritabanı.satilanUrun(this, FaturaID);
                veritabanı.odemeBilgileri(this, FaturaID);

            }
            catch (InvalidOperationException ex) { MessageBox.Show("hata :" + ex); }

            satilanUrun.Columns[0].Width = 135;
            faturaBilgileri.Columns[0].Width = 70;

            satilanUrun.ClearSelection();
            satilanAltin.ClearSelection();
            odemeBilgileri.ClearSelection();
            faturaBilgileri.ClearSelection();
        }

    }
}
