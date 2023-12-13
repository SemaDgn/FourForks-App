using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfFourForks
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar ='*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtkAdi.Text.Trim() !="" && txtSifre.Text.Trim()!="")
            {
                cKullanici k = new cKullanici();
                k.KullaniciAdi = txtkAdi.Text;
                k.Sifre = txtSifre.Text;
               if( k.KullaniciGirisi(k))
                {
                    frmMenuler frm = new frmMenuler();
                    frm.ShowDialog();
                    Temizle();                  
                   
                }
               else
               {
                   lblMesaj.Text = "Kullanıcı Adı veya Şifre yanlıştır.";
                   
               }

            }
            else
            {
               lblMesaj.Text="Kullanıcı Adı veya Şifre boş geçilemez.";
               Temizle();
            }
          

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Temizle()
        {
            txtkAdi.Clear();
            txtSifre.Clear();
            lblMesaj.Text = "";
            txtkAdi.Focus();
        }

        private void txtkAdi_TextChanged(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }

      

      
    }
}
