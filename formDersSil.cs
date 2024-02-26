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
    public partial class formDersSil : Form
    {
        public formDersSil()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=dersis;User Id=postgres;Password=admin");
        public void formuHazırla()
        {
            txtVerileriGetir.Text = "";
            txtVerileriGetir.Focus();
        }
        public void verileriListele(string txt)
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = sqlErisim;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridSil.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        private void btnVerileriGetir_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komutGetir = new NpgsqlCommand("select * from ders_kayitlari WHERE ders_kodu = @ders_kodu", sqlErisim);
            komutGetir.Parameters.AddWithValue("@ders_kodu", txtVerileriGetir.Text);
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komutGetir.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridSil.DataSource = dataTable;
                dataGridSil.Refresh();
            }
            komutGetir.Dispose();
            sqlErisim.Close();
        }
        private void btnDersSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komutSil = new NpgsqlCommand("DELETE FROM ders_kayitlari WHERE ders_kodu = @ders_kodu", sqlErisim);
            komutSil.Parameters.AddWithValue("@ders_kodu", txtDersSil.Text);
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komutSil.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridSil.DataSource = dataTable;
            }
            komutSil.Dispose();
            sqlErisim.Close();
            verileriListele("select * from ders_kayitlari");
            formuHazırla();
        }

        private void btnSilmeIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
