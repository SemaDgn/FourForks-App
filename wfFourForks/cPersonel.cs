using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace wfFourForks
{
    class cPersonel
    {
        private int _personelNo;
        private string _personelAd;
        private string _personelSoyad;
        private DateTime _dogumTarihi;
        private string _egitimDurumu;
        private string _telefon;
        private string _adres;
        private DateTime _girisTarihi;
        private string _k_adi;
        private string _k_Sifre;

        #region Properties
        public int PersonelNo
        {
            get { return _personelNo; }
            set { _personelNo = value; }
        }

        public string PersonelAd
        {
            get { return _personelAd; }
            set { _personelAd = value; }
        }

        public string PersonelSoyad
        {
            get { return _personelSoyad; }
            set { _personelSoyad = value; }
        }

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        public string EgitimDurumu
        {
            get { return _egitimDurumu; }
            set { _egitimDurumu = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public DateTime GirisTarihi
        {
            get { return _girisTarihi; }
            set { _girisTarihi = value; }
        }

        public string K_adi
        {
            get { return _k_adi; }
            set { _k_adi = value; }
        }

        public string K_Sifre
        {
            get { return _k_Sifre; }
            set { _k_Sifre = value; }
        }

        #endregion

        cGenel gnl = new cGenel();
         DataSet ds = new DataSet();
        public DataTable PersonelGetir()
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlDataAdapter da = new SqlDataAdapter("select PersonelNo, PersonelAd, PersonelSoyad, DogumTarihi, EgitimDurumu, Telefon, Adres, GirisTarihi, K_Adi, K_Sifre from Personel where Silindi=0", conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }

            return dt;
        }
        

        public bool PersonelGuncelle(string Egitim, string Telefon, string Adres, string KAdi, string KSifre, int ID)
        {
            cPersonel p = new cPersonel();
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Personel set  EgitimDurumu=@EgitimDurumu,Telefon=@Telefon, Adres= @Adres,  K_Adi=@K_Adi,K_Sifre=@K_Sifre where PersonelNo=@PersonelNo", conn);
            comm.Parameters.Add("@PersonelNo", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@EgitimDurumu", SqlDbType.VarChar).Value = Egitim;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = Adres;           
            comm.Parameters.Add("@K_Adi", SqlDbType.VarChar).Value = KAdi;
            comm.Parameters.Add("@K_Sifre", SqlDbType.VarChar).Value = KSifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;

        }
        public bool PersonelSil(int ID)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Personel set Silindi=1 where PersonelNo=@PersonelNo", conn);
            comm.Parameters.Add("@PersonelNo", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;
        }
        public bool PersonelEkle(cPersonel p)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Insert into Personel (PersonelAd,PersonelSoyad,K_Adi,K_Sifre,GirisTarihi,DogumTarihi, EgitimDurumu, Adres,Telefon) values(@PersonelAd,@PersonelSoyad, @K_Adi,@K_Sifre,@GirisTarihi,@DogumTarihi,@EgitimDurumu,@Adres,@Telefon)", conn);
            comm.Parameters.Add("@PersonelAd", SqlDbType.VarChar).Value = p._personelAd;
            comm.Parameters.Add("@PersonelSoyad", SqlDbType.VarChar).Value = p._personelSoyad;
            comm.Parameters.Add("@DogumTarihi", SqlDbType.DateTime).Value = p._dogumTarihi;
            comm.Parameters.Add("@EgitimDurumu", SqlDbType.VarChar).Value = p._egitimDurumu;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = p._girisTarihi;
            comm.Parameters.Add("@K_Adi", SqlDbType.VarChar).Value = p._k_adi;
            comm.Parameters.Add("@K_Sifre", SqlDbType.VarChar).Value = p._k_Sifre;
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

    }
}
