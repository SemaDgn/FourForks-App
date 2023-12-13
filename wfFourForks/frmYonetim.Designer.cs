namespace wfFourForks
{
    partial class frmYonetim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYonetim));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnYeni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtTurAd = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cbTurler = new System.Windows.Forms.ComboBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTurNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.txtGirisTarihi = new System.Windows.Forms.TextBox();
            this.dtpGTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDogum = new System.Windows.Forms.TextBox();
            this.txtEgitimDurumu = new System.Windows.Forms.TextBox();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.dtpDTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbEgitim = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtKSifre = new System.Windows.Forms.TextBox();
            this.txtKAdi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPSil = new System.Windows.Forms.Button();
            this.btnPDegistir = new System.Windows.Forms.Button();
            this.btnPKaydet = new System.Windows.Forms.Button();
            this.btnPYeni = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 493);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.btnYeni);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lvUrunler);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.btnDegistir);
            this.tabPage1.Controls.Add(this.btnKaydet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Denetim";
            // 
            // btnYeni
            // 
            this.btnYeni.FlatAppearance.BorderSize = 0;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeni.Location = new System.Drawing.Point(20, 332);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(60, 59);
            this.btnYeni.TabIndex = 28;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.txtUrunID);
            this.groupBox2.Controls.Add(this.txtTurAd);
            this.groupBox2.Controls.Add(this.txtUrunAd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAciklama);
            this.groupBox2.Controls.Add(this.cbTurler);
            this.groupBox2.Controls.Add(this.txtAdet);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTurNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(20, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 266);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Bilgileri";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(246, 44);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(18, 23);
            this.txtUrunID.TabIndex = 13;
            // 
            // txtTurAd
            // 
            this.txtTurAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurAd.Location = new System.Drawing.Point(103, 78);
            this.txtTurAd.Name = "txtTurAd";
            this.txtTurAd.ReadOnly = true;
            this.txtTurAd.Size = new System.Drawing.Size(102, 23);
            this.txtTurAd.TabIndex = 12;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(103, 44);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(139, 23);
            this.txtUrunAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tür Ad:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(103, 116);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(139, 48);
            this.txtAciklama.TabIndex = 10;
            // 
            // cbTurler
            // 
            this.cbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurler.DropDownWidth = 100;
            this.cbTurler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTurler.FormattingEnabled = true;
            this.cbTurler.Location = new System.Drawing.Point(206, 78);
            this.cbTurler.Name = "cbTurler";
            this.cbTurler.Size = new System.Drawing.Size(20, 24);
            this.cbTurler.TabIndex = 4;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(103, 170);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(139, 23);
            this.txtAdet.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(103, 204);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(139, 23);
            this.txtFiyat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adet:";
            // 
            // txtTurNo
            // 
            this.txtTurNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurNo.Location = new System.Drawing.Point(239, 78);
            this.txtTurNo.Name = "txtTurNo";
            this.txtTurNo.ReadOnly = true;
            this.txtTurNo.Size = new System.Drawing.Size(18, 23);
            this.txtTurNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(304, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Menü:";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5});
            this.lvUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.Location = new System.Drawing.Point(307, 51);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(672, 287);
            this.lvUrunler.TabIndex = 16;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.DoubleClick += new System.EventHandler(this.lvUrunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ÜrünID";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Ad";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tür No";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 1;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tür Ad";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adet";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 78;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Birim Fiyat";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.Width = 149;
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(226, 332);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 59);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.FlatAppearance.BorderSize = 0;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Image")));
            this.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDegistir.Location = new System.Drawing.Point(156, 332);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(64, 59);
            this.btnDegistir.TabIndex = 14;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(86, 332);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(64, 59);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage2.Controls.Add(this.dgvPersonel);
            this.tabPage2.Controls.Add(this.txtGirisTarihi);
            this.tabPage2.Controls.Add(this.dtpGTarihi);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtKSifre);
            this.tabPage2.Controls.Add(this.txtKAdi);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnPSil);
            this.tabPage2.Controls.Add(this.btnPDegistir);
            this.tabPage2.Controls.Add(this.btnPKaydet);
            this.tabPage2.Controls.Add(this.btnPYeni);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Denetim";
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(314, 52);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonel.Size = new System.Drawing.Size(780, 341);
            this.dgvPersonel.TabIndex = 50;
            this.dgvPersonel.DoubleClick += new System.EventHandler(this.dgvPersonel_DoubleClick);
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.Location = new System.Drawing.Point(110, 275);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.ReadOnly = true;
            this.txtGirisTarihi.Size = new System.Drawing.Size(113, 20);
            this.txtGirisTarihi.TabIndex = 49;
            // 
            // dtpGTarihi
            // 
            this.dtpGTarihi.Location = new System.Drawing.Point(221, 275);
            this.dtpGTarihi.Name = "dtpGTarihi";
            this.dtpGTarihi.Size = new System.Drawing.Size(22, 20);
            this.dtpGTarihi.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDogum);
            this.groupBox1.Controls.Add(this.txtEgitimDurumu);
            this.groupBox1.Controls.Add(this.txtPersonelNo);
            this.groupBox1.Controls.Add(this.dtpDTarihi);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbEgitim);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Location = new System.Drawing.Point(16, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 238);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // txtDogum
            // 
            this.txtDogum.Location = new System.Drawing.Point(94, 86);
            this.txtDogum.Name = "txtDogum";
            this.txtDogum.ReadOnly = true;
            this.txtDogum.Size = new System.Drawing.Size(113, 20);
            this.txtDogum.TabIndex = 48;
            // 
            // txtEgitimDurumu
            // 
            this.txtEgitimDurumu.Location = new System.Drawing.Point(94, 123);
            this.txtEgitimDurumu.Name = "txtEgitimDurumu";
            this.txtEgitimDurumu.ReadOnly = true;
            this.txtEgitimDurumu.Size = new System.Drawing.Size(113, 20);
            this.txtEgitimDurumu.TabIndex = 47;
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(222, 26);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(23, 20);
            this.txtPersonelNo.TabIndex = 47;
            // 
            // dtpDTarihi
            // 
            this.dtpDTarihi.Location = new System.Drawing.Point(202, 86);
            this.dtpDTarihi.Name = "dtpDTarihi";
            this.dtpDTarihi.Size = new System.Drawing.Size(23, 20);
            this.dtpDTarihi.TabIndex = 40;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(122, 20);
            this.txtSoyad.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Personel Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Personel Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(122, 20);
            this.txtAd.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Eğitim Durumu:";
            // 
            // cbEgitim
            // 
            this.cbEgitim.BackColor = System.Drawing.Color.White;
            this.cbEgitim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEgitim.DropDownWidth = 100;
            this.cbEgitim.FormattingEnabled = true;
            this.cbEgitim.Items.AddRange(new object[] {
            "Lise",
            "Ön Lisans",
            "Lisans",
            "Yüksek Lisans"});
            this.cbEgitim.Location = new System.Drawing.Point(205, 123);
            this.cbEgitim.Name = "cbEgitim";
            this.cbEgitim.Size = new System.Drawing.Size(20, 21);
            this.cbEgitim.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Telefon:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 208);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(122, 20);
            this.txtAdres.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Adres:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 171);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(122, 20);
            this.txtTelefon.TabIndex = 36;
            // 
            // txtKSifre
            // 
            this.txtKSifre.Location = new System.Drawing.Point(110, 327);
            this.txtKSifre.Name = "txtKSifre";
            this.txtKSifre.Size = new System.Drawing.Size(122, 20);
            this.txtKSifre.TabIndex = 43;
            // 
            // txtKAdi
            // 
            this.txtKAdi.Location = new System.Drawing.Point(110, 301);
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(122, 20);
            this.txtKAdi.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Giriş Tarihi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Kullanıcı Şifre:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Kullanıcı Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Personel Listesi";
            // 
            // btnPSil
            // 
            this.btnPSil.FlatAppearance.BorderSize = 0;
            this.btnPSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSil.Image = ((System.Drawing.Image)(resources.GetObject("btnPSil.Image")));
            this.btnPSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPSil.Location = new System.Drawing.Point(238, 367);
            this.btnPSil.Name = "btnPSil";
            this.btnPSil.Size = new System.Drawing.Size(59, 58);
            this.btnPSil.TabIndex = 30;
            this.btnPSil.Text = "Sil";
            this.btnPSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPSil.UseVisualStyleBackColor = true;
            this.btnPSil.Click += new System.EventHandler(this.btnPSil_Click);
            // 
            // btnPDegistir
            // 
            this.btnPDegistir.FlatAppearance.BorderSize = 0;
            this.btnPDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnPDegistir.Image")));
            this.btnPDegistir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDegistir.Location = new System.Drawing.Point(163, 368);
            this.btnPDegistir.Name = "btnPDegistir";
            this.btnPDegistir.Size = new System.Drawing.Size(60, 58);
            this.btnPDegistir.TabIndex = 29;
            this.btnPDegistir.Text = "Değiştir";
            this.btnPDegistir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPDegistir.UseVisualStyleBackColor = true;
            this.btnPDegistir.Click += new System.EventHandler(this.btnPDegistir_Click);
            // 
            // btnPKaydet
            // 
            this.btnPKaydet.FlatAppearance.BorderSize = 0;
            this.btnPKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnPKaydet.Image")));
            this.btnPKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPKaydet.Location = new System.Drawing.Point(90, 368);
            this.btnPKaydet.Name = "btnPKaydet";
            this.btnPKaydet.Size = new System.Drawing.Size(67, 58);
            this.btnPKaydet.TabIndex = 28;
            this.btnPKaydet.Text = "Kaydet";
            this.btnPKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPKaydet.UseVisualStyleBackColor = true;
            this.btnPKaydet.Click += new System.EventHandler(this.btnPKaydet_Click);
            // 
            // btnPYeni
            // 
            this.btnPYeni.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnPYeni.FlatAppearance.BorderSize = 0;
            this.btnPYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnPYeni.Image")));
            this.btnPYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPYeni.Location = new System.Drawing.Point(13, 368);
            this.btnPYeni.Name = "btnPYeni";
            this.btnPYeni.Size = new System.Drawing.Size(71, 58);
            this.btnPYeni.TabIndex = 27;
            this.btnPYeni.Text = "Yeni";
            this.btnPYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPYeni.UseVisualStyleBackColor = true;
            this.btnPYeni.Click += new System.EventHandler(this.btnPYeni_Click);
            // 
            // frmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 519);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYonetim";
            this.Text = "Yönetim işlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYonetim_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtTurAd;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cbTurler;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTurNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.TextBox txtGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDogum;
        private System.Windows.Forms.TextBox txtEgitimDurumu;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.DateTimePicker dtpDTarihi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbEgitim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtKSifre;
        private System.Windows.Forms.TextBox txtKAdi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPSil;
        private System.Windows.Forms.Button btnPDegistir;
        private System.Windows.Forms.Button btnPKaydet;
        private System.Windows.Forms.Button btnPYeni;


    }
}