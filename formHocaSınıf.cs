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
    public partial class formHocaSınıf : Form
    {
        public formHocaSınıf()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=dersis;User Id=postgres;Password=admin");
        public void verileriListele(string txt, string dersKodu)
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = sqlErisim;
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@ders_kodu", dersKodu);
            komut.CommandText = txt;
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
            verileriListele("select ders_kodu,ogrenci_numarasi,ders_numarasi,ders_kredisi,donem," +
                   "harfnotu,case when harfnotu='AA' then 4 when harfnotu='BA' then 3.5 when harfnotu='CB' then 2.5 when harfnotu='BB' then 3 when harfnotu='CC' then 2 when harfnotu='DC' then 1.5 when harfnotu='DD' then 1 when harfnotu='FD' then 0.5 when harfnotu='FF' then 0 end puan " +
                   "from sinif_listesi where harfnotu is not null AND harfnotu!=' ' AND ders_kodu = @ders_kodu " +
                   "order by ogrenci_numarasi", (txtDersKodu.Text));

            double krediVeNot = 0;
            double toplamKredi = 0;
            foreach (DataGridViewRow row in dataGridListele.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[6].Value != null)
                {
                    double kredim = Convert.ToInt16(row.Cells[3].Value);
                    double not = Convert.ToDouble(row.Cells[6].Value);

                    toplamKredi += kredim;
                    double krediNot = kredim * not;
                    krediVeNot += krediNot;

                }
            }
            double gano = krediVeNot / toplamKredi;
            listViewToplamKredi.View = View.Details;
            listViewToplamKredi.Columns.Add("Kredi", 150);
            ListViewItem kredi = new ListViewItem(toplamKredi.ToString("0.00"));
            listViewToplamKredi.Items.Add(kredi);

            listViewGano.View = View.Details;
            listViewGano.Columns.Add("Gano", 150);
            ListViewItem ortalama = new ListViewItem(gano.ToString("0.00"));
            listViewGano.Items.Add(ortalama);
        }
            private void btnDKapat_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
