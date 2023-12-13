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
    public partial class frmYonetim : Form
    {
        public frmYonetim()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();

        private void frmYonetim_Load(object sender, EventArgs e)
        {
                      
            cUrunler u = new cUrunler();
            u.UrunTurleriGetir(cbTurler);
            u.UrunleriGetir(lvUrunler);
            cPersonel p = new cPersonel();
            DataTable dt = p.PersonelGetir();
            dgvPersonel.DataSource = dt;
            dgvPersonel.Columns[0].Width = 30;

            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = true;
           
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
        }

        private void cbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler y = (cUrunler)cbTurler.SelectedItem;
            txtTurAd.Text = y.TurAd;
            txtTurNo.Text = Convert.ToString(y.TurNo);
            y.UrunleriGetirByTureGore(cbTurler, lvUrunler);

        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            txtUrunAd.Text = lvUrunler.SelectedItems[0].SubItems[1].Text;
            txtTurAd.Text = lvUrunler.SelectedItems[0].SubItems[3].Text;
            txtAdet.Text = lvUrunler.SelectedItems[0].SubItems[4].Text;
            txtFiyat.Text = lvUrunler.SelectedItems[0].SubItems[5].Text;
            txtAciklama.Text = lvUrunler.SelectedItems[0].SubItems[6].Text;
            txtUrunID.Text = lvUrunler.SelectedItems[0].SubItems[0].Text;
            txtTurNo.Text = lvUrunler.SelectedItems[0].SubItems[2].Text;

            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void Temizle()
        {
            txtUrunAd.Clear();
            txtTurAd.Clear();
            txtTurNo.Clear();
            txtAciklama.Clear();
            txtAdet.Clear();
            txtFiyat.Clear();
            txtUrunID.Clear();
            txtUrunAd.Focus();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text != "" && txtTurAd.Text != "")
            {
                cUrunler y = new cUrunler();
                y.UrunAd = txtUrunAd.Text;
                y.TurAd = txtTurAd.Text;
                y.TurNo = Convert.ToInt32(txtTurNo.Text);
                y.Adet = Convert.ToInt32(txtAdet.Text);
                y.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);
                y.Aciklama = txtAciklama.Text;
                if (y.UrunEkle(y))
                {
                    MessageBox.Show("Ürün Eklendi..");
                    btnKaydet.Enabled = false;
                    Temizle();
                    y.UrunleriGetir(lvUrunler);
                }
                else
                {
                    MessageBox.Show("Ürün Eklenemedi..!");
                }
            }
            else
            {
                MessageBox.Show("Öncelikle ürün adı ve tür adı giriniz!", "DİKKAT! Eksik bilgi var.");
            }


        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cUrunler y = new cUrunler();
            y.UrunAd = txtUrunAd.Text;
            y.TurNo = Convert.ToInt32(txtTurNo.Text);
            y.Adet = Convert.ToInt32(txtAdet.Text);
            y.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);
            y.Aciklama = txtAciklama.Text;
            y.UrunID = Convert.ToInt32(txtUrunID.Text);
            if (y.UrunGuncelle(y))
            {
                MessageBox.Show("Ürün kaydı güncellendi.");
                Temizle();
                y.UrunleriGetir(lvUrunler);
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ürün kaydı değiştirilemedi!", "DİKKAT!");
                y.UrunleriGetir(lvUrunler);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cUrunler y = new cUrunler();
            if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool sonuc = y.UrunSil(Convert.ToInt32(txtUrunID.Text));
                if (sonuc)
                {
                    MessageBox.Show("Ürün Silindi");
                    Temizle();
                    y.UrunleriGetir(lvUrunler);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ürün silme işlemi gerçekleşmedi!");
                }
            }
            else
            {
                MessageBox.Show("Ürün silme işleminden vazgeçildi");
            }
        }



        private void cbEgitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEgitimDurumu.Text = cbEgitim.SelectedItem.ToString();
        }

        private void dtpDTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtDogum.Text = dtpDTarihi.Value.ToShortDateString();
        }

        private void btnPYeni_Click(object sender, EventArgs e)
        {
            btnPKaydet.Enabled = true;
            btnPDegistir.Enabled = false;
            btnPSil.Enabled = false;
            PTemizle();
        }
        private void PTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtPersonelNo.Clear();
            txtDogum.Clear();
            txtEgitimDurumu.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtGirisTarihi.Clear();
            txtKAdi.Clear();
            txtKSifre.Clear();
            txtAd.Focus();
        }

        private void dtpGTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtGirisTarihi.Text = dtpGTarihi.Value.ToShortDateString();
        }

        private void dgvPersonel_DoubleClick(object sender, EventArgs e)
        {
            txtPersonelNo.Text = dgvPersonel.SelectedRows[0].Cells[0].Value.ToString();
            txtAd.Text = dgvPersonel.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyad.Text = dgvPersonel.SelectedRows[0].Cells[2].Value.ToString();
            txtDogum.Text = dgvPersonel.SelectedRows[0].Cells[3].Value.ToString();
            txtEgitimDurumu.Text = dgvPersonel.SelectedRows[0].Cells[4].Value.ToString();
            txtTelefon.Text = dgvPersonel.SelectedRows[0].Cells[5].Value.ToString();
            txtAdres.Text = dgvPersonel.SelectedRows[0].Cells[6].Value.ToString();
            txtGirisTarihi.Text = dgvPersonel.SelectedRows[0].Cells[7].Value.ToString();
            txtKAdi.Text = dgvPersonel.SelectedRows[0].Cells[8].Value.ToString();
            txtKSifre.Text = dgvPersonel.SelectedRows[0].Cells[9].Value.ToString();

            btnPKaydet.Enabled = false;
            btnPYeni.Enabled = true;
            btnPDegistir.Enabled = true;
            btnPSil.Enabled = true;

        }

        private void btnPDegistir_Click(object sender, EventArgs e)
        {

            cPersonel p = new cPersonel();

            bool sonuc = p.PersonelGuncelle(txtEgitimDurumu.Text,txtTelefon.Text,txtAdres.Text, txtKAdi.Text, txtKSifre.Text, Convert.ToInt32(txtPersonelNo.Text));
            if (sonuc)
            {
                MessageBox.Show("Personel kaydı güncellendi.");
                Temizle();
                DataTable dt = p.PersonelGetir();             
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;
                dgvPersonel.DataSource = dt;
               

            }
            else
            {
                MessageBox.Show("Ürün kaydı değiştirilemedi!", "DİKKAT!");               
              
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;
                Temizle();

            }
        }
        
       

        private void btnPKaydet_Click(object sender, EventArgs e)
        {
            cPersonel p = new cPersonel();
            //p.PersonelNo = Convert.ToInt32(txtPersonelNo.Text);
            p.PersonelAd = txtAd.Text;
            p.PersonelSoyad = txtSoyad.Text;
            p.DogumTarihi = Convert.ToDateTime(txtDogum.Text);
            p.EgitimDurumu = txtEgitimDurumu.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.K_adi = txtKAdi.Text;
            p.K_Sifre = txtKSifre.Text;
            p.GirisTarihi = Convert.ToDateTime(txtGirisTarihi.Text);

            bool sonuc = p.PersonelEkle(p);            
            DataTable dt = p.PersonelGetir();
            dgvPersonel.DataSource = dt;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true;
            Temizle();

        }

        private void btnPSil_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cPersonel p = new cPersonel();
                    bool sonuc = p.PersonelSil(Convert.ToInt32(txtPersonelNo.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Müşteri bilgileri silindi.");
                        Temizle();
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                       DataTable dt = p.PersonelGetir();
                       dgvPersonel.DataSource = dt;
                    }
                }
                else { MessageBox.Show("Silme işleminden vazgeçildi."); }
            }

       
       




        }

       



    }
    

    
    

