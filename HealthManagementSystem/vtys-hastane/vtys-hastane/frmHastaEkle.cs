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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace vtys_hastane
{
    public partial class frmHastaEkle : Form
    {
        public frmHastaEkle()
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
        private void button4_Click(object sender, EventArgs e)
        {
            frmPersonelAnaEkran yeni = new frmPersonelAnaEkran();
            yeni.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            verileri_goster("select * from hastalar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPersonelAnaEkran yeni = new frmPersonelAnaEkran();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

            komut_ekle.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTCKimlikNo.Text));
            komut_ekle.Parameters.AddWithValue("@adi",txtAd.Text);
            komut_ekle.Parameters.AddWithValue("@soyadi", (txtSoyad.Text));
            komut_ekle.Parameters.AddWithValue("@dogumYeri",(txtDogumYeri.Text));
            komut_ekle.Parameters.AddWithValue("@dogumTarihi", Convert.ToDateTime(txtDogumTarihi.Text));
            komut_ekle.Parameters.AddWithValue("@medeniDurum", txtMedeniDurum.SelectedItem.ToString());
            komut_ekle.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut_ekle.Parameters.AddWithValue("@telefon", txtTelefon.MaskedTextProvider.ToString());

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hastalar (tc_kimlik_no, ad, soyad, dogum_yeri, dogum_tarihi,medeni_durum,adres,telefon) values (@tc, @adi, @soyadi, @dogumYeri, @dogumTarihi,@medeniDurum,@adres,@telefon)";

            NpgsqlDataReader dr2 = komut_ekle.ExecuteReader();
            if (dr2.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr2);
                dataGridView1.DataSource = dt;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            verileri_goster("select * from hastalar");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMedeniDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogumTarihi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogumYeri_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTCKimlikNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPersonelAnaEkran yeni = new frmPersonelAnaEkran();
            yeni.Show();
            this.Hide();
        }
    }
    }
