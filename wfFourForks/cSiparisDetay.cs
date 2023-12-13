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
    class cSiparisDetay
    {
        cGenel gnl = new cGenel();
        private int _siparisNo;
        private int _urunNo;
        private int _adet;
        private decimal _fiyat;
        #region PRoperties
        public int SiparisNo
        {
            get { return _siparisNo; }
            set { _siparisNo = value; }
        }


        public int UrunNo
        {
            get { return _urunNo; }
            set { _urunNo = value; }
        }


        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }


        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        #endregion
        public void SiparisDetayEkle(cSiparisDetay spd)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("insert into SiparisDetay (SiparisNo,UrunNo,Adet,Fiyat) values (@SiparisNo,@UrunNo,@Adet,@Fiyat)", conn);
            comm.Parameters.Add("@SiparisNo", SqlDbType.Int).Value = spd._siparisNo;
            comm.Parameters.Add("@UrunNo", SqlDbType.Int).Value = spd._urunNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = spd._adet;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = spd._fiyat;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int sonuc = comm.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public void SiparisGetir(int masaID,ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("Select UrunNo, Urunler.UrunAd, SiparisDetay.Adet,SiparisDetay.Fiyat from SiparisDetay inner join Urunler on Urunler.UrunID=SiparisDetay.UrunNo inner join Siparis on Siparis.SiparisNo=SiparisDetay.SiparisNo where Siparis.MasaNo=@MasaNo and Siparis.Odendi=0", conn);
            comm.Parameters.Add("@MasaNo",SqlDbType.Int).Value = masaID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            int i = 0;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
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





    }
}
