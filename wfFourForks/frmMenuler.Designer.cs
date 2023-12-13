namespace wfFourForks
{
    partial class frmMenuler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnYonetim = new System.Windows.Forms.Button();
            this.btnMasalar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKasa = new System.Windows.Forms.Button();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsPersonelNo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKullaniciAdi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTarih = new System.Windows.Forms.ToolStripLabel();
            this.tsMesaj = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(224, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Masalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(598, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yönetim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(596, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yönetim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(970, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Raporlar";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Image = global::wfFourForks.Properties.Resources.StatusAnnotations_Critical_32xLG_color;
            this.btnLogout.Location = new System.Drawing.Point(1215, 469);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(71, 63);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.Image = global::wfFourForks.Properties.Resources.reports;
            this.btnRaporlar.Location = new System.Drawing.Point(850, 25);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(352, 212);
            this.btnRaporlar.TabIndex = 2;
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnYonetim
            // 
            this.btnYonetim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetim.Image = global::wfFourForks.Properties.Resources.yonetim_admin_kontrol;
            this.btnYonetim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYonetim.Location = new System.Drawing.Point(474, 25);
            this.btnYonetim.Name = "btnYonetim";
            this.btnYonetim.Size = new System.Drawing.Size(352, 212);
            this.btnYonetim.TabIndex = 1;
            this.btnYonetim.UseVisualStyleBackColor = true;
            this.btnYonetim.Click += new System.EventHandler(this.btnYonetim_Click);
            // 
            // btnMasalar
            // 
            this.btnMasalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasalar.Image = global::wfFourForks.Properties.Resources.musteri;
            this.btnMasalar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMasalar.Location = new System.Drawing.Point(97, 25);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(352, 212);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMasalar.UseVisualStyleBackColor = true;
            this.btnMasalar.Click += new System.EventHandler(this.btnMasalar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(254, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kasa";
            // 
            // btnKasa
            // 
            this.btnKasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.Image = global::wfFourForks.Properties.Resources.backup_vault;
            this.btnKasa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKasa.Location = new System.Drawing.Point(97, 295);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(352, 222);
            this.btnKasa.TabIndex = 3;
            this.btnKasa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKasa.UseVisualStyleBackColor = true;
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPersonelNo,
            this.toolStripSeparator3,
            this.tsKullaniciAdi,
            this.toolStripSeparator1,
            this.tsTarih,
            this.tsMesaj,
            this.toolStripSeparator2});
            this.tsMenu.Location = new System.Drawing.Point(0, 544);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1276, 25);
            this.tsMenu.TabIndex = 18;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsPersonelNo
            // 
            this.tsPersonelNo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsPersonelNo.Name = "tsPersonelNo";
            this.tsPersonelNo.Size = new System.Drawing.Size(0, 22);
            this.tsPersonelNo.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsKullaniciAdi
            // 
            this.tsKullaniciAdi.Name = "tsKullaniciAdi";
            this.tsKullaniciAdi.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsTarih
            // 
            this.tsTarih.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTarih.Name = "tsTarih";
            this.tsTarih.Size = new System.Drawing.Size(61, 22);
            this.tsTarih.Text = "09.03.2015";
            // 
            // tsMesaj
            // 
            this.tsMesaj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsMesaj.Name = "tsMesaj";
            this.tsMesaj.Size = new System.Drawing.Size(51, 22);
            this.tsMesaj.Text = "Menüler";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMenuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 569);
            this.ControlBox = false;
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnYonetim);
            this.Controls.Add(this.btnMasalar);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMenuler";
            this.Text = "Four Forks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuler_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnYonetim;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripLabel tsPersonelNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsKullaniciAdi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsTarih;
        private System.Windows.Forms.ToolStripLabel tsMesaj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}