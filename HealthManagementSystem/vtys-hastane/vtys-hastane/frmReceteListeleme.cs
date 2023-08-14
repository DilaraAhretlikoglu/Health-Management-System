using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys_hastane
{
    public partial class frmReceteListeleme : Form
    {
        public frmReceteListeleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=MuayeneBilgiSistemi2;User Id=postgres;Password=1234");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //connection.Open();

            //// Birleştirilmiş verileri listeleyen sorguyu çalıştır
            //string sql = "SELECT receteler.recete_no,tarih, recete_ilaclar.barkod_no,miktar, ilaclar.ad, ilaclar.tip\r\nFROM receteler\r\nJOIN recete_ilaclar ON receteler.recete_no = recete_ilaclar.recete_no\r\nJOIN ilaclar ON recete_ilaclar.barkod_no = ilaclar.barkod_no\r\nORDER BY receteler.tarih ASC;";
            //NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            //NpgsqlDataReader reader = command.ExecuteReader();

            //// Verileri DataGridView'e doldur
            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);
            //dataGridView1.DataSource = dataTable;

            //// Veritabanı bağlantısını kapat
            //connection.Close();
        }

        private void frmReceteListeleme_Load(object sender, EventArgs e)
        {
            connection.Open();
            // Birleştirilmiş verileri listeleyen sorguyu çalıştır
            string sql = "SELECT receteler.recete_no,tarih, recete_ilaclar.barkod_no,miktar, ilaclar.ad, ilaclar.tip\r\nFROM receteler\r\nJOIN recete_ilaclar ON receteler.recete_no = recete_ilaclar.recete_no\r\nJOIN ilaclar ON recete_ilaclar.barkod_no = ilaclar.barkod_no\r\nORDER BY receteler.tarih ASC;";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            // Verileri DataGridView'e doldur
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;

            // Veritabanı bağlantısını kapat
            connection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDoktorAnaEkran yeni = new frmDoktorAnaEkran();
            yeni.Show();
            this.Hide();
        }
    }
}
