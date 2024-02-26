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
    public partial class formDersGuncelle : Form
    {
        public formDersGuncelle()
        {
            InitializeComponent();
        }
        public void formuHazırla()
        {
            txtKoduGetir.Text = "";
            txtKayitNo.Text = "";
            txtOgrenciNo.Text = "";
            txtDersNo.Text = "";
            txtDersKredi.Text = "";
            txtGuncellenecekKod.Text = "";
            txtHarfNotu.Text = "";
            txtKoduGetir.Text = "";
            txtYeniDersKodu.Text = "";
            txtKoduGetir.Focus();
        }
        private void formDersGuncelle_Load(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("SELECT DISTINCT donem FROM ders_kayitlari ORDER BY donem", sqlErisim);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cmbDonem.ValueMember = "ders_kodu";
            cmbDonem.DisplayMember = "donem";
            cmbDonem.DataSource = dataTable;
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=dersis;User Id=postgres;Password=admin");
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
                dataGridGuncelle.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        private void btnVerileriGetir_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komutGetir = new NpgsqlCommand("select * from ders_kayitlari WHERE ders_kodu = @ders_kodu", sqlErisim);
            komutGetir.Parameters.AddWithValue("@ders_kodu", txtKoduGetir.Text);
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komutGetir.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridGuncelle.DataSource = dataTable;
                dataGridGuncelle.Refresh();
            }
            komutGetir.Dispose();
            sqlErisim.Close();
        }

        private void btnDersIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(txtDersNo.Text) > 10)
            {
                MessageBox.Show("Ders numarası 10'dan büyük olamaz!");
                return;
            }
            NpgsqlCommand komutGuncelle = new NpgsqlCommand("UPDATE ders_kayitlari SET ders_kodu = @ders_kodu, kayit_numarasi = @kayit_numarasi,ogrenci_numarasi = @ogrenci_numarasi,ders_numarasi=@ders_numarasi,ders_kredisi = @ders_kredisi, donem = @donem, harfnotu = @harfnotu WHERE ders_kodu = @guncelDers", sqlErisim);
            komutGuncelle.Parameters.AddWithValue("@ders_kodu", txtYeniDersKodu.Text);
            komutGuncelle.Parameters.AddWithValue("@kayit_numarasi", Convert.ToInt64(txtKayitNo.Text));
            komutGuncelle.Parameters.AddWithValue("@ogrenci_numarasi", Convert.ToInt64(txtOgrenciNo.Text));
            komutGuncelle.Parameters.AddWithValue("@ders_numarasi", Convert.ToInt64(txtDersNo.Text));
            komutGuncelle.Parameters.AddWithValue("@ders_kredisi", Convert.ToInt16(txtDersKredi.Text));
            komutGuncelle.Parameters.AddWithValue("@donem", cmbDonem.Text);
            komutGuncelle.Parameters.AddWithValue("@harfNotu", txtHarfNotu.Text);
            komutGuncelle.Parameters.AddWithValue("@guncelDers", txtGuncellenecekKod.Text);
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komutGuncelle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridGuncelle.DataSource = dataTable;
                dataGridGuncelle.Refresh();
            }
            komutGuncelle.Dispose();
            sqlErisim.Close();
            verileriListele("select * from ders_kayitlari");
            formuHazırla();
        }
        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
