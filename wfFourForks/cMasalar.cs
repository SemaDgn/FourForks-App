using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace wfFourForks
{
    class cMasalar
    {
        private int _masaID;
        private string _masaAd;
        #region Properties
        public int MasaID
        {
            get { return _masaID; }
            set { _masaID = value; }
        }


        public string MasaAd
        {
            get { return _masaAd; }
            set { _masaAd = value; }
        } 
        #endregion
        cGenel gnl = new cGenel();
        public bool MasaKontrol(int masaID, Button btn )
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select * from Masalar where MasaID=@MasaID", conn);
            comm.Parameters.Add("@MasaID", SqlDbType.Int).Value = masaID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    return true;
                    btn.BackColor = Color.Red;


                }
                dr.Close();
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
