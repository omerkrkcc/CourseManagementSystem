
namespace DersYonetimSistemi
{
    partial class formHocaSınıf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHocaSınıf));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDKapat = new System.Windows.Forms.Button();
            this.listViewGano = new System.Windows.Forms.ListView();
            this.listViewToplamKredi = new System.Windows.Forms.ListView();
            this.btnDersListele = new System.Windows.Forms.Button();
            this.lblGano = new System.Windows.Forms.Label();
            this.lblKredi = new System.Windows.Forms.Label();
            this.dataGridListele = new System.Windows.Forms.DataGridView();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 497);
            this.panel2.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(119)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 203);
            this.label1.TabIndex = 0;
            this.label1.Text = "H\r\n\r\nO\r\n\r\nC\r\n\r\nA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 42);
            this.panel1.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(679, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hoca Ders Listesi";
            // 
            // btnDKapat
            // 
            this.btnDKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(119)))));
            this.btnDKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDKapat.BackgroundImage")));
            this.btnDKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDKapat.FlatAppearance.BorderSize = 0;
            this.btnDKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDKapat.Location = new System.Drawing.Point(1381, 0);
            this.btnDKapat.Name = "btnDKapat";
            this.btnDKapat.Size = new System.Drawing.Size(46, 42);
            this.btnDKapat.TabIndex = 0;
            this.btnDKapat.UseVisualStyleBackColor = false;
            this.btnDKapat.Click += new System.EventHandler(this.btnDKapat_Click);
            // 
            // listViewGano
            // 
            this.listViewGano.HideSelection = false;
            this.listViewGano.Location = new System.Drawing.Point(808, 430);
            this.listViewGano.Name = "listViewGano";
            this.listViewGano.Size = new System.Drawing.Size(121, 97);
            this.listViewGano.TabIndex = 74;
            this.listViewGano.UseCompatibleStateImageBehavior = false;
            // 
            // listViewToplamKredi
            // 
            this.listViewToplamKredi.HideSelection = false;
            this.listViewToplamKredi.Location = new System.Drawing.Point(512, 430);
            this.listViewToplamKredi.Name = "listViewToplamKredi";
            this.listViewToplamKredi.Size = new System.Drawing.Size(121, 97);
            this.listViewToplamKredi.TabIndex = 75;
            this.listViewToplamKredi.UseCompatibleStateImageBehavior = false;
            // 
            // btnDersListele
            // 
            this.btnDersListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(119)))));
            this.btnDersListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDersListele.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnDersListele.Location = new System.Drawing.Point(1048, 51);
            this.btnDersListele.Name = "btnDersListele";
            this.btnDersListele.Size = new System.Drawing.Size(332, 33);
            this.btnDersListele.TabIndex = 73;
            this.btnDersListele.Text = "Listele";
            this.btnDersListele.UseVisualStyleBackColor = false;
            this.btnDersListele.Click += new System.EventHandler(this.btnDersListele_Click);
            // 
            // lblGano
            // 
            this.lblGano.AutoSize = true;
            this.lblGano.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGano.Location = new System.Drawing.Point(803, 383);
            this.lblGano.Name = "lblGano";
            this.lblGano.Size = new System.Drawing.Size(148, 26);
            this.lblGano.TabIndex = 69;
            this.lblGano.Text = "Sınıf Ortalaması ";
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKredi.Location = new System.Drawing.Point(507, 383);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(127, 26);
            this.lblKredi.TabIndex = 70;
            this.lblKredi.Text = "Toplam Kredi";
            // 
            // dataGridListele
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListele.Location = new System.Drawing.Point(98, 102);
            this.dataGridListele.Name = "dataGridListele";
            this.dataGridListele.RowHeadersWidth = 51;
            this.dataGridListele.RowTemplate.Height = 24;
            this.dataGridListele.Size = new System.Drawing.Size(1317, 266);
            this.dataGridListele.TabIndex = 68;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(676, 61);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(301, 22);
            this.txtDersKodu.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ders Kodu ";
            // 
            // formHocaSınıf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1427, 539);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewGano);
            this.Controls.Add(this.listViewToplamKredi);
            this.Controls.Add(this.btnDersListele);
            this.Controls.Add(this.lblGano);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.dataGridListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHocaSınıf";
            this.Text = "formHocaSınıf";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDKapat;
        private System.Windows.Forms.ListView listViewGano;
        private System.Windows.Forms.ListView listViewToplamKredi;
        private System.Windows.Forms.Button btnDersListele;
        private System.Windows.Forms.Label lblGano;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.DataGridView dataGridListele;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Label label3;
    }
}