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
    public partial class formOgrenciKayit : Form
    {
        public formOgrenciKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=dersis;User Id=postgres;Password=admin");
        public void formuHazırla()
        {
            txtOgrenciNo.Text = "";
            txtOgrenciAdi.Text = "";
            txtOgrenciEposta.Text = "";
            txtOgrenciSoyadi.Text = "";
            txtDogumYeri.Text = "";
            txtDogumTarihi.Text = "";
            txtAdresBilgisi.Text = "";
            txtTelefonNo.Text = "";
            txtOgrenciNo.Focus();
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
                dataGridEkle.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        private void btnDersKayitEkranı_Click(object sender, EventArgs e)
        {
            formDersKayit dersKayit = new formDersKayit();
            this.Hide();
            dersKayit.ShowDialog();
            this.Show();
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            sqlErisim.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand();
            komutEkle.Connection = sqlErisim;

            komutEkle.Parameters.AddWithValue("@ogrenci_numarasi", Convert.ToInt64(txtOgrenciNo.Text));
            komutEkle.Parameters.AddWithValue("@ogrenci_adi", txtOgrenciAdi.Text);
            komutEkle.Parameters.AddWithValue("@ogrenci_soyadi", txtOgrenciSoyadi.Text);
            komutEkle.Parameters.AddWithValue("@ogrenci_dogum_tarihi", txtDogumTarihi.Text);
            komutEkle.Parameters.AddWithValue("@ogrenci_dogum_yeri", txtDogumYeri.Text);
            komutEkle.Parameters.AddWithValue("@ogrenci_eposta", txtOgrenciEposta.Text);
            komutEkle.Parameters.AddWithValue("@ogrenci_telefonu", Convert.ToInt64(txtTelefonNo.Text));
            komutEkle.Parameters.AddWithValue("@ogrenci_adresi", txtAdresBilgisi.Text);

            komutEkle.CommandType = CommandType.Text;
            komutEkle.CommandText = "insert into ogrenciler (ogrenci_numarasi,ogrenci_adi,ogrenci_soyadi,ogrenci_dogum_tarihi,ogrenci_dogum_yeri,ogrenci_eposta,ogrenci_telefonu,ogrenci_adresi) values (@ogrenci_numarasi,@ogrenci_adi,@ogrenci_soyadi,@ogrenci_dogum_tarihi,@ogrenci_dogum_yeri,@ogrenci_eposta,@ogrenci_telefonu,@ogrenci_adresi)";

            NpgsqlDataReader dataReader = komutEkle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridEkle.DataSource = dataTable;
            }
            komutEkle.Dispose();
            sqlErisim.Close();
            verileriListele("select * from ogrenciler");
            formuHazırla();
        }

        private void btnHastaListele_Click(object sender, EventArgs e)
        {
            verileriListele("select * from ogrenciler");
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
