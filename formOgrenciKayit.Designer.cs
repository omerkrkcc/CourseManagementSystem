
namespace DersYonetimSistemi
{
    partial class formOgrenciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgrenciKayit));
            this.dataGridEkle = new System.Windows.Forms.DataGridView();
            this.btnDersKayitEkranı = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnHastaListele = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.txtAdresBilgisi = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtOgrenciEposta = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOgretmenSoyadi = new System.Windows.Forms.Label();
            this.lblOgretmenAdi = new System.Windows.Forms.Label();
            this.lblDersAkts = new System.Windows.Forms.Label();
            this.lblDersKredi = new System.Windows.Forms.Label();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.lblDersKodu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDKapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEkle)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEkle
            // 
            this.dataGridEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEkle.Location = new System.Drawing.Point(873, 78);
            this.dataGridEkle.Name = "dataGridEkle";
            this.dataGridEkle.RowHeadersWidth = 51;
            this.dataGridEkle.RowTemplate.Height = 24;
            this.dataGridEkle.Size = new System.Drawing.Size(673, 475);
            this.dataGridEkle.TabIndex = 72;
            // 
            // btnDersKayitEkranı
            // 
            this.btnDersKayitEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDersKayitEkranı.ForeColor = System.Drawing.Color.White;
            this.btnDersKayitEkranı.Location = new System.Drawing.Point(950, 607);
            this.btnDersKayitEkranı.Name = "btnDersKayitEkranı";
            this.btnDersKayitEkranı.Size = new System.Drawing.Size(302, 37);
            this.btnDersKayitEkranı.TabIndex = 70;
            this.btnDersKayitEkranı.Text = "Ders Kayıt Ekranı";
            this.btnDersKayitEkranı.UseVisualStyleBackColor = false;
            this.btnDersKayitEkranı.Click += new System.EventHandler(this.btnDersKayitEkranı_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnGeriDon.Location = new System.Drawing.Point(1282, 607);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(290, 37);
            this.btnGeriDon.TabIndex = 69;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnHastaListele
            // 
            this.btnHastaListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHastaListele.ForeColor = System.Drawing.Color.White;
            this.btnHastaListele.Location = new System.Drawing.Point(603, 607);
            this.btnHastaListele.Name = "btnHastaListele";
            this.btnHastaListele.Size = new System.Drawing.Size(302, 37);
            this.btnHastaListele.TabIndex = 68;
            this.btnHastaListele.Text = "Ogrenci Listele";
            this.btnHastaListele.UseVisualStyleBackColor = false;
            this.btnHastaListele.Click += new System.EventHandler(this.btnHastaListele_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOgrenciEkle.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(194, 607);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(302, 37);
            this.btnOgrenciEkle.TabIndex = 71;
            this.btnOgrenciEkle.Text = "Ogrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // txtAdresBilgisi
            // 
            this.txtAdresBilgisi.Location = new System.Drawing.Point(357, 491);
            this.txtAdresBilgisi.Name = "txtAdresBilgisi";
            this.txtAdresBilgisi.Size = new System.Drawing.Size(326, 22);
            this.txtAdresBilgisi.TabIndex = 64;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(357, 444);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(166, 22);
            this.txtTelefonNo.TabIndex = 65;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(352, 371);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(166, 22);
            this.txtDogumTarihi.TabIndex = 63;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(352, 308);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(166, 22);
            this.txtDogumYeri.TabIndex = 62;
            // 
            // txtOgrenciEposta
            // 
            this.txtOgrenciEposta.Location = new System.Drawing.Point(352, 255);
            this.txtOgrenciEposta.Name = "txtOgrenciEposta";
            this.txtOgrenciEposta.Size = new System.Drawing.Size(166, 22);
            this.txtOgrenciEposta.TabIndex = 61;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(352, 191);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(166, 22);
            this.txtOgrenciSoyadi.TabIndex = 67;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(352, 132);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(166, 22);
            this.txtOgrenciAdi.TabIndex = 60;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(352, 78);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(166, 22);
            this.txtOgrenciNo.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "Telefon Numarası";
            // 
            // lblOgretmenSoyadi
            // 
            this.lblOgretmenSoyadi.AutoSize = true;
            this.lblOgretmenSoyadi.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgretmenSoyadi.Location = new System.Drawing.Point(139, 371);
            this.lblOgretmenSoyadi.Name = "lblOgretmenSoyadi";
            this.lblOgretmenSoyadi.Size = new System.Drawing.Size(180, 23);
            this.lblOgretmenSoyadi.TabIndex = 54;
            this.lblOgretmenSoyadi.Text = "Öğrenci Doğum Tarihi";
            // 
            // lblOgretmenAdi
            // 
            this.lblOgretmenAdi.AutoSize = true;
            this.lblOgretmenAdi.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgretmenAdi.Location = new System.Drawing.Point(139, 308);
            this.lblOgretmenAdi.Name = "lblOgretmenAdi";
            this.lblOgretmenAdi.Size = new System.Drawing.Size(163, 23);
            this.lblOgretmenAdi.TabIndex = 53;
            this.lblOgretmenAdi.Text = "Öğrenci Doğum Yeri";
            // 
            // lblDersAkts
            // 
            this.lblDersAkts.AutoSize = true;
            this.lblDersAkts.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersAkts.Location = new System.Drawing.Point(139, 255);
            this.lblDersAkts.Name = "lblDersAkts";
            this.lblDersAkts.Size = new System.Drawing.Size(126, 23);
            this.lblDersAkts.TabIndex = 52;
            this.lblDersAkts.Text = "Öğrenci Eposta";
            // 
            // lblDersKredi
            // 
            this.lblDersKredi.AutoSize = true;
            this.lblDersKredi.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersKredi.Location = new System.Drawing.Point(139, 191);
            this.lblDersKredi.Name = "lblDersKredi";
            this.lblDersKredi.Size = new System.Drawing.Size(126, 23);
            this.lblDersKredi.TabIndex = 51;
            this.lblDersKredi.Text = "Öğrenci Soyadı";
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersAdi.Location = new System.Drawing.Point(140, 132);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(101, 23);
            this.lblDersAdi.TabIndex = 58;
            this.lblDersAdi.Text = "Öğrenci Adı";
            // 
            // lblDersKodu
            // 
            this.lblDersKodu.AutoSize = true;
            this.lblDersKodu.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersKodu.Location = new System.Drawing.Point(140, 78);
            this.lblDersKodu.Name = "lblDersKodu";
            this.lblDersKodu.Size = new System.Drawing.Size(151, 23);
            this.lblDersKodu.TabIndex = 50;
            this.lblDersKodu.Text = "Öğrenci Numarası";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 659);
            this.panel2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 348);
            this.label1.TabIndex = 0;
            this.label1.Text = "D\r\nE\r\nR\r\nS\r\n\r\nS\r\n İ\r\nS\r\nT\r\nE\r\nM\r\n İ\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 50);
            this.panel1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(699, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ogrenci Ekleme Formu";
            // 
            // btnDKapat
            // 
            this.btnDKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDKapat.BackgroundImage")));
            this.btnDKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDKapat.FlatAppearance.BorderSize = 0;
            this.btnDKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDKapat.ForeColor = System.Drawing.Color.White;
            this.btnDKapat.Location = new System.Drawing.Point(1538, 0);
            this.btnDKapat.Name = "btnDKapat";
            this.btnDKapat.Size = new System.Drawing.Size(46, 50);
            this.btnDKapat.TabIndex = 0;
            this.btnDKapat.UseVisualStyleBackColor = false;
            this.btnDKapat.Click += new System.EventHandler(this.btnDKapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // formOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1584, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridEkle);
            this.Controls.Add(this.btnDersKayitEkranı);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnHastaListele);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.txtAdresBilgisi);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtOgrenciEposta);
            this.Controls.Add(this.txtOgrenciSoyadi);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOgretmenSoyadi);
            this.Controls.Add(this.lblOgretmenAdi);
            this.Controls.Add(this.lblDersAkts);
            this.Controls.Add(this.lblDersKredi);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.lblDersKodu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOgrenciKayit";
            this.Text = "formOgrenciKayit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEkle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridEkle;
        private System.Windows.Forms.Button btnDersKayitEkranı;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnHastaListele;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtAdresBilgisi;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtOgrenciEposta;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOgretmenSoyadi;
        private System.Windows.Forms.Label lblOgretmenAdi;
        private System.Windows.Forms.Label lblDersAkts;
        private System.Windows.Forms.Label lblDersKredi;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblDersKodu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDKapat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}