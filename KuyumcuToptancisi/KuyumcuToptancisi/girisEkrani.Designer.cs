namespace KuyumcuToptancisi
{
    partial class girisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkrani));
            this.girisButonu = new System.Windows.Forms.Button();
            this.sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girisButonu
            // 
            this.girisButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.girisButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisButonu.BackgroundImage")));
            this.girisButonu.FlatAppearance.BorderSize = 0;
            this.girisButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButonu.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.girisButonu.ForeColor = System.Drawing.Color.White;
            this.girisButonu.Location = new System.Drawing.Point(408, 459);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(165, 47);
            this.girisButonu.TabIndex = 0;
            this.girisButonu.Text = "GİRİŞ";
            this.girisButonu.UseVisualStyleBackColor = false;
            this.girisButonu.Click += new System.EventHandler(this.girisButonu_Click);
            // 
            // sifremiUnuttum
            // 
            this.sifremiUnuttum.AutoSize = true;
            this.sifremiUnuttum.LinkColor = System.Drawing.Color.DodgerBlue;
            this.sifremiUnuttum.Location = new System.Drawing.Point(450, 509);
            this.sifremiUnuttum.Name = "sifremiUnuttum";
            this.sifremiUnuttum.Size = new System.Drawing.Size(81, 13);
            this.sifremiUnuttum.TabIndex = 3;
            this.sifremiUnuttum.TabStop = true;
            this.sifremiUnuttum.Text = "Şifremi Unuttum";
            this.sifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifremiUnuttum_LinkClicked);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciAdi.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F);
            this.kullaniciAdi.ForeColor = System.Drawing.Color.Gray;
            this.kullaniciAdi.Location = new System.Drawing.Point(333, 337);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(324, 29);
            this.kullaniciAdi.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.AccessibleDescription = "";
            this.sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifre.CausesValidation = false;
            this.sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 17F);
            this.sifre.ForeColor = System.Drawing.Color.Gray;
            this.sifre.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sifre.Location = new System.Drawing.Point(333, 412);
            this.sifre.MaxLength = 50;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(324, 28);
            this.sifre.TabIndex = 2;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // girisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.sifremiUnuttum);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.girisButonu);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "girisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hoşgeldiniz";
            this.Load += new System.EventHandler(this.girisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button girisButonu;
        public System.Windows.Forms.LinkLabel sifremiUnuttum;
        public System.Windows.Forms.TextBox kullaniciAdi;
        public System.Windows.Forms.TextBox sifre;
    }
}