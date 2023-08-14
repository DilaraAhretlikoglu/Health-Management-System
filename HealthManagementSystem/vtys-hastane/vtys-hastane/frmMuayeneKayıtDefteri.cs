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
    public partial class frmMuayeneKayıtDefteri : Form
    {
        public frmMuayeneKayıtDefteri()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMuayeneKayıtDefteri_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from muayeneler");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long muayeneId;
            if (!Int64.TryParse(txtMuayeneId.Text, out muayeneId))
            {
                verileri_goster("select * from muayeneler");
                return;
            }

            string sorgu = "select * from muayeneler where id = '" + muayeneId + "'";

            try
            {
                baglanti.Open();
                DataTable dt = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter(sorgu, baglanti);
                ara.Fill(dt);
                baglanti.Close();
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
                else
                {
                    verileri_goster("select * from muayeneler");
                }

            }
            catch (Exception ex)
            {
                // Veritabanı bağlantısı açılırken bir hata oluştu, hata mesajını gösterin
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDoktorAnaEkran yeni = new frmDoktorAnaEkran();
            yeni.Show();
            this.Hide();
        }
    }
}
