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
    class cGenel
    {

        public string connStr = "Data Source=DNZTVS\\DENIZ; Initial Catalog=FourForks; integrated security=true";
         //public string connStr = "Data Source=SC-105-13\\MSSQL2012; Initial Catalog=FourForks; integrated security=true";

       // public string connStr = "Data Source=SEMA; Initial Catalog=FourForks; uid=sa; pwd=12345";
        public static int _personelNo;
        public static int _yetki;
        public static string _kadi;
        //private void FormAcikmi(Form AcilacakForm)
        //{
        //    bool Acikmi = false;
        //    for (int i = 0; i < this.MdiChildren.Length; i++)
        //    {
        //        if (AcilacakForm.Name == this.MdiChildren[i].Name)
        //        {
        //            this.MdiChildren[i].Focus(); //AcilacakForm, o ana kadar açılan formlar arasında 
        //            Acikmi = true;              //varsa, yeni açmaz, önceden açılanı aktif eder.
        //        }
        //    }
        //    if (Acikmi == false)
        //    {
        //        AcilacakForm.MdiParent = this; //AcilacakForm, o ana kadar açılan formlar arasında
        //        AcilacakForm.Show();        //yoksa, AnaSayfa'nın içinde yeni bir form olarak açar.
        //    }
        //    else
        //    {
        //        AcilacakForm.Dispose(); //AcilacakForm nesnesini hafızadan atar.
        //    }
        //}
    }
}
