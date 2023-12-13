namespace wfFourForks
{
    partial class frmSiparis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparis));
            this.btnAnaYemek = new System.Windows.Forms.Button();
            this.imliconlar = new System.Windows.Forms.ImageList(this.components);
            this.btnCorbalar = new System.Windows.Forms.Button();
            this.btnSalatalar = new System.Windows.Forms.Button();
            this.brnİcecek = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grbMenuler = new System.Windows.Forms.GroupBox();
            this.dgvMenuler = new System.Windows.Forms.DataGridView();
            this.grbAdet = new System.Windows.Forms.GroupBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnAdisyonKapat = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMasaSiparis = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsPersonelNo = new System.Windows.Forms.ToolStripLabel();
            this.tsKullaniciAdi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMesaj = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTarih = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.grbMenuler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuler)).BeginInit();
            this.grbAdet.SuspendLayout();
            this.gbMasaSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnaYemek
            // 
            this.btnAnaYemek.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaYemek.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnaYemek.ImageIndex = 0;
            this.btnAnaYemek.ImageList = this.imliconlar;
            this.btnAnaYemek.Location = new System.Drawing.Point(140, 125);
            this.btnAnaYemek.Name = "btnAnaYemek";
            this.btnAnaYemek.Size = new System.Drawing.Size(107, 107);
            this.btnAnaYemek.TabIndex = 0;
            this.btnAnaYemek.Text = "Ana Yemek";
            this.btnAnaYemek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaYemek.UseVisualStyleBackColor = true;
            this.btnAnaYemek.Click += new System.EventHandler(this.button1_Click);
            // 
            // imliconlar
            // 
            this.imliconlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imliconlar.ImageStream")));
            this.imliconlar.TransparentColor = System.Drawing.Color.Transparent;
            this.imliconlar.Images.SetKeyName(0, "anayemek.png");
            this.imliconlar.Images.SetKeyName(1, "çorba.png");
            this.imliconlar.Images.SetKeyName(2, "salata.png");
            this.imliconlar.Images.SetKeyName(3, "soğukiçecek.png");
            this.imliconlar.Images.SetKeyName(4, "başlangıç.png");
            this.imliconlar.Images.SetKeyName(5, "tatlı.png");
            this.imliconlar.Images.SetKeyName(6, "camera_test.png");
            this.imliconlar.Images.SetKeyName(7, "button_cancel.png");
            this.imliconlar.Images.SetKeyName(8, "close.png");
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCorbalar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCorbalar.ImageIndex = 1;
            this.btnCorbalar.ImageList = this.imliconlar;
            this.btnCorbalar.Location = new System.Drawing.Point(140, 12);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(107, 107);
            this.btnCorbalar.TabIndex = 1;
            this.btnCorbalar.Text = "Çorbalar";
            this.btnCorbalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorbalar.UseVisualStyleBackColor = true;
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalatalar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalatalar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalatalar.ImageIndex = 2;
            this.btnSalatalar.ImageList = this.imliconlar;
            this.btnSalatalar.Location = new System.Drawing.Point(12, 125);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.Size = new System.Drawing.Size(107, 107);
            this.btnSalatalar.TabIndex = 3;
            this.btnSalatalar.Text = "Salatalar";
            this.btnSalatalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalatalar.UseVisualStyleBackColor = true;
            // 
            // brnİcecek
            // 
            this.brnİcecek.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brnİcecek.ForeColor = System.Drawing.SystemColors.Window;
            this.brnİcecek.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnİcecek.ImageIndex = 3;
            this.brnİcecek.ImageList = this.imliconlar;
            this.brnİcecek.Location = new System.Drawing.Point(12, 238);
            this.brnİcecek.Name = "brnİcecek";
            this.brnİcecek.Size = new System.Drawing.Size(107, 107);
            this.brnİcecek.TabIndex = 4;
            this.brnİcecek.Text = "İçecekler";
            this.brnİcecek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brnİcecek.UseVisualStyleBackColor = true;
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTatlilar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTatlilar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTatlilar.ImageIndex = 5;
            this.btnTatlilar.ImageList = this.imliconlar;
            this.btnTatlilar.Location = new System.Drawing.Point(140, 238);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(107, 107);
            this.btnTatlilar.TabIndex = 5;
            this.btnTatlilar.Text = "Tatlılar";
            this.btnTatlilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTatlilar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.imliconlar;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 107);
            this.button3.TabIndex = 6;
            this.button3.Text = "Başlangıç";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grbMenuler
            // 
            this.grbMenuler.BackColor = System.Drawing.Color.LightGray;
            this.grbMenuler.Controls.Add(this.dgvMenuler);
            this.grbMenuler.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbMenuler.ForeColor = System.Drawing.Color.White;
            this.grbMenuler.Location = new System.Drawing.Point(314, 12);
            this.grbMenuler.Name = "grbMenuler";
            this.grbMenuler.Size = new System.Drawing.Size(410, 646);
            this.grbMenuler.TabIndex = 2;
            this.grbMenuler.TabStop = false;
            this.grbMenuler.Text = "Menuler";
            // 
            // dgvMenuler
            // 
            this.dgvMenuler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMenuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuler.Location = new System.Drawing.Point(6, 39);
            this.dgvMenuler.Name = "dgvMenuler";
            this.dgvMenuler.Size = new System.Drawing.Size(398, 603);
            this.dgvMenuler.TabIndex = 0;
            // 
            // grbAdet
            // 
            this.grbAdet.BackColor = System.Drawing.Color.LightGray;
            this.grbAdet.Controls.Add(this.txtSayi);
            this.grbAdet.Controls.Add(this.btnSil);
            this.grbAdet.Controls.Add(this.btn0);
            this.grbAdet.Controls.Add(this.btn3);
            this.grbAdet.Controls.Add(this.btn2);
            this.grbAdet.Controls.Add(this.btn1);
            this.grbAdet.Controls.Add(this.btn6);
            this.grbAdet.Controls.Add(this.btn5);
            this.grbAdet.Controls.Add(this.btn4);
            this.grbAdet.Controls.Add(this.btn9);
            this.grbAdet.Controls.Add(this.btn8);
            this.grbAdet.Controls.Add(this.btn7);
            this.grbAdet.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbAdet.ForeColor = System.Drawing.Color.White;
            this.grbAdet.Location = new System.Drawing.Point(7, 351);
            this.grbAdet.Name = "grbAdet";
            this.grbAdet.Size = new System.Drawing.Size(240, 307);
            this.grbAdet.TabIndex = 5;
            this.grbAdet.TabStop = false;
            this.grbAdet.Text = "Adet";
            // 
            // txtSayi
            // 
            this.txtSayi.BackColor = System.Drawing.Color.Khaki;
            this.txtSayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSayi.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi.ForeColor = System.Drawing.Color.Black;
            this.txtSayi.Location = new System.Drawing.Point(41, 33);
            this.txtSayi.Multiline = true;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.ReadOnly = true;
            this.txtSayi.Size = new System.Drawing.Size(159, 37);
            this.txtSayi.TabIndex = 37;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gold;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSil.FlatAppearance.BorderSize = 5;
            this.btnSil.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(151, 239);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(49, 48);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "C";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gold;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn0.FlatAppearance.BorderSize = 5;
            this.btn0.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(41, 239);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(104, 48);
            this.btn0.TabIndex = 35;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gold;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn3.FlatAppearance.BorderSize = 5;
            this.btn3.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(151, 185);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 48);
            this.btn3.TabIndex = 34;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gold;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn2.FlatAppearance.BorderSize = 5;
            this.btn2.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(96, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 48);
            this.btn2.TabIndex = 33;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gold;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn1.FlatAppearance.BorderSize = 5;
            this.btn1.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(41, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 48);
            this.btn1.TabIndex = 32;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gold;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn6.FlatAppearance.BorderSize = 5;
            this.btn6.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(151, 130);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 48);
            this.btn6.TabIndex = 31;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gold;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn5.FlatAppearance.BorderSize = 5;
            this.btn5.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(96, 130);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 48);
            this.btn5.TabIndex = 30;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gold;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn4.FlatAppearance.BorderSize = 5;
            this.btn4.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(41, 130);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 48);
            this.btn4.TabIndex = 29;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gold;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn9.FlatAppearance.BorderSize = 5;
            this.btn9.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(151, 76);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 48);
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gold;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn8.FlatAppearance.BorderSize = 5;
            this.btn8.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(96, 76);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 48);
            this.btn8.TabIndex = 27;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gold;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn7.FlatAppearance.BorderSize = 5;
            this.btn7.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(41, 76);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 48);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btnAdisyonKapat
            // 
            this.btnAdisyonKapat.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdisyonKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdisyonKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyonKapat.Location = new System.Drawing.Point(953, 584);
            this.btnAdisyonKapat.Name = "btnAdisyonKapat";
            this.btnAdisyonKapat.Size = new System.Drawing.Size(200, 64);
            this.btnAdisyonKapat.TabIndex = 15;
            this.btnAdisyonKapat.Text = "Adisyonu Kapat";
            this.btnAdisyonKapat.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOdemeAl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOdemeAl.FlatAppearance.BorderSize = 3;
            this.btnOdemeAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.Location = new System.Drawing.Point(747, 584);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(200, 64);
            this.btnOdemeAl.TabIndex = 14;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(828, 546);
            this.txtBakiye.Multiline = true;
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(325, 36);
            this.txtBakiye.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(737, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bakiye";
            // 
            // gbMasaSiparis
            // 
            this.gbMasaSiparis.BackColor = System.Drawing.Color.LightGray;
            this.gbMasaSiparis.Controls.Add(this.dataGridView1);
            this.gbMasaSiparis.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMasaSiparis.ForeColor = System.Drawing.Color.White;
            this.gbMasaSiparis.Location = new System.Drawing.Point(743, 12);
            this.gbMasaSiparis.Name = "gbMasaSiparis";
            this.gbMasaSiparis.Size = new System.Drawing.Size(410, 530);
            this.gbMasaSiparis.TabIndex = 11;
            this.gbMasaSiparis.TabStop = false;
            this.gbMasaSiparis.Text = "Masa Sipariş";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 485);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPersonelNo,
            this.toolStripSeparator3,
            this.tsKullaniciAdi,
            this.toolStripSeparator1,
            this.tsTarih,
            this.tsMesaj,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 658);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsPersonelNo
            // 
            this.tsPersonelNo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsPersonelNo.Name = "tsPersonelNo";
            this.tsPersonelNo.Size = new System.Drawing.Size(0, 22);
            this.tsPersonelNo.Visible = false;
            // 
            // tsKullaniciAdi
            // 
            this.tsKullaniciAdi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsKullaniciAdi.Name = "tsKullaniciAdi";
            this.tsKullaniciAdi.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsMesaj
            // 
            this.tsMesaj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsMesaj.Name = "tsMesaj";
            this.tsMesaj.Size = new System.Drawing.Size(104, 22);
            this.tsMesaj.Text = "Sipariş Tanımlama";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsTarih
            // 
            this.tsTarih.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTarih.Name = "tsTarih";
            this.tsTarih.Size = new System.Drawing.Size(61, 22);
            this.tsTarih.Text = "09.03.2015";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1164, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAdisyonKapat);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMasaSiparis);
            this.Controls.Add(this.grbAdet);
            this.Controls.Add(this.btnTatlilar);
            this.Controls.Add(this.brnİcecek);
            this.Controls.Add(this.btnSalatalar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grbMenuler);
            this.Controls.Add(this.btnCorbalar);
            this.Controls.Add(this.btnAnaYemek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSiparis";
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMenuler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuler)).EndInit();
            this.grbAdet.ResumeLayout(false);
            this.grbAdet.PerformLayout();
            this.gbMasaSiparis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaYemek;
        private System.Windows.Forms.ImageList imliconlar;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.Button brnİcecek;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grbMenuler;
        private System.Windows.Forms.GroupBox grbAdet;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnAdisyonKapat;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMasaSiparis;
        private System.Windows.Forms.DataGridView dgvMenuler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsPersonelNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsKullaniciAdi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsTarih;
        private System.Windows.Forms.ToolStripLabel tsMesaj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

