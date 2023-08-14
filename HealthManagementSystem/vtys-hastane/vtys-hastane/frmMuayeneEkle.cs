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
    public partial class frmMuayeneEkle : Form
    {
        public frmMuayeneEkle()
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcKimlikNo =(txtTCKimlikNo.Text);
            DateTime muayeneTarihi = Convert.ToDateTime(txtMuayeneTarihi.Text);
            string sikayet = txtŞikayet.Text;
            string tanı = txtTanı.Text;
            string tedavi = txtTedavi.Text;
            int receteNo = Convert.ToInt32(txtReçeteNo.Text);
            Random rnd = new Random();
            int rastgeleDeger = rnd.Next(1, 999);

            // Veritabanına bağlanın ve muayene bilgilerini ekleyin
            try
            {
                baglanti.Open();

                // Retrieve the examination records for the patient for the given date
                string sorgu = "SELECT * FROM muayeneler WHERE tc_kimlik_no = @tc AND muayene_tarihi = @muayene_tarihi";
                NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@tc", tcKimlikNo);
                cmd.Parameters.AddWithValue("@muayene_tarihi", muayeneTarihi);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                // Check if any examination record exists for the patient for the given date
                if (reader.HasRows)
                {
                    // If an examination record exists, display an error message and return from the function
                    MessageBox.Show("Bu hasta bu tarih için zaten bir muayene kaydı mevcut.");
                    reader.Close();
                    return;
                }
                reader.Close();

                // If no examination record exists, proceed with inserting the new examination record
                sorgu = "insert into muayeneler (id,tc_kimlik_no, muayene_tarihi, sikayet, tanı, tedavi_onerisi, recete_no) values (@id,@tc, @muayene_tarihi, @sikayet, @tanı, @tedavi, @recete_no)";
                cmd = new NpgsqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@id", rastgeleDeger);
                cmd.Parameters.AddWithValue("@tc", tcKimlikNo);
                cmd.Parameters.AddWithValue("@muayene_tarihi", muayeneTarihi);
                cmd.Parameters.AddWithValue("@sikayet", sikayet);
                cmd.Parameters.AddWithValue("@tanı", tanı);
                cmd.Parameters.AddWithValue("@tedavi", tedavi);
                cmd.Parameters.AddWithValue("@recete_no", receteNo);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Muayene bilgileri eklendi.");
                }
                else
                {
                    MessageBox.Show("Muayene bilgileri eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
                verileri_goster("select * from muayeneler");

            }
        }


            private void btnİptal_Click(object sender, EventArgs e)
        {
            frmDoktorAnaEkran yeni=new frmDoktorAnaEkran();
            yeni.Show();
            this.Hide();
        }

        private void txtReçeteNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMuayeneEkle_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from muayeneler");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDoktorAnaEkran yeni = new frmDoktorAnaEkran();
            yeni.Show();
            this.Hide();
        }
    }
}
