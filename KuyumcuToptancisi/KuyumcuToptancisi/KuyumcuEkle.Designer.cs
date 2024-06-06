namespace KuyumcuToptancisi
{
    partial class KuyumcuEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuyumcuEkle));
            this.dukkanAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dukkanSehir = new System.Windows.Forms.TextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dukkanAd
            // 
            this.dukkanAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dukkanAd.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F);
            this.dukkanAd.Location = new System.Drawing.Point(181, 129);
            this.dukkanAd.Name = "dukkanAd";
            this.dukkanAd.Size = new System.Drawing.Size(235, 40);
            this.dukkanAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F);
            this.label1.Location = new System.Drawing.Point(29, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dükkan Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F);
            this.label3.Location = new System.Drawing.Point(93, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şehir :";
            // 
            // dukkanSehir
            // 
            this.dukkanSehir.BackColor = System.Drawing.Color.White;
            this.dukkanSehir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dukkanSehir.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20F);
            this.dukkanSehir.ForeColor = System.Drawing.Color.Black;
            this.dukkanSehir.Location = new System.Drawing.Point(181, 175);
            this.dukkanSehir.Name = "dukkanSehir";
            this.dukkanSehir.Size = new System.Drawing.Size(235, 40);
            this.dukkanSehir.TabIndex = 4;
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.Kaydet.FlatAppearance.BorderSize = 0;
            this.Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kaydet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20F, System.Drawing.FontStyle.Bold);
            this.Kaydet.ForeColor = System.Drawing.Color.White;
            this.Kaydet.Location = new System.Drawing.Point(227, 221);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(137, 47);
            this.Kaydet.TabIndex = 86;
            this.Kaydet.Text = "KAYDET";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // KuyumcuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.dukkanSehir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dukkanAd);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KuyumcuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox dukkanAd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox dukkanSehir;
        public System.Windows.Forms.Button Kaydet;
    }
}