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
    class cKullanici
    {

        private string _kullaniciAdi;
        private string _sifre;


        #region Properties

        public string KullaniciAdi
        {
            get { return _kullaniciAdi; }
            set { _kullaniciAdi = value; }
        }

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }

        #endregion
        cGenel gnl = new cGenel();
      
        public bool KullaniciGirisi(cKullanici Kullanici)
        {
           
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select  PersonelNo, Yetki,K_Adi, K_Sifre from Personel where  K_Adi=@K_Adi and K_Sifre=@K_Sifre and Silindi=0", conn);
            comm.Parameters.Add("@K_Adi", SqlDbType.VarChar).Value = Kullanici._kullaniciAdi;
            comm.Parameters.Add("@K_Sifre", SqlDbType.VarChar).Value = Kullanici._sifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cGenel._personelNo =Convert.ToInt32(dr["PersonelNo"]);
                    cGenel._yetki = Convert.ToInt32(dr["Yetki"]);
                    cGenel._kadi = dr["K_Adi"].ToString();
                    sonuc = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);
            }
            finally { conn.Close(); }
            return sonuc;
        }

        //public void YetkiKontrol()
        //{
        //    if (Kullanici._yetki==0)
        //    {
        //        Yonetim.Enabled = false;
        //        Raporlar.Enabled = false;
        //        Kasa.Enabled = false;

        //    }
        //    else
        //    {
        //        Yonetim.Enabled = true;
        //        Raporlar.Enabled = true;
        //        Kasa.Enabled = true;               
        //    }
          



        ////}

    }
}
