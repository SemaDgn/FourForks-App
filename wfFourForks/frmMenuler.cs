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
    public partial class frmMenuler : Form
    {
        public frmMenuler()
        {
            InitializeComponent();
        }

        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus(); //AcilacakForm, o ana kadar açılan formlar arasında 
                    Acikmi = true;              //varsa, yeni açmaz, önceden açılanı aktif eder.
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this; //AcilacakForm, o ana kadar açılan formlar arasında
                AcilacakForm.Show();        //yoksa, AnaSayfa'nın içinde yeni bir form olarak açar.
            }
            else
            {
                AcilacakForm.Dispose(); //AcilacakForm nesnesini hafızadan atar.
            }
        }
        private void frmMenuler_Load(object sender, EventArgs e)
        {
            tsKullaniciAdi.Text = cGenel._kadi;
            tsPersonelNo.Text = cGenel._personelNo.ToString();
            if (cGenel._yetki==0)
            {
                btnKasa.Enabled = false;
                btnRaporlar.Enabled = false;
                btnYonetim.Enabled = false;
            }
            else
            {
                btnKasa.Enabled = true;
                btnRaporlar.Enabled = true;
                btnYonetim.Enabled = true;
                    
            }
            //k.YetkiKontrol(k, btnYonetim, btnRaporlar, btnKasa);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            frm.Show();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            frmYonetim frm = new frmYonetim();
            frm.Show();
        }
    }
}
