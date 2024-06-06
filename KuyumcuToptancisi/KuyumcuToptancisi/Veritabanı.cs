using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{

    public class Veritabanı
    {

        public SqlConnection baglanti = new SqlConnection(@"Data Source = .; Initial Catalog = dbOtomasyon; Integrated Security = True");

        public void FaturaEkle(FaturaKes _faturaKes , Hesaplamalar hesaplamalar)
        {

            Veritabanı veritabanı = new Veritabanı();

            veritabanı.baglanti.Open();

            decimal eskiBakiyeVerisi = Convert.ToDecimal(_faturaKes.eskiBakiyeLB.Text);

            SqlCommand faturaBilgileri = new SqlCommand("insert into TBLfaturalar (musteri_id, fatura_tarih, toplamSatis, toplamOdeme, satilan_has, eski_bakiye , yeni_bakiye ) values (@p1, @p2, @p3,@p4,@p5,@p6,@p7)", veritabanı.baglanti);

            faturaBilgileri.Parameters.AddWithValue("@p1", _faturaKes.kuyumcuCBX.SelectedValue);
            if (DateTime.TryParseExact(_faturaKes.tarih.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tarih))
            {

                faturaBilgileri.Parameters.AddWithValue("@p2", tarih);
            }

            faturaBilgileri.Parameters.AddWithValue("@p3", hesaplamalar.toplamsatisVerisi);
            faturaBilgileri.Parameters.AddWithValue("@p4", hesaplamalar.toplamOdemeVerisi);
            faturaBilgileri.Parameters.AddWithValue("@p5", hesaplamalar.hasSatisToplamVerisi);
            faturaBilgileri.Parameters.AddWithValue("@p6", eskiBakiyeVerisi);
            faturaBilgileri.Parameters.AddWithValue("@p7", eskiBakiyeVerisi + hesaplamalar.bakiyeVerisi);
            faturaBilgileri.ExecuteNonQuery();


            SqlCommand komut = new SqlCommand("SELECT TOP 1 fatura_id FROM TBLfaturalar ORDER BY fatura_id DESC", veritabanı.baglanti);
            int fatura_id = (int)komut.ExecuteScalar();

            //Satış Bilgileri
            for (int i = 0; i < 12; i++)
            {
                if ((!string.IsNullOrEmpty(hesaplamalar._cinsiTextBox[i].Text) && !string.IsNullOrEmpty(hesaplamalar._adetTextBox[i].Text) && !string.IsNullOrEmpty(hesaplamalar._iscilikTextBox[i].Text) && !string.IsNullOrEmpty(hesaplamalar._tutarTextBox[i].Text)))
                {


                    SqlCommand satisbilgileri = new SqlCommand("insert into TBLsatisBilgileri ( urun_adi, urun_adet, urun_iscilik, urun_tutar, fatura_id, tutar_toplami) values (@p1, @p2, @p3, @p4, @p5, @p6)", veritabanı.baglanti);
                    string urunVeri = hesaplamalar._cinsiTextBox[i].Text;
                    decimal adetVeri = Convert.ToDecimal(hesaplamalar._adetTextBox[i].Text),
                            iscilikVeri = Convert.ToDecimal(hesaplamalar._iscilikTextBox[i].Text),
                            tutarVeri = Convert.ToDecimal(hesaplamalar._tutarTextBox[i].Text);

                    satisbilgileri.Parameters.AddWithValue("@p1", urunVeri);
                    satisbilgileri.Parameters.AddWithValue("@p2", adetVeri);
                    satisbilgileri.Parameters.AddWithValue("@p3", iscilikVeri);
                    satisbilgileri.Parameters.AddWithValue("@p4", tutarVeri);
                    satisbilgileri.Parameters.AddWithValue("@p5", fatura_id);
                    satisbilgileri.Parameters.AddWithValue("@p6", hesaplamalar.iscilikSonucVerisi);

                    satisbilgileri.ExecuteNonQuery();
                }
            }
            for (int j = 0; j < 6; j++)
            {
                if (!string.IsNullOrEmpty(hesaplamalar._satilanGramTextBox[j].Text) && !string.IsNullOrEmpty(hesaplamalar._milyemLabel[j].Text) && !string.IsNullOrEmpty(hesaplamalar._hasTextBox[j].Text))
                {

                    SqlCommand satilanUrunler = new SqlCommand("insert into TBLsatilanUrunBilgileri (fatura_id , musteri_id, satilan_gram, milyem, satilan_has) values (@p1, @p2, @p3,@p4, @p5)", veritabanı.baglanti);

                    decimal satilanGr = Convert.ToDecimal(hesaplamalar._satilanGramTextBox[j].Text);
                    decimal satilanGrMilyem = Convert.ToDecimal(hesaplamalar._milyemLabel[j].Text);
                    decimal satilanHas = Convert.ToDecimal(hesaplamalar._hasTextBox[j].Text);

                    satilanUrunler.Parameters.AddWithValue("@p1", fatura_id);
                    satilanUrunler.Parameters.AddWithValue("@p2", _faturaKes.kuyumcuCBX.SelectedValue);
                    satilanUrunler.Parameters.AddWithValue("@p3", satilanGr);
                    satilanUrunler.Parameters.AddWithValue("@p4", satilanGrMilyem);
                    satilanUrunler.Parameters.AddWithValue("@p5", satilanHas);

                    satilanUrunler.ExecuteNonQuery();
                }

            }

            for (int k = 0; k < 6; k++)
            {
                if (!string.IsNullOrEmpty(hesaplamalar._alinanGrTextBox[k].Text) && !string.IsNullOrEmpty(hesaplamalar._ayarTextBox[k].Text) && !string.IsNullOrEmpty(hesaplamalar._odemeTextBox[k].Text))
                {

                    decimal alinangrVeri = Convert.ToDecimal(hesaplamalar._alinanGrTextBox[k].Text);
                    decimal ayarVeri = Convert.ToDecimal(hesaplamalar._ayarTextBox[k].Text);
                    decimal odemeVeri = Convert.ToDecimal(hesaplamalar._odemeTextBox[k].Text);

                    SqlCommand odemeBilgileri = new SqlCommand("insert into TBLodemeBilgileri (odeme_grami, odeme_ayari, odeme_tutarı, odeme_toplami, fatura_id, musteri_id) values (@p1, @p2, @p3, @p4,@p5, @p6)", veritabanı.baglanti);

                    odemeBilgileri.Parameters.AddWithValue("@p1", alinangrVeri);
                    odemeBilgileri.Parameters.AddWithValue("@p2", ayarVeri);
                    odemeBilgileri.Parameters.AddWithValue("@p3", odemeVeri);
                    odemeBilgileri.Parameters.AddWithValue("@p4", hesaplamalar.toplamOdemeVerisi);
                    odemeBilgileri.Parameters.AddWithValue("@p5", fatura_id);
                    odemeBilgileri.Parameters.AddWithValue("@p6", _faturaKes.kuyumcuCBX.SelectedValue);

                    odemeBilgileri.ExecuteNonQuery();

                }
            }

            SqlCommand musteriBilgileri = new SqlCommand($"update TBLmusteriler set musteri_bakiye = @p1 where musteri_id ={_faturaKes.kuyumcuCBX.SelectedValue}", veritabanı.baglanti);

            musteriBilgileri.Parameters.AddWithValue("@p1", hesaplamalar.bakiyeVerisi + eskiBakiyeVerisi);



            musteriBilgileri.ExecuteNonQuery();

            veritabanı.baglanti.Close();

        }

        public void musteriListesi(FaturaKes _faturaKes)
        {

            baglanti.Open();

            SqlCommand listele = new SqlCommand("select * from TBLmusteriler", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(listele);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            _faturaKes.kuyumcuCBX.ValueMember = "musteri_id";
            _faturaKes.kuyumcuCBX.DisplayMember = "musteri_adi";

            _faturaKes.kuyumcuCBX.DataSource = dt1;

            _faturaKes.kuyumcuCBX.SelectedValueChanged += (object sender, EventArgs e) =>
            {
                SqlCommand eskiBakiye = new SqlCommand($"SELECT musteri_bakiye FROM TBLmusteriler WHERE musteri_id = {_faturaKes.kuyumcuCBX.SelectedValue}", baglanti);
                SqlDataAdapter da2 = new SqlDataAdapter(eskiBakiye);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                _faturaKes.eskiBakiyeLB.Text = dt2.Rows[0]["musteri_bakiye"].ToString();
            };

            baglanti.Close();
        }

        public void musteriEkle(KuyumcuEkle _kuyumcuEkle)
        {
            try
            {
                baglanti.Open();

                SqlCommand kuyumcuEkle =
                    new SqlCommand(
                        "insert into TBLmusteriler (musteri_adi , musteri_sehir , musteri_bakiye ) values (@p1 , @p2 , @p3) ",
                        baglanti);
                kuyumcuEkle.Parameters.AddWithValue("@p1", _kuyumcuEkle.dukkanAd.Text);
                kuyumcuEkle.Parameters.AddWithValue("@p2", _kuyumcuEkle.dukkanSehir.Text);
                kuyumcuEkle.Parameters.AddWithValue("@p3", 0);
                kuyumcuEkle.ExecuteNonQuery();

                MessageBox.Show("Kuyumcu Eklendi.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kuyumcu eklenemedi. " + ex);
            }
            finally
            {
                baglanti.Close();
            }
        }
        public void giris(girisEkrani _giris)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM adminBilgileri WHERE kullanici_adi = @ad AND sifre = @şifre", baglanti);

            komut.Parameters.AddWithValue("@ad", _giris.kullaniciAdi.Text.ToLower());
            komut.Parameters.AddWithValue("@şifre", _giris.sifre.Text.ToLower());

            int sonuc = (int)komut.ExecuteScalar();

            if (sonuc > 0)
            {
                Secenekler frm3 = new Secenekler();
                girisEkrani girisfrm = new girisEkrani();
                frm3.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }

            baglanti.Close();
        }

        public void sehirListesi(sonFaturalar _sonFaturalar)
        {
            baglanti.Open();

            SqlCommand listele = new SqlCommand("select distinct musteri_sehir from TBLmusteriler", baglanti);
            SqlDataReader dr2 = listele.ExecuteReader();
            while (dr2.Read())
            {
                _sonFaturalar.sehirler.Items.Add(dr2["musteri_sehir"].ToString());


            }

            baglanti.Close();

            _sonFaturalar.sehirler.Items.Insert(0, "");
            _sonFaturalar.sehirler.SelectedIndex = 0;
        }
        public void sehirListesi(musteriGoruntule _musteriGoruntule)
        {
            baglanti.Open();

            SqlCommand listele = new SqlCommand("select distinct musteri_sehir from TBLmusteriler", baglanti);
            SqlDataReader dr2 = listele.ExecuteReader();
            while (dr2.Read())
            {
                _musteriGoruntule.sehirler.Items.Add(dr2["musteri_sehir"].ToString());


            }

            baglanti.Close();

            _musteriGoruntule.sehirler.Items.Insert(0, "");
            _musteriGoruntule.sehirler.SelectedIndex = 0;
        }
        public void faturaListele(sonFaturalar _sonfaturalar)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT TOP 1 fatura_id FROM TBLfaturalar ORDER BY fatura_id DESC", baglanti);
            int fatura_id = (int)komut.ExecuteScalar();

            string sqlSorgusu = "select top 30 TBLfaturalar.fatura_id as 'Fatura No', \r\nTBLmusteriler.musteri_adi as 'Müşteri Adı',\r\nTBLfaturalar.fatura_tarih as 'Fatura Tarihi',\r\nTBLfaturalar.toplamSatis as 'Toplam Satış',\r\nTBLfaturalar.toplamOdeme as 'Toplam Ödeme',\r\nTBLfaturalar.satilan_has as 'Satılan Has',\r\nTBLfaturalar.eski_bakiye as 'Eski Bakiye',\r\nTBLfaturalar.yeni_bakiye as 'Yeni Bakiye'\r\nfrom TBLfaturalar\r\ninner join TBLmusteriler on TBLfaturalar.musteri_id = TBLmusteriler.musteri_id\r\nORDER BY fatura_id DESC";

            SqlCommand faturaBilgileri = new SqlCommand(sqlSorgusu, baglanti);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(faturaBilgileri);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            _sonfaturalar.dataGridView1.DataSource = dataTable;

            _sonfaturalar.dataGridView1.Columns[0].Width = 70;
            _sonfaturalar.dataGridView1.Columns[1].Width = 250;

            baglanti.Close();

        }

        public void faturaListele(MusteriAyrintılari musteriAyrintılari, int musteri_id)
        {
            baglanti.Open();

            string sqlSorgusu = $"select TBLfaturalar.fatura_id as 'Fatura No',\r\nTBLfaturalar.fatura_tarih as 'Fatura Tarihi',\r\nTBLfaturalar.satilan_has as 'Satılan Has',\r\nTBLfaturalar.toplamSatis as 'Toplam Satış',\r\nTBLfaturalar.toplamOdeme as 'Toplam Ödeme',\r\nTBLfaturalar.eski_bakiye as 'Eski Bakiye',\r\nTBLfaturalar.yeni_bakiye as 'Yeni Bakiye'\r\nfrom TBLfaturalar \r\ninner join TBLmusteriler on TBLmusteriler.musteri_id = TBLfaturalar.musteri_id where TBLmusteriler.musteri_id = {musteri_id} order by fatura_tarih desc";

            SqlCommand faturaBilgileri = new SqlCommand(sqlSorgusu, baglanti);

            SqlDataReader veriOkuma = faturaBilgileri.ExecuteReader();

            if (veriOkuma.HasRows)
            {
                veriOkuma.Close();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(faturaBilgileri);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                musteriAyrintılari.musteriFaturalar.DataSource = dataTable;

                musteriAyrintılari.infoicon.Visible = false;
                musteriAyrintılari.bilgi.Visible = false;

                musteriAyrintılari.musteriFaturalar.Columns[0].Width = 70;
            }
            else
            {
                musteriAyrintılari.infoicon.Visible = true;
                musteriAyrintılari.bilgi.Visible = true;
            }

            baglanti.Close();
        }

        public void faturaListele(MusteriAyrintılari musteriAyrintılari, int musteri_id, string tarih)
        {
            baglanti.Open();


            Console.WriteLine(" veritabanı " + tarih);

            string sqlSorgusu = $"select TBLfaturalar.fatura_id as 'Fatura No',\r\nTBLfaturalar.fatura_tarih as 'Fatura Tarihi',\r\nTBLfaturalar.satilan_has as 'Satılan Has',\r\nTBLfaturalar.toplamSatis as 'Toplam Satış',\r\nTBLfaturalar.toplamOdeme as 'Toplam Ödeme',\r\nTBLfaturalar.eski_bakiye as 'Eski Bakiye',\r\nTBLfaturalar.yeni_bakiye as 'Yeni Bakiye'\r\nfrom TBLfaturalar \r\ninner join TBLmusteriler on TBLmusteriler.musteri_id = TBLfaturalar.musteri_id where TBLfaturalar.musteri_id = {musteri_id} and TBLfaturalar.fatura_tarih = '{tarih}' ";

            SqlCommand faturaBilgileri = new SqlCommand(sqlSorgusu, baglanti);

            SqlDataReader veriOkuma = faturaBilgileri.ExecuteReader();

            if (veriOkuma.HasRows)
            {
                veriOkuma.Close();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(faturaBilgileri);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                musteriAyrintılari.musteriFaturalar.DataSource = dataTable;

                musteriAyrintılari.musteriFaturalar.Visible = true;
                musteriAyrintılari.infoicon.Visible = false;
                musteriAyrintılari.bilgi.Visible = false;

                musteriAyrintılari.musteriFaturalar.Columns[0].Width = 70;
            }
            else
            {
                musteriAyrintılari.musteriFaturalar.Visible = false;
                musteriAyrintılari.infoicon.Visible = true;
                musteriAyrintılari.bilgi.Visible = true;

            }

            baglanti.Close();
        }
        public void arama_islemi(sonFaturalar _sonfaturalar)
        {
            faturaListele(_sonfaturalar);
        }

        public void arama_islemi(sonFaturalar _sonfaturalar, string sehir)
        {

            baglanti.Open();

            string sorgu = "select top 30 TBLfaturalar.fatura_id as 'Fatura No' , TBLmusteriler.musteri_adi as 'Müşteri Adı',\r\nTBLfaturalar.fatura_tarih as 'Fatura Tarihi',\r\nTBLfaturalar.toplamSatis as 'Toplam Satış',\r\nTBLfaturalar.toplamOdeme as 'Toplam Ödeme',\r\nTBLfaturalar.satilan_has as 'Satılan Has',\r\nTBLfaturalar.eski_bakiye as 'Eski Bakiye',\r\nTBLfaturalar.yeni_bakiye as 'Yeni Bakiye' from TBLfaturalar\r\ninner join TBLmusteriler on TBLmusteriler.musteri_id = TBLfaturalar.musteri_id\r\nwhere TBLmusteriler.musteri_sehir = @p1 \r\nORDER BY fatura_tarih DESC";
            SqlCommand sehirArama = new SqlCommand(sorgu, baglanti);
            sehirArama.Parameters.AddWithValue("@p1", sehir);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sehirArama);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _sonfaturalar.dataGridView1.DataSource = dataTable;




            baglanti.Close();

        }

        public void arama_islemi(sonFaturalar _sonfaturalar, string musteri_adi, string sehir)
        {

            baglanti.Open();

            string sqlSorgusu = "select top 30 TBLfaturalar.fatura_id as 'Fatura No' ,TBLmusteriler.musteri_adi as 'Müşteri Adı',\r\nTBLfaturalar.fatura_tarih as 'Fatura Tarihi',\r\nTBLfaturalar.toplamSatis as 'Toplam Satış',\r\nTBLfaturalar.toplamOdeme as 'Toplam Ödeme',\r\nTBLfaturalar.satilan_has as 'Satılan Has',\r\nTBLfaturalar.eski_bakiye as 'Eski Bakiye',\r\nTBLfaturalar.yeni_bakiye as 'Yeni Bakiye' from TBLfaturalar\r\ninner join TBLmusteriler on TBLmusteriler.musteri_id = TBLfaturalar.musteri_id\r\nwhere TBLmusteriler.musteri_adi = @p1 and TBLmusteriler.musteri_sehir = @p2 ORDER BY fatura_tarih DESC";

            SqlCommand faturaBilgileri = new SqlCommand();

            faturaBilgileri.CommandText = sqlSorgusu;
            faturaBilgileri.Connection = baglanti;

            faturaBilgileri.Parameters.AddWithValue("@p1", musteri_adi);
            faturaBilgileri.Parameters.AddWithValue("@p2", sehir);


            SqlDataReader veriOkuma = faturaBilgileri.ExecuteReader();

            if (veriOkuma.HasRows)
            {
                veriOkuma.Close();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(faturaBilgileri);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _sonfaturalar.dataGridView1.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Seçtiğiniz şehirde böyle bir müşteri bulunmamaktadır. Lütfen tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();
        }

        public void arama_islemi(musteriGoruntule _musteriGoruntule)
        {
            musteriler(_musteriGoruntule);
        }

        public void arama_islemi(musteriGoruntule _musteriGoruntule, string sehir)
        {

            baglanti.Open();

            string sorgu = "select musteri_id as 'ID' , musteri_adi as 'Müşteri Adı' , musteri_sehir as 'Şehir', musteri_bakiye as 'Bakiye' from TBLmusteriler where musteri_sehir = @p1 ";
            SqlCommand sehirArama = new SqlCommand(sorgu, baglanti);
            sehirArama.Parameters.AddWithValue("@p1", sehir);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sehirArama);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _musteriGoruntule.musteriListesi.DataSource = dataTable;




            baglanti.Close();

        }

        public void arama_islemi(musteriGoruntule _musteriGoruntule, string musteri_adi, string sehir)
        {

            baglanti.Open();

            string sqlSorgusu = "select musteri_id as 'ID' , musteri_adi as 'Müşteri Adı' , musteri_sehir as 'Şehir', musteri_bakiye as 'Bakiye' from TBLmusteriler where musteri_adi = @p1 and musteri_sehir = @p2 ";

            SqlCommand faturaBilgileri = new SqlCommand();

            faturaBilgileri.CommandText = sqlSorgusu;
            faturaBilgileri.Connection = baglanti;

            faturaBilgileri.Parameters.AddWithValue("@p1", musteri_adi);
            faturaBilgileri.Parameters.AddWithValue("@p2", sehir);


            SqlDataReader veriOkuma = faturaBilgileri.ExecuteReader();

            if (veriOkuma.HasRows)
            {
                veriOkuma.Close();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(faturaBilgileri);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _musteriGoruntule.musteriListesi.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Seçtiğiniz şehirde böyle bir müşteri bulunmamaktadır. Lütfen tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();
        }


        public void faturaBilgileri(FaturaOrnek faturaOrnek, int faturaId)
        {
            baglanti.Open();

            string sorgu = "Select\r\nTBLfaturalar.fatura_id as 'Fatura No',\r\nTBLfaturalar.fatura_tarih as 'Fatura Tarihi',\r\nTBLfaturalar.satilan_has as 'Satılan Has',\r\nTBLfaturalar.toplamSatis as 'Toplam Satış',\r\nTBLfaturalar.toplamOdeme as 'Toplam Ödeme',\r\nTBLfaturalar.eski_bakiye as 'Eski Bakiye',\r\nTBLfaturalar.yeni_bakiye as 'Yeni Bakiye'\r\nfrom TBLfaturalar where fatura_id = @p1";
            SqlCommand faturaKomut = new SqlCommand(sorgu, baglanti);
            faturaKomut.Parameters.AddWithValue("@p1", faturaId);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(faturaKomut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            faturaOrnek.faturaBilgileri.DataSource = dataTable;

            SqlCommand musteriAdi_Tarih = new SqlCommand($"select fatura_tarih , musteri_adi from TBLfaturalar\r\ninner join TBLmusteriler on TBLmusteriler.musteri_id = TBLfaturalar.musteri_id  where TBLfaturalar.fatura_id = {faturaId}", baglanti);
            SqlDataReader gelenVeri = musteriAdi_Tarih.ExecuteReader();

            if (gelenVeri.Read())
            {
                DateTime tarih = gelenVeri.GetDateTime(0);
                faturaOrnek.LBmusteriAdi.Text = gelenVeri.GetString(1);
                faturaOrnek.LBtarih.Text = tarih.ToString("dd.MM.yyyy");
            }

            baglanti.Close();



        }

        public void odemeBilgileri(FaturaOrnek faturaOrnek, int faturaId)
        {
            // baglanti.Open();

            string sorgu = "select TBLodemeBilgileri.odeme_grami as 'Gram', \r\nTBLodemeBilgileri.odeme_ayari as 'Milyem', \r\nTBLodemeBilgileri.odeme_tutarı as 'Has' from TBLodemeBilgileri \r\ninner join TBLfaturalar on TBLodemeBilgileri.fatura_id = TBLfaturalar.fatura_id where TBLfaturalar.fatura_id = @p2";
            SqlCommand odemeKomut = new SqlCommand(sorgu, baglanti);
            odemeKomut.Parameters.AddWithValue("@p2", faturaId);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(odemeKomut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            faturaOrnek.odemeBilgileri.DataSource = dataTable;

            baglanti.Close();
        }

        public void satilanAltin(FaturaOrnek faturaOrnek, int faturaId)
        {
            baglanti.Open();

            string sorgu = "select\r\nTBLsatilanUrunBilgileri.satilan_gram as 'Gram',\r\nTBLsatilanUrunBilgileri.milyem as 'Milyem',\r\nTBLsatilanUrunBilgileri.satilan_has as 'Has'\r\nfrom TBLsatilanUrunBilgileri\r\ninner join TBLfaturalar on TBLsatilanUrunBilgileri.fatura_id = TBLfaturalar.fatura_id where TBLfaturalar.fatura_id = @p3";
            SqlCommand satilanAltinKomut = new SqlCommand(sorgu, baglanti);
            satilanAltinKomut.Parameters.AddWithValue("@p3", faturaId);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(satilanAltinKomut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            faturaOrnek.satilanAltin.DataSource = dataTable;

            baglanti.Close();
        }

        public void satilanUrun(FaturaOrnek faturaOrnek, int faturaId)
        {
            baglanti.Open();

            string sorgu = "select TBLsatisBilgileri.urun_adi as 'Ürün Adı',\r\nTBLsatisBilgileri.urun_adet as 'Ürün Adeti',\r\nTBLsatisBilgileri.urun_iscilik as 'Ürün İşçilik',\r\nTBLsatisBilgileri.urun_tutar as 'İşçilik Toplamı'\r\nfrom TBLsatisBilgileri\r\ninner join TBLfaturalar on TBLsatisBilgileri.fatura_id = TBLfaturalar.fatura_id where TBLfaturalar.fatura_id = @p4 ";
            SqlCommand odemeKomut = new SqlCommand(sorgu, baglanti);
            odemeKomut.Parameters.AddWithValue("@p4", faturaId);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(odemeKomut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            faturaOrnek.satilanUrun.DataSource = dataTable;
        }

        public void musteriler(musteriGoruntule musteri)
        {
            string sorgu = "select musteri_id as 'ID' , musteri_adi as 'Müşteri Adı', musteri_sehir as 'Şehir' , musteri_bakiye as 'Bakiye' from TBLmusteriler ";
            SqlCommand musteriListele = new SqlCommand(sorgu, baglanti);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(musteriListele);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            musteri.musteriListesi.DataSource = dataTable;

            void faturaListele(int musteriID)
            {

            }
        }

        public void musteriListele(MusteriAyrintılari _musteriAyrinti, int musteriId)
        {
            baglanti.Open();
            try
            {
                SqlCommand musteriListele = new SqlCommand($"select musteri_adi, musteri_bakiye from TBLmusteriler where musteri_id = @p1 ", baglanti);
                musteriListele.Parameters.AddWithValue("@p1", musteriId);

                SqlDataReader dataReader = musteriListele.ExecuteReader();
                if (dataReader.Read())
                {
                    _musteriAyrinti.LBmusteriAd.Text = dataReader["musteri_adi"].ToString();
                    _musteriAyrinti.LBmusteriBKY.Text = dataReader["musteri_bakiye"].ToString();

                }

            }
            catch (SqlException ex) { MessageBox.Show("hata " + ex); }

            baglanti.Close();
        }

        public void adminListele(adminAyarlari adminAyarlari)
        {
            baglanti.Open();

            SqlCommand adminListele = new SqlCommand("select admin_id as 'No', kullanici_adi as 'Kullanıcı Adı', sifre as 'Şifre', tel_no as 'Telefon No' from adminBilgileri", baglanti);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(adminListele);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            adminAyarlari.adminler.DataSource = dataTable;

            baglanti.Close();

        }
        public void adminEkle(adminAyarlari adminAyarlari)
        {
            baglanti.Open();

            SqlCommand adminEkle = new SqlCommand("insert into adminBilgileri (kullanici_adi, sifre, tel_no) values (@p1 , @p2, @p3)", baglanti);
            adminEkle.Parameters.AddWithValue("@p1", adminAyarlari.kullaniciAdi.Text);
            adminEkle.Parameters.AddWithValue("@p2", adminAyarlari.sifre.Text);
            adminEkle.Parameters.AddWithValue("@p3", adminAyarlari.telno.Text);

            adminEkle.ExecuteNonQuery();

            baglanti.Close();
        }
        public void adminSil(adminAyarlari adminAyarlari, int admin_id)
        {

            baglanti.Open();

            SqlCommand adminsil = new SqlCommand($"delete from adminBilgileri where admin_id = {admin_id} ", baglanti);

            adminsil.ExecuteNonQuery();

            baglanti.Close();
        }
        public void adminGuncelle(adminAyarlari adminAyarlari, int admin_id)
        {

            baglanti.Open();

            SqlCommand adminguncelle = new SqlCommand($"update adminBilgileri set kullanici_adi = '{adminAyarlari.kullaniciAdi.Text}' , sifre = '{adminAyarlari.sifre.Text}' ,  tel_no = '{adminAyarlari.telno.Text}'  where admin_id = {admin_id}", baglanti);

            adminguncelle.ExecuteNonQuery();

            baglanti.Close();

        }
    }
}
