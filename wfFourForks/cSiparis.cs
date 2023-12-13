using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace wfFourForks
{
    class cSiparis
    {
        private int _siparisNo;
        private int _masaNo;
        private int _personelNo;
        private DateTime _tarih;
        private bool _odendi;
        private decimal _tutar;

        #region Properties
        public int SiparisNo
        {
            get { return _siparisNo; }
            set { _siparisNo = value; }
        }


        public int MasaNo
        {
            get { return _masaNo; }
            set { _masaNo = value; }
        }


        public int PersonelNo
        {
            get { return _personelNo; }
            set { _personelNo = value; }
        }


        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }


        public decimal Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }
        private int _kasaNo;

        public int KasaNo
        {
            get { return _kasaNo; }
            set { _kasaNo = value; }
        }


        public bool Odendi
        {
            get { return _odendi; }
            set { _odendi = value; }
        }

        #endregion


        cGenel gnl = new cGenel();
        DataSet ds = new DataSet();

        public void MenuGetir(int TurID, ListView Menu)
        {
            Menu.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select UrunID, UrunAd, BirimFiyat from Urunler where TurNo=@TurNo", conn);
            comm.Parameters.Add("@TurNo", SqlDbType.Int).Value = TurID;
            SqlDataReader dr;
            int i = 0;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {

                    Menu.Items.Add(dr["UrunID"].ToString());
                    Menu.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    Menu.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public int  SiparisEkle(cSiparis sp)
        {
            int ID= 0;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("insert into Siparis (MasaNo,PersonelNo,Tutar) values (@MasaNo,@PersonelNo,@Tutar);SELECT scope_identity();", conn);
            comm.Parameters.Add("@MasaNo", SqlDbType.Int).Value = sp._masaNo;
            comm.Parameters.Add("@PersonelNo", SqlDbType.Int).Value = sp._personelNo;
            comm.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = sp.Tutar;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                ID = Convert.ToInt32(comm.ExecuteScalar());
               return ID;

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
               
            }
            finally { conn.Close(); }
            return ID;
        }
      

    }
}
