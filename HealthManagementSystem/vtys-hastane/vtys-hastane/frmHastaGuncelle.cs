using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys_hastane
{
    public partial class frmHastaGuncelle : Form
    {
        public frmHastaGuncelle()
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "update hastalar set ad = @ad, soyad = @soyad, dogum_yeri = @doğum_yeri, dogum_tarihi = @doğum_tarihi, medeni_durum = @medeni_durum, adres = @adres, telefon = @telefon where tc_kimlik_no = @tc_kimlik";
                NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@doğum_yeri", txtDogumYeri.Text);
                cmd.Parameters.AddWithValue("@doğum_tarihi", Convert.ToDateTime(txtDogumTarihi.Text));
                cmd.Parameters.AddWithValue("@medeni_durum", txtMedeniDurum.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.MaskedTextProvider.ToString());
                cmd.Parameters.AddWithValue("@tc_kimlik", (txtTCKimlikNo.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız.");
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            verileri_goster("select * from hastalar");

            dataGridView1.Refresh();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from hastalar where tc_kimlik_no = @tc", baglanti);
            komut.Parameters.AddWithValue("@tc", (txtAra.Text));
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTCKimlikNo.Text = Convert.ToInt64(read["tc_kimlik_no"]).ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtDogumYeri.Text = read["dogum_yeri"].ToString();
                txtDogumTarihi.Text = read["dogum_tarihi"].ToString();
                txtMedeniDurum.Text = read["medeni_durum"].ToString();
                txtAdres.Text = read["adres"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from hastalar");
        }

        private void txtTCKimlikNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
