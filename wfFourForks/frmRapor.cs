using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wfFourForks
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();

        DataTable dt = new DataTable();

        private void frmRapor_Load(object sender, EventArgs e)
        {
            cbOdeme.SelectedItem = "Tümü";
            dtpSonTarih.Visible = false;
            btnRapor.Left = 60;
            btnRapor.Top = 80;
        }

        private void rbTarih_CheckedChanged(object sender, EventArgs e)
        {
            dtpSonTarih.Visible = true;
            btnRapor.Left = 170;
            btnRapor.Top = 80;
        }

        private void rbGunluk_CheckedChanged(object sender, EventArgs e)
        {
            dtpSonTarih.Visible = false;
            btnRapor.Left = 60;
            btnRapor.Top = 80;
        }
       
        private void btnRapor_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (rbGunluk.Checked==true)
            {
                SqlConnection conn = new SqlConnection(gnl.connStr);
                SqlDataAdapter da = new SqlDataAdapter("select Tarih,PersonelAd,Tutar from Siparis inner join Personel on Personel.PersonelNo=Siparis.PersonelNo inner join Kasa on Siparis.KasaNo = Kasa.KasaNo where convert(varchar(20),Tarih,104)=convert(varchar(20),@Tarih,104) and KasaNo = @KasaNo ", conn);
                da.SelectCommand.Parameters.Add("@KasaNo", SqlDbType.Int).Value = cbOdeme.SelectedItem.ToString();
                da.SelectCommand.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = dtpIlkTarih.Value.ToShortDateString();
                da.Fill(dt);
                dgvRapor.DataSource = dt;
                dgvRapor.Columns["Tarih"].Width = 100;
                dgvRapor.Columns["PersonelAd"].Width = 120;
                dgvRapor.Columns["Tutar"].Width = 70;
                dgvRapor.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else
            {
                SqlConnection conn = new SqlConnection(gnl.connStr);
                SqlDataAdapter da = new SqlDataAdapter("select Tarih,PersonelAd,Tutar from Siparis inner join Personel on Personel.PersonelNo=Siparis.PersonelNo inner join Kasa on Siparis.KasaNo = Kasa.KasaNo where convert(varchar(20),Tarih,104) between convert(varchar(20),@İlkTarih,104) and convert(varchar(20),@SonTarih,104 and KasaNo = @KasaNo) ", conn);
                da.SelectCommand.Parameters.Add("@KasaNo", SqlDbType.Int).Value = cbOdeme.SelectedItem.ToString();
                da.SelectCommand.Parameters.Add("@İlkTarih", SqlDbType.DateTime).Value = dtpIlkTarih.Value.ToShortDateString();
                da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = dtpSonTarih.Value.ToShortDateString();
                da.Fill(dt);
                dgvRapor.DataSource = dt;
                dgvRapor.Columns["Tarih"].Width = 100;
                dgvRapor.Columns["PersonelAd"].Width = 120;
                dgvRapor.Columns["Tutar"].Width = 70;
                dgvRapor.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}
