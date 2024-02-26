using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciGirisi_Click(object sender, EventArgs e)
        {
            formOgrenciKayit ogrenciEkleme = new formOgrenciKayit();
            this.Hide();
            ogrenciEkleme.ShowDialog();
            this.Show();
        }

        private void btnHocaGirisi_Click(object sender, EventArgs e)
        {
            formHocaDersListesi dersListeleme = new formHocaDersListesi();
            this.Hide();
            dersListeleme.ShowDialog();
            this.Show();
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
