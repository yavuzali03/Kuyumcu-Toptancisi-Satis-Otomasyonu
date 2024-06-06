using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    public class Hesaplamalar
    {
        public TextBox[] _cinsiTextBox = new TextBox[12];
        public TextBox[] _adetTextBox = new TextBox[12];
        public TextBox[] _iscilikTextBox = new TextBox[12];
        public TextBox[] _tutarTextBox = new TextBox[12];
        public TextBox[] _alinanGrTextBox = new TextBox[6];
        public TextBox[] _ayarTextBox = new TextBox[6];
        public TextBox[] _odemeTextBox = new TextBox[6];
        public TextBox[] _satilanGramTextBox = new TextBox[6];
        public TextBox[] _hasTextBox = new TextBox[6];
        public Label[] _milyemLabel = new Label[6];

        public List<TextBox> cinsiTextBox = new List<TextBox>();
        public List<TextBox> adetTextBox = new List<TextBox>();
        public List<TextBox> iscilikTextBox = new List<TextBox>();
        public List<TextBox> tutarTextBox = new List<TextBox>();
        public List<TextBox> alinanGrTextBox = new List<TextBox>();
        public List<TextBox> ayarTextBox = new List<TextBox>();
        public List<TextBox> odemeTextBox = new List<TextBox>();
        public List<TextBox> satilanGramTextBox = new List<TextBox>();
        public List<TextBox> hasTextBox = new List<TextBox>();
        public List<Label> milyemLabel = new List<Label>();


        public decimal odemeSonuc = 0;
        public decimal iscilikSonuc = 0;
        public decimal hasSonuc = 0;
        public decimal hasSatisToplam;
        public decimal satilanToplam;
        public decimal satilanSonuc;
        public decimal bakiye;
        public decimal toplamsatisVerisi;
        public decimal toplamOdemeVerisi;
        public decimal iscilikSonucVerisi;
        public decimal hasSatisToplamVerisi;
        public decimal bakiyeVerisi;

        public int fatura_id;


        public void hesaplamaYap(FaturaKes _faturaKes)
        {

            for (int i = 0; i < 12; i++)
            {

                _cinsiTextBox[i] = _faturaKes.Controls.Find("cinsi" + (i + 1), true).FirstOrDefault() as TextBox;
                _adetTextBox[i] = _faturaKes.Controls.Find("Adet" + (i + 1), true).FirstOrDefault() as TextBox;
                _iscilikTextBox[i] = _faturaKes.Controls.Find("iscilik" + (i + 1), true).FirstOrDefault() as TextBox;
                _tutarTextBox[i] = _faturaKes.Controls.Find("tutar" + (i + 1), true).FirstOrDefault() as TextBox;

                decimal adet = 0;
                decimal iscilik = 0;
                decimal tutar = 0;

                if (decimal.TryParse(_adetTextBox[i].Text, out adet) && decimal.TryParse(_iscilikTextBox[i].Text, out iscilik))
                {

                    tutar = adet * iscilik;
                    tutar = Math.Round(tutar, 2);

                    iscilikSonuc += tutar;

                    _tutarTextBox[i].Text = tutar.ToString();

                }
            }


            for (int j = 0; j < 6; j++)
            {
                _alinanGrTextBox[j] = _faturaKes.Controls.Find("alınanGr" + (j + 1), true).FirstOrDefault() as TextBox;
                _ayarTextBox[j] = _faturaKes.Controls.Find("ayar" + (j + 1), true).FirstOrDefault() as TextBox;
                _odemeTextBox[j] = _faturaKes.Controls.Find("odeme" + (j + 1), true).FirstOrDefault() as TextBox;
                _hasTextBox[j] = _faturaKes.Controls.Find("has" + (j + 1), true).FirstOrDefault() as TextBox;
                _satilanGramTextBox[j] = _faturaKes.Controls.Find("satilanGrTop" + (j + 1), true).FirstOrDefault() as TextBox;
                _milyemLabel[j] = _faturaKes.Controls.Find("milyem" + (j + 1), true).FirstOrDefault() as Label;

                decimal alinanGr, ayar, odeme, has, satilanGram, milyem;


                if (decimal.TryParse(_alinanGrTextBox[j].Text, out alinanGr) && decimal.TryParse(_ayarTextBox[j].Text, out ayar))
                {
                    odeme = alinanGr * (ayar / 1000);
                    odeme = Math.Round(odeme, 2);

                    odemeSonuc += odeme;

                    _odemeTextBox[j].Text = odeme.ToString();

                }

                if (decimal.TryParse(_satilanGramTextBox[j].Text, out satilanGram) && decimal.TryParse(_milyemLabel[j].Text, out milyem))
                {
                    has = satilanGram * (milyem / 1000);
                    has = Math.Round(has, 2);

                    hasSonuc += has;
                    satilanToplam += satilanGram;

                    _hasTextBox[j].Text = has.ToString();
                }

            }

            satilanSonuc = iscilikSonuc + satilanToplam;
            hasSatisToplam = hasSonuc;
            bakiye = (iscilikSonuc + hasSatisToplam) - odemeSonuc;



            satilanSonuc = Math.Round(satilanSonuc, 2);
            bakiye = Math.Round(bakiye, 2);
            hasSatisToplam = Math.Round(hasSatisToplam, 2);
            satilanToplam = Math.Round(satilanToplam, 2);

            iscilikSonucVerisi = iscilikSonuc;
            hasSatisToplamVerisi = hasSatisToplam;
            toplamsatisVerisi = satilanToplam;
            toplamOdemeVerisi = odemeSonuc;
            bakiyeVerisi = bakiye;

        }

        public void yazdir(FaturaKes _faturaKes)
        {

            _faturaKes.satisSonuc.Text = (iscilikSonuc + hasSatisToplam) + " Gr";
            _faturaKes.odemeLB.Text = odemeSonuc + " Gr";
            _faturaKes.bakiyeLB.Text = Convert.ToDecimal(_faturaKes.eskiBakiyeLB.Text) + bakiye + " Gr";
            _faturaKes.iscilikToplamLB.Text = iscilikSonuc + " Gr";

            hasSonuc = 0; hasSatisToplam = 0;
            satilanToplam = 0;
            iscilikSonuc = 0;
            odemeSonuc = 0;
            bakiye = 0;
        }


        //public void FaturaEkle(FaturaKes _faturaKes)
        //{

        //    Veritabanı veritabanı = new Veritabanı();

        //    veritabanı.baglanti.Open();

        //    decimal eskiBakiyeVerisi = Convert.ToDecimal(_faturaKes.eskiBakiyeLB.Text);

        //    SqlCommand faturaBilgileri = new SqlCommand("insert into TBLfaturalar (musteri_id, fatura_tarih, toplamSatis, toplamOdeme, satilan_has, eski_bakiye , yeni_bakiye ) values (@p1, @p2, @p3,@p4,@p5,@p6,@p7)", veritabanı.baglanti);

        //    faturaBilgileri.Parameters.AddWithValue("@p1", _faturaKes.kuyumcuCBX.SelectedValue);
        //    if (DateTime.TryParseExact(_faturaKes.tarih.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tarih))
        //    {

        //        faturaBilgileri.Parameters.AddWithValue("@p2", tarih);
        //    }

        //    faturaBilgileri.Parameters.AddWithValue("@p3", toplamsatisVerisi);
        //    faturaBilgileri.Parameters.AddWithValue("@p4", toplamOdemeVerisi);
        //    faturaBilgileri.Parameters.AddWithValue("@p5", hasSatisToplamVerisi);
        //    faturaBilgileri.Parameters.AddWithValue("@p6", eskiBakiyeVerisi);
        //    faturaBilgileri.Parameters.AddWithValue("@p7", eskiBakiyeVerisi + bakiyeVerisi);
        //    faturaBilgileri.ExecuteNonQuery();


        //    SqlCommand komut = new SqlCommand("SELECT TOP 1 fatura_id FROM TBLfaturalar ORDER BY fatura_id DESC", veritabanı.baglanti);
        //    int fatura_id = (int)komut.ExecuteScalar();

        //    //Satış Bilgileri
        //    for (int i = 0; i < 12; i++)
        //    {
        //        if ((!string.IsNullOrEmpty(_cinsiTextBox[i].Text) && !string.IsNullOrEmpty(_adetTextBox[i].Text) && !string.IsNullOrEmpty(_iscilikTextBox[i].Text) && !string.IsNullOrEmpty(_tutarTextBox[i].Text)))
        //        {


        //            SqlCommand satisbilgileri = new SqlCommand("insert into TBLsatisBilgileri ( urun_adi, urun_adet, urun_iscilik, urun_tutar, fatura_id, tutar_toplami) values (@p1, @p2, @p3, @p4, @p5, @p6)", veritabanı.baglanti);
        //            string urunVeri = _cinsiTextBox[i].Text;
        //            decimal adetVeri = Convert.ToDecimal(_adetTextBox[i].Text),
        //                    iscilikVeri = Convert.ToDecimal(_iscilikTextBox[i].Text),
        //                    tutarVeri = Convert.ToDecimal(_tutarTextBox[i].Text);

        //            satisbilgileri.Parameters.AddWithValue("@p1", urunVeri);
        //            satisbilgileri.Parameters.AddWithValue("@p2", adetVeri);
        //            satisbilgileri.Parameters.AddWithValue("@p3", iscilikVeri);
        //            satisbilgileri.Parameters.AddWithValue("@p4", tutarVeri);
        //            satisbilgileri.Parameters.AddWithValue("@p5", fatura_id);
        //            satisbilgileri.Parameters.AddWithValue("@p6", iscilikSonucVerisi);

        //            satisbilgileri.ExecuteNonQuery();
        //        }
        //    }
        //    for (int j = 0; j < 6; j++)
        //    {
        //        if (!string.IsNullOrEmpty(_satilanGramTextBox[j].Text) && !string.IsNullOrEmpty(_milyemLabel[j].Text) && !string.IsNullOrEmpty(_hasTextBox[j].Text))
        //        {

        //            SqlCommand satilanUrunler = new SqlCommand("insert into TBLsatilanUrunBilgileri (fatura_id , musteri_id, satilan_gram, milyem, satilan_has) values (@p1, @p2, @p3,@p4, @p5)", veritabanı.baglanti);

        //            decimal satilanGr = Convert.ToDecimal(_satilanGramTextBox[j].Text);
        //            decimal satilanGrMilyem = Convert.ToDecimal(_milyemLabel[j].Text);
        //            decimal satilanHas = Convert.ToDecimal(_hasTextBox[j].Text);

        //            satilanUrunler.Parameters.AddWithValue("@p1", fatura_id);
        //            satilanUrunler.Parameters.AddWithValue("@p2", _faturaKes.kuyumcuCBX.SelectedValue);
        //            satilanUrunler.Parameters.AddWithValue("@p3", satilanGr);
        //            satilanUrunler.Parameters.AddWithValue("@p4", satilanGrMilyem);
        //            satilanUrunler.Parameters.AddWithValue("@p5", satilanHas);

        //            satilanUrunler.ExecuteNonQuery();
        //        }

        //    }

        //    for (int k = 0; k < 6; k++)
        //    {
        //        if (!string.IsNullOrEmpty(_alinanGrTextBox[k].Text) && !string.IsNullOrEmpty(_ayarTextBox[k].Text) && !string.IsNullOrEmpty(_odemeTextBox[k].Text))
        //        {

        //            decimal alinangrVeri = Convert.ToDecimal(_alinanGrTextBox[k].Text);
        //            decimal ayarVeri = Convert.ToDecimal(_ayarTextBox[k].Text);
        //            decimal odemeVeri = Convert.ToDecimal(_odemeTextBox[k].Text);

        //            SqlCommand odemeBilgileri = new SqlCommand("insert into TBLodemeBilgileri (odeme_grami, odeme_ayari, odeme_tutarı, odeme_toplami, fatura_id, musteri_id) values (@p1, @p2, @p3, @p4,@p5, @p6)", veritabanı.baglanti);

        //            odemeBilgileri.Parameters.AddWithValue("@p1", alinangrVeri);
        //            odemeBilgileri.Parameters.AddWithValue("@p2", ayarVeri);
        //            odemeBilgileri.Parameters.AddWithValue("@p3", odemeVeri);
        //            odemeBilgileri.Parameters.AddWithValue("@p4", toplamOdemeVerisi);
        //            odemeBilgileri.Parameters.AddWithValue("@p5", fatura_id);
        //            odemeBilgileri.Parameters.AddWithValue("@p6", _faturaKes.kuyumcuCBX.SelectedValue);

        //            odemeBilgileri.ExecuteNonQuery();

        //        }
        //    }

        //    SqlCommand musteriBilgileri = new SqlCommand($"update TBLmusteriler set musteri_bakiye = @p1 where musteri_id ={_faturaKes.kuyumcuCBX.SelectedValue}", veritabanı.baglanti);

        //    musteriBilgileri.Parameters.AddWithValue("@p1", bakiyeVerisi + eskiBakiyeVerisi);



        //    musteriBilgileri.ExecuteNonQuery();

        //    veritabanı.baglanti.Close();

        //}
    }
}









