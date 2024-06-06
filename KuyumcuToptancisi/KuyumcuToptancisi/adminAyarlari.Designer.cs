namespace KuyumcuToptancisi
{
    partial class adminAyarlari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminAyarlari));
            this.adminSil = new System.Windows.Forms.Button();
            this.adminEkle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.dbOtomasyonDataSet1 = new KuyumcuToptancisi.dbOtomasyonDataSet();
            this.adminler = new System.Windows.Forms.DataGridView();
            this.yenile = new System.Windows.Forms.Button();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.LBmusteriAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telno = new System.Windows.Forms.TextBox();
            this.geriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminler)).BeginInit();
            this.SuspendLayout();
            // 
            // adminSil
            // 
            this.adminSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.adminSil.FlatAppearance.BorderSize = 0;
            this.adminSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminSil.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.adminSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminSil.Location = new System.Drawing.Point(660, 463);
            this.adminSil.Name = "adminSil";
            this.adminSil.Size = new System.Drawing.Size(275, 59);
            this.adminSil.TabIndex = 116;
            this.adminSil.Text = "Admin Sil";
            this.adminSil.UseVisualStyleBackColor = false;
            this.adminSil.Click += new System.EventHandler(this.adminSil_Click_1);
            // 
            // adminEkle
            // 
            this.adminEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.adminEkle.FlatAppearance.BorderSize = 0;
            this.adminEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminEkle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.adminEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminEkle.Location = new System.Drawing.Point(661, 398);
            this.adminEkle.Name = "adminEkle";
            this.adminEkle.Size = new System.Drawing.Size(274, 59);
            this.adminEkle.TabIndex = 115;
            this.adminEkle.Text = "Admin Ekle";
            this.adminEkle.UseVisualStyleBackColor = false;
            this.adminEkle.Click += new System.EventHandler(this.adminEkle_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.guncelle.FlatAppearance.BorderSize = 0;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guncelle.Location = new System.Drawing.Point(661, 528);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(131, 47);
            this.guncelle.TabIndex = 117;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click_1);
            // 
            // dbOtomasyonDataSet1
            // 
            this.dbOtomasyonDataSet1.DataSetName = "dbOtomasyonDataSet";
            this.dbOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminler
            // 
            this.adminler.AllowUserToAddRows = false;
            this.adminler.AllowUserToDeleteRows = false;
            this.adminler.AllowUserToResizeColumns = false;
            this.adminler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adminler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.adminler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.adminler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adminler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminler.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminler.EnableHeadersVisualStyles = false;
            this.adminler.Location = new System.Drawing.Point(27, 60);
            this.adminler.MultiSelect = false;
            this.adminler.Name = "adminler";
            this.adminler.ReadOnly = true;
            this.adminler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.adminler.RowHeadersVisible = false;
            this.adminler.RowHeadersWidth = 40;
            this.adminler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminler.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.adminler.RowTemplate.Height = 50;
            this.adminler.RowTemplate.ReadOnly = true;
            this.adminler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adminler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminler.Size = new System.Drawing.Size(555, 358);
            this.adminler.TabIndex = 118;
            this.adminler.SelectionChanged += new System.EventHandler(this.adminler_SelectionChanged);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.yenile.FlatAppearance.BorderSize = 0;
            this.yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yenile.Location = new System.Drawing.Point(804, 528);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(131, 47);
            this.yenile.TabIndex = 119;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciAdi.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F);
            this.kullaniciAdi.Location = new System.Drawing.Point(661, 149);
            this.kullaniciAdi.Multiline = true;
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(274, 31);
            this.kullaniciAdi.TabIndex = 120;
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifre.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F);
            this.sifre.Location = new System.Drawing.Point(661, 238);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(274, 31);
            this.sifre.TabIndex = 121;
            // 
            // LBmusteriAd
            // 
            this.LBmusteriAd.AutoSize = true;
            this.LBmusteriAd.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Bold);
            this.LBmusteriAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.LBmusteriAd.Location = new System.Drawing.Point(684, 105);
            this.LBmusteriAd.Name = "LBmusteriAd";
            this.LBmusteriAd.Size = new System.Drawing.Size(209, 41);
            this.LBmusteriAd.TabIndex = 122;
            this.LBmusteriAd.Text = "Kullanıcı Adı";
            this.LBmusteriAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(745, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 41);
            this.label1.TabIndex = 123;
            this.label1.Text = "Şifre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(745, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 41);
            this.label2.TabIndex = 125;
            this.label2.Text = "Tel No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telno
            // 
            this.telno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.telno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telno.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F);
            this.telno.Location = new System.Drawing.Point(661, 330);
            this.telno.Multiline = true;
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(274, 31);
            this.telno.TabIndex = 124;
            // 
            // geriDon
            // 
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriDon.BackgroundImage")));
            this.geriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geriDon.FlatAppearance.BorderSize = 0;
            this.geriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDon.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold);
            this.geriDon.ForeColor = System.Drawing.Color.White;
            this.geriDon.Location = new System.Drawing.Point(12, 12);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(31, 31);
            this.geriDon.TabIndex = 126;
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // adminAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBmusteriAd);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.adminler);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.adminSil);
            this.Controls.Add(this.adminEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "adminAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ayarları";
            this.Load += new System.EventHandler(this.adminAyarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminSil;
        private System.Windows.Forms.Button adminEkle;
        private System.Windows.Forms.Button guncelle;
        private dbOtomasyonDataSet dbOtomasyonDataSet1;
        public System.Windows.Forms.DataGridView adminler;
        private System.Windows.Forms.Button yenile;
        public System.Windows.Forms.TextBox kullaniciAdi;
        public System.Windows.Forms.TextBox sifre;
        public System.Windows.Forms.Label LBmusteriAd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox telno;
        public System.Windows.Forms.Button geriDon;
    }
}