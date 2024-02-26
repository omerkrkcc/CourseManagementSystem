using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DersYonetimSistemi
{
    public partial class formHocaDersListesi : Form
    {
        public formHocaDersListesi()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=dersis;User Id=postgres;Password=admin");
        public void verileriListele(string txt, long hocaNumarasi)
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = sqlErisim;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            komut.Parameters.AddWithValue("@ders_ogretim_uye_numarasi", hocaNumarasi);
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridListele.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }

        private void btnDersListele_Click(object sender, EventArgs e)
        {
            long  hocaNumarasi = Convert.ToInt64(txtOgretmenNo.Text);
            verileriListele("SELECT * FROM dersler WHERE ders_ogretim_uye_numarasi = @ders_ogretim_uye_numarasi ORDER BY ders_numarasi", hocaNumarasi);
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSınıfEkranı_Click(object sender, EventArgs e)
        {
            formHocaSınıf hocaSınıf = new formHocaSınıf();
            this.Hide();
            hocaSınıf.ShowDialog();
            this.Show();
        }
    }
}
