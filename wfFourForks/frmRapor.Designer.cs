namespace wfFourForks
{
    partial class frmRapor
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
            this.rbGunluk = new System.Windows.Forms.RadioButton();
            this.rbTarih = new System.Windows.Forms.RadioButton();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.btnRapor = new System.Windows.Forms.Button();
            this.cbOdeme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // rbGunluk
            // 
            this.rbGunluk.AutoSize = true;
            this.rbGunluk.Checked = true;
            this.rbGunluk.Location = new System.Drawing.Point(39, 12);
            this.rbGunluk.Name = "rbGunluk";
            this.rbGunluk.Size = new System.Drawing.Size(91, 17);
            this.rbGunluk.TabIndex = 0;
            this.rbGunluk.TabStop = true;
            this.rbGunluk.Text = "Günlük Rapor";
            this.rbGunluk.UseVisualStyleBackColor = true;
            this.rbGunluk.CheckedChanged += new System.EventHandler(this.rbGunluk_CheckedChanged);
            // 
            // rbTarih
            // 
            this.rbTarih.AutoSize = true;
            this.rbTarih.Location = new System.Drawing.Point(255, 12);
            this.rbTarih.Name = "rbTarih";
            this.rbTarih.Size = new System.Drawing.Size(89, 17);
            this.rbTarih.TabIndex = 1;
            this.rbTarih.Text = "Detaylı Rapor";
            this.rbTarih.UseVisualStyleBackColor = true;
            this.rbTarih.CheckedChanged += new System.EventHandler(this.rbTarih_CheckedChanged);
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(13, 45);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(176, 20);
            this.dtpIlkTarih.TabIndex = 2;
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(231, 45);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(168, 20);
            this.dtpSonTarih.TabIndex = 3;
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Location = new System.Drawing.Point(13, 163);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.Size = new System.Drawing.Size(439, 340);
            this.dgvRapor.TabIndex = 4;
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(168, 134);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(88, 23);
            this.btnRapor.TabIndex = 5;
            this.btnRapor.Text = "RAPORLA";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // cbOdeme
            // 
            this.cbOdeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdeme.FormattingEnabled = true;
            this.cbOdeme.Items.AddRange(new object[] {
            "Tümü",
            "Nakit",
            "Kredi Kartı",
            "Yemek Çeki"});
            this.cbOdeme.Location = new System.Drawing.Point(151, 80);
            this.cbOdeme.Name = "cbOdeme";
            this.cbOdeme.Size = new System.Drawing.Size(120, 21);
            this.cbOdeme.TabIndex = 6;
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 509);
            this.Controls.Add(this.cbOdeme);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.dtpIlkTarih);
            this.Controls.Add(this.rbTarih);
            this.Controls.Add(this.rbGunluk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRapor";
            this.Text = "   Raporlama";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbGunluk;
        private System.Windows.Forms.RadioButton rbTarih;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.ComboBox cbOdeme;
    }
}