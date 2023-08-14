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
    public partial class frmİlaçEkle : Form
    {
        public frmİlaçEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=MuayeneBilgiSistemi2;User Id=postgres;Password=1234");
        public void verileri_goster(string txt)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

            komut_ekle.Parameters.AddWithValue("@barkod", Convert.ToInt64(txtBarkod.Text));
            komut_ekle.Parameters.AddWithValue("@ad", txtAd.Text);
            komut_ekle.Parameters.AddWithValue("@tip", (cmbTip.SelectedItem.ToString()));


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilaclar (barkod_no, ad, tip) values (@barkod, @ad, @tip)";

            NpgsqlDataReader dr2 = komut_ekle.ExecuteReader();
            if (dr2.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr2);
                dataGridView1.DataSource = dt;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            verileri_goster("select * from ilaclar");
        }

        private void frmİlaçEkle_Load(object sender, EventArgs e)
        {


            verileri_goster("select * from ilaclar");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDoktorAnaEkran yeni = new frmDoktorAnaEkran();
            yeni.Show();
            this.Hide();
        }
    }
}
