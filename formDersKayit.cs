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
    public partial class formDersKayit : Form
    {
        public formDersKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=dersis;User Id=postgres;Password=admin");
        public void formuHazırla()
        {
            txtKayitNo.Text = "";
            txtOgrenciNo.Text = "";
            txtDersNo.Text = "";
            txtDersKodu.Text = "";
            txtDersKredi.Text = "";
            txtHarfNotu.Text = "";
            txtKayitNo.Focus();
        }
        private void formDersKayit_Load(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("SELECT DISTINCT donem FROM ders_kayitlari ORDER BY donem", sqlErisim);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cmbDonem.ValueMember = "ders_kodu";
            cmbDonem.DisplayMember = "donem";
            cmbDonem.DataSource = dataTable;
        }
        public void verileriListele(string txt)
        {
            NpgsqlCommand komut = new NpgsqlCommand("SELECT ogrenci_numarasi, COUNT(ders_numarasi) AS ders_sayisi FROM ders_kayitlari GROUP BY ogrenci_numarasi");
            komut.Connection = sqlErisim;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridEkle.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        private void btnDersKayit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(txtDersNo.Text) > 10)
            {
                MessageBox.Show("Ders numarası 10'dan büyük olamaz!");
                return;
            }
            sqlErisim.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand();
            komutEkle.Connection = sqlErisim;
            komutEkle.Parameters.AddWithValue("@kayit_numarasi", Convert.ToInt64(txtKayitNo.Text));
            komutEkle.Parameters.AddWithValue("@ogrenci_numarasi", Convert.ToInt64(txtOgrenciNo.Text));
            komutEkle.Parameters.AddWithValue("@ders_numarasi", Convert.ToInt64(txtDersNo.Text));
            komutEkle.Parameters.AddWithValue("@ders_kodu", txtDersKodu.Text);
            komutEkle.Parameters.AddWithValue("@ders_kredisi", Convert.ToInt16(txtDersKredi.Text));
            komutEkle.Parameters.AddWithValue("@donem", cmbDonem.Text);
            komutEkle.Parameters.AddWithValue("@harfnotu", txtHarfNotu.Text);

            komutEkle.CommandType = CommandType.Text;
            komutEkle.CommandText = "insert into ders_kayitlari (kayit_numarasi,ogrenci_numarasi,ders_numarasi,ders_kodu,ders_kredisi,donem,harfnotu) values (@kayit_numarasi,@ogrenci_numarasi,@ders_numarasi,@ders_kodu,@ders_kredisi,@donem,@harfnotu)";
            NpgsqlDataReader dataReader = komutEkle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridEkle.DataSource = dataTable;
            }
            komutEkle.Dispose();
            sqlErisim.Close();
            verileriListele("select * from ders_kayitlari");
            formuHazırla();
        }
        private void btnDersSilmeEkranı_Click(object sender, EventArgs e)
        {
            formDersSil dersSilme = new formDersSil();
            this.Hide();
            dersSilme.ShowDialog();
            this.Show();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            formDersGuncelle dersGuncelle = new formDersGuncelle();
            this.Hide();
            dersGuncelle.ShowDialog();
            this.Show();
        }

        private void btnOrtalamaHesaplama_Click(object sender, EventArgs e)
        {
            formDersOrtalama dersOrtalama = new formDersOrtalama();
            this.Hide();
            dersOrtalama.ShowDialog();
            this.Show();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDersleriListele_Click(object sender, EventArgs e)
        {
            verileriListele("select * from ders_kayitlari");
        }
    }
}
