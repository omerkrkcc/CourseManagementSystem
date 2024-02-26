
namespace DersYonetimSistemi
{
    partial class formDersGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDersGuncelle));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDKapat = new System.Windows.Forms.Button();
            this.cmbDonem = new System.Windows.Forms.ComboBox();
            this.txtHarfNotu = new System.Windows.Forms.TextBox();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.txtYeniDersKodu = new System.Windows.Forms.TextBox();
            this.txtGuncellenecekKod = new System.Windows.Forms.TextBox();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.lblDersDonemi = new System.Windows.Forms.Label();
            this.lblGnclDersKodu = new System.Windows.Forms.Label();
            this.lblDersKredi = new System.Windows.Forms.Label();
            this.lblYeniDersKodu = new System.Windows.Forms.Label();
            this.btnDersIptal = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnVerileriGetir = new System.Windows.Forms.Button();
            this.txtKoduGetir = new System.Windows.Forms.TextBox();
            this.lblDersGuncelle = new System.Windows.Forms.Label();
            this.dataGridGuncelle = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKayitNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDersNo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(199)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 583);
            this.panel2.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(199)))), ((int)(((byte)(144)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 203);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ö\r\nĞ\r\nR\r\nE\r\nN\r\nC \r\n İ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(199)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 42);
            this.panel1.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(606, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ders Güncelleme Formu";
            // 
            // btnDKapat
            // 
            this.btnDKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(199)))), ((int)(((byte)(144)))));
            this.btnDKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDKapat.BackgroundImage")));
            this.btnDKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDKapat.FlatAppearance.BorderSize = 0;
            this.btnDKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDKapat.Location = new System.Drawing.Point(1399, 0);
            this.btnDKapat.Name = "btnDKapat";
            this.btnDKapat.Size = new System.Drawing.Size(46, 42);
            this.btnDKapat.TabIndex = 0;
            this.btnDKapat.UseVisualStyleBackColor = false;
            this.btnDKapat.Click += new System.EventHandler(this.btnDKapat_Click);
            // 
            // cmbDonem
            // 
            this.cmbDonem.FormattingEnabled = true;
            this.cmbDonem.Location = new System.Drawing.Point(447, 416);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Size = new System.Drawing.Size(148, 24);
            this.cmbDonem.TabIndex = 72;
            // 
            // txtHarfNotu
            // 
            this.txtHarfNotu.Location = new System.Drawing.Point(447, 471);
            this.txtHarfNotu.Name = "txtHarfNotu";
            this.txtHarfNotu.Size = new System.Drawing.Size(148, 22);
            this.txtHarfNotu.TabIndex = 64;
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(445, 365);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(148, 22);
            this.txtDersKredi.TabIndex = 68;
            // 
            // txtYeniDersKodu
            // 
            this.txtYeniDersKodu.Location = new System.Drawing.Point(448, 300);
            this.txtYeniDersKodu.Name = "txtYeniDersKodu";
            this.txtYeniDersKodu.Size = new System.Drawing.Size(148, 22);
            this.txtYeniDersKodu.TabIndex = 69;
            // 
            // txtGuncellenecekKod
            // 
            this.txtGuncellenecekKod.Location = new System.Drawing.Point(991, 521);
            this.txtGuncellenecekKod.Name = "txtGuncellenecekKod";
            this.txtGuncellenecekKod.Size = new System.Drawing.Size(148, 22);
            this.txtGuncellenecekKod.TabIndex = 70;
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarfNotu.Location = new System.Drawing.Point(188, 467);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(142, 26);
            this.lblHarfNotu.TabIndex = 55;
            this.lblHarfNotu.Text = "Ders Harf Notu";
            // 
            // lblDersDonemi
            // 
            this.lblDersDonemi.AutoSize = true;
            this.lblDersDonemi.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersDonemi.Location = new System.Drawing.Point(188, 416);
            this.lblDersDonemi.Name = "lblDersDonemi";
            this.lblDersDonemi.Size = new System.Drawing.Size(123, 26);
            this.lblDersDonemi.TabIndex = 56;
            this.lblDersDonemi.Text = "Ders Dönemi";
            // 
            // lblGnclDersKodu
            // 
            this.lblGnclDersKodu.AutoSize = true;
            this.lblGnclDersKodu.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGnclDersKodu.Location = new System.Drawing.Point(642, 521);
            this.lblGnclDersKodu.Name = "lblGnclDersKodu";
            this.lblGnclDersKodu.Size = new System.Drawing.Size(309, 26);
            this.lblGnclDersKodu.TabIndex = 61;
            this.lblGnclDersKodu.Text = "Güncellenecek Ders Kodunu Giriniz";
            // 
            // lblDersKredi
            // 
            this.lblDersKredi.AutoSize = true;
            this.lblDersKredi.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersKredi.Location = new System.Drawing.Point(188, 361);
            this.lblDersKredi.Name = "lblDersKredi";
            this.lblDersKredi.Size = new System.Drawing.Size(101, 26);
            this.lblDersKredi.TabIndex = 60;
            this.lblDersKredi.Text = "Ders Kredi";
            // 
            // lblYeniDersKodu
            // 
            this.lblYeniDersKodu.AutoSize = true;
            this.lblYeniDersKodu.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYeniDersKodu.Location = new System.Drawing.Point(188, 300);
            this.lblYeniDersKodu.Name = "lblYeniDersKodu";
            this.lblYeniDersKodu.Size = new System.Drawing.Size(143, 26);
            this.lblYeniDersKodu.TabIndex = 62;
            this.lblYeniDersKodu.Text = "Yeni Ders Kodu";
            // 
            // btnDersIptal
            // 
            this.btnDersIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
            this.btnDersIptal.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnDersIptal.Location = new System.Drawing.Point(912, 554);
            this.btnDersIptal.Name = "btnDersIptal";
            this.btnDersIptal.Size = new System.Drawing.Size(332, 35);
            this.btnDersIptal.TabIndex = 54;
            this.btnDersIptal.Text = "İptal";
            this.btnDersIptal.UseVisualStyleBackColor = false;
            this.btnDersIptal.Click += new System.EventHandler(this.btnDersIptal_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
            this.btnDersGuncelle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnDersGuncelle.Location = new System.Drawing.Point(424, 555);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(332, 35);
            this.btnDersGuncelle.TabIndex = 53;
            this.btnDersGuncelle.Text = "Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = false;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnVerileriGetir
            // 
            this.btnVerileriGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
            this.btnVerileriGetir.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnVerileriGetir.Location = new System.Drawing.Point(294, 76);
            this.btnVerileriGetir.Name = "btnVerileriGetir";
            this.btnVerileriGetir.Size = new System.Drawing.Size(160, 26);
            this.btnVerileriGetir.TabIndex = 52;
            this.btnVerileriGetir.Text = "Verileri Getir";
            this.btnVerileriGetir.UseVisualStyleBackColor = false;
            this.btnVerileriGetir.Click += new System.EventHandler(this.btnVerileriGetir_Click);
            // 
            // txtKoduGetir
            // 
            this.txtKoduGetir.Location = new System.Drawing.Point(423, 48);
            this.txtKoduGetir.Name = "txtKoduGetir";
            this.txtKoduGetir.Size = new System.Drawing.Size(160, 22);
            this.txtKoduGetir.TabIndex = 51;
            // 
            // lblDersGuncelle
            // 
            this.lblDersGuncelle.AutoSize = true;
            this.lblDersGuncelle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersGuncelle.Location = new System.Drawing.Point(202, 48);
            this.lblDersGuncelle.Name = "lblDersGuncelle";
            this.lblDersGuncelle.Size = new System.Drawing.Size(193, 26);
            this.lblDersGuncelle.TabIndex = 50;
            this.lblDersGuncelle.Text = "Getirilecek Ders Kodu";
            // 
            // dataGridGuncelle
            // 
            this.dataGridGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGuncelle.Location = new System.Drawing.Point(647, 48);
            this.dataGridGuncelle.Name = "dataGridGuncelle";
            this.dataGridGuncelle.RowHeadersWidth = 51;
            this.dataGridGuncelle.RowTemplate.Height = 24;
            this.dataGridGuncelle.Size = new System.Drawing.Size(761, 439);
            this.dataGridGuncelle.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 62;
            this.label3.Text = "Öğrenci Numarası";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(448, 177);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(148, 22);
            this.txtOgrenciNo.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 62;
            this.label4.Text = "Yeni Kayıt Numarası";
            // 
            // txtKayitNo
            // 
            this.txtKayitNo.Location = new System.Drawing.Point(448, 121);
            this.txtKayitNo.Name = "txtKayitNo";
            this.txtKayitNo.Size = new System.Drawing.Size(148, 22);
            this.txtKayitNo.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ders Numarası";
            // 
            // txtDersNo
            // 
            this.txtDersNo.Location = new System.Drawing.Point(445, 239);
            this.txtDersNo.Name = "txtDersNo";
            this.txtDersNo.Size = new System.Drawing.Size(148, 22);
            this.txtDersNo.TabIndex = 69;
            // 
            // formDersGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1445, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbDonem);
            this.Controls.Add(this.txtHarfNotu);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.txtKayitNo);
            this.Controls.Add(this.txtDersNo);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.txtYeniDersKodu);
            this.Controls.Add(this.txtGuncellenecekKod);
            this.Controls.Add(this.lblHarfNotu);
            this.Controls.Add(this.lblDersDonemi);
            this.Controls.Add(this.lblGnclDersKodu);
            this.Controls.Add(this.lblDersKredi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYeniDersKodu);
            this.Controls.Add(this.btnDersIptal);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnVerileriGetir);
            this.Controls.Add(this.txtKoduGetir);
            this.Controls.Add(this.lblDersGuncelle);
            this.Controls.Add(this.dataGridGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDersGuncelle";
            this.Text = "formDersGuncelle";
            this.Load += new System.EventHandler(this.formDersGuncelle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGuncelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDKapat;
        private System.Windows.Forms.ComboBox cmbDonem;
        private System.Windows.Forms.TextBox txtHarfNotu;
        private System.Windows.Forms.TextBox txtDersKredi;
        private System.Windows.Forms.TextBox txtYeniDersKodu;
        private System.Windows.Forms.TextBox txtGuncellenecekKod;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.Label lblDersDonemi;
        private System.Windows.Forms.Label lblGnclDersKodu;
        private System.Windows.Forms.Label lblDersKredi;
        private System.Windows.Forms.Label lblYeniDersKodu;
        private System.Windows.Forms.Button btnDersIptal;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnVerileriGetir;
        private System.Windows.Forms.TextBox txtKoduGetir;
        private System.Windows.Forms.Label lblDersGuncelle;
        private System.Windows.Forms.DataGridView dataGridGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKayitNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDersNo;
    }
}