using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace wfFourForks
{
    class cUrunler
    {
        cGenel gnl = new cGenel();

        private int _urunID;
        private string _urunAd;
        private string _turAd;
        private int _turNo;
        private int _adet;
        private decimal _birimFiyat;
        private string _aciklama;

        #region Properties
        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }

        public string UrunAd
        {
            get { return _urunAd; }
            set { _urunAd = value; }
        }

        public int TurNo
        {
            get { return _turNo; }
            set { _turNo = value; }
        }

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }

        public decimal BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }

        public string TurAd
        {
            get { return _turAd; }
            set { _turAd = value; }
        } 
        #endregion


        public void UrunleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select UrunID,UrunAd,Urunler.TurNo,TurAd,Adet,BirimFiyat,Urunler.Aciklama from Urunler inner join UrunTurleri on Urunler.TurNo=UrunTurleri.TurNo where Urunler.Silindi=0 order by Urunler.TurNo", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunID"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["TurNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adet"].ToString());
                    liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public void UrunTurleriGetir(ComboBox Turler)
        {
            Turler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select * from UrunTurleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cUrunler y = new cUrunler();
                y.TurNo = Convert.ToInt32(dr["TurNo"]);
                y.TurAd = dr["TurAd"].ToString();
                Turler.Items.Add(y);
                
            }
            dr.Close();
                conn.Close();
        }

        public bool UrunEkle(cUrunler y)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Insert into Urunler (UrunAd, TurNo, Adet, BirimFiyat, Aciklama) values (@UrunAd,@TurNo, @Adet, @BirimFiyat, @Aciklama)", conn);
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = y._urunAd;
            comm.Parameters.Add("@TurNo", SqlDbType.Int).Value = y._turNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = y._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Decimal).Value = y._birimFiyat;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = y._aciklama;        
            
           
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            return sonuc;

        }

        public void UrunleriGetirByTureGore(ComboBox Turler, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select UrunID,UrunAd,Urunler.TurNo,TurAd,Adet,BirimFiyat,Urunler.Aciklama from Urunler inner join UrunTurleri on Urunler.TurNo=UrunTurleri.TurNo where Urunler.Silindi=0 and TurAd=@TurAd", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = Turler.SelectedItem.ToString();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                int i = 0;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunID"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["TurNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adet"].ToString());
                    liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                    i++;
                }
                dr.Close();

            }
            catch (SqlException ex)
            {
                
              string hata =ex.Message;
            }
        finally{conn.Close();}
        
        }
        public override string ToString()
        {
            return TurAd;
        }
        public bool UrunGuncelle(cUrunler y)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Urunler set UrunAd=@UrunAd, TurNo=@TurNo, Adet=@Adet, BirimFiyat=@BirimFiyat, Aciklama=@Aciklama where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = y._urunAd;
            comm.Parameters.Add("@TurNo", SqlDbType.VarChar).Value = y._turNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = y._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = y._birimFiyat;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = y._aciklama;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = y._urunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public bool UrunSil(int ID)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Update Urunler set Silindi=1 where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        //public void PersonelleriGetir(ListView liste)
        //{
        //    liste.Items.Clear();
        //    SqlConnection conn = new SqlConnection(gnl.connStr);
        //    SqlCommand comm = new SqlCommand("select PersonelNo, PersonelAd, PersonelSoyad, DogumTarihi, EgitimDurumu, Telefon, Adres, GirisTarihi, K_Adi,K_Sifre from Personel where Silindi=0", conn);
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr;
        //    try
        //    {
        //        dr = comm.ExecuteReader();
        //        int i = 0;
        //        while (dr.Read())
        //        {
        //            liste.Items.Add(dr["PersonelNo"].ToString());
        //            liste.Items[i].SubItems.Add(dr["PersonelAd"].ToString());
        //            liste.Items[i].SubItems.Add(dr["PersonelSoyad"].ToString());
        //            liste.Items[i].SubItems.Add(dr["DogumTarihi"].ToString());
        //            liste.Items[i].SubItems.Add(dr["EgitimDurumu"].ToString());
        //            liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
        //            liste.Items[i].SubItems.Add(dr["Adres"].ToString());
        //            liste.Items[i].SubItems.Add(dr["GirisTarihi"].ToString());
        //            liste.Items[i].SubItems.Add(dr["K_Adi"].ToString());
        //            liste.Items[i].SubItems.Add(dr["K_Sifre"].ToString());
        //            i++;
        //        }
        //        dr.Close();
        //    }
        //    catch (SqlException ex)
        //    {

        //        string hata = ex.Message;
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally { conn.Close(); }
        //}
        //public bool PersonelEkle(cUrunler y)
        //{
        //    bool sonuc = false;
        //    SqlConnection conn = new SqlConnection(gnl.connStr);
        //    SqlCommand comm = new SqlCommand("Insert into Personel (PersonelAd, PersonelSoyad, DogumTarihi, EgitimDurumu, Telefon, Adres, GirisTarihi, K_Adi,K_Sifre) values (@PersonelAd, @PersonelSoyad,@DogumTarihi, @EgitimDurumu, @Telefon, @Adres, @GirisTarihi, @K_Adi,@K_Sifre)", conn);
        //    comm.Parameters.Add("@PersonelAd", SqlDbType.VarChar).Value = y._personelAd;
        //    comm.Parameters.Add("@PersonelSoyad", SqlDbType.VarChar).Value = y._personelSoyad;
        //    comm.Parameters.Add("@DogumTarihi", SqlDbType.DateTime).Value = y._dogumTarihi;
        //    comm.Parameters.Add("@EgitimDurumu", SqlDbType.VarChar).Value = y._egitimDurumu;
        //    comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = y._telefon;
        //    comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = y._adres;
        //    comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = y._girisTarihi;
        //    comm.Parameters.Add("@K_Adi", SqlDbType.VarChar).Value = y._k_adi;
        //    comm.Parameters.Add("@K_Sifre", SqlDbType.VarChar).Value = y._k_Sifre;
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    try
        //    {
        //        sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
        //    }
        //    catch (SqlException ex)
        //    {

        //        string hata = ex.Message;
        //    }
        //    finally { conn.Close(); }
        //    return sonuc;
        //}

        
        
    }
}
