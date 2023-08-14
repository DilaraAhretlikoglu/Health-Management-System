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
    public partial class frmRaporHasta : Form
    {
        public frmRaporHasta()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=MuayeneBilgiSistemi2;User Id=postgres;Password=1234");

        private void frmRaporHasta_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // Barkod_no bilgisi alınır
            string tc_no = (txtTCNo.Text);
            // Veritabanı bağlantısı açılır
            baglanti.Open();
            // İlacın olup olmadığını kontrol eden sorgu
            NpgsqlCommand checkCommand = new NpgsqlCommand("SELECT COUNT(*) FROM hastalar WHERE tc_kimlik_no = @tc_no", baglanti);
            checkCommand.Parameters.AddWithValue("@tc_no", tc_no);
            // Eğer ilac bulunamazsa, kullanıcıya bir bilgi mesajı gösterilir
            if (Convert.ToInt32(checkCommand.ExecuteScalar()) == 0)
            {
                MessageBox.Show("Girilen Tc Kimlik Numarasına ait bir hasta kaydı bulunamadı");
                return;
            }
            // Barkod_no'su verilen ilacı kullanan hastaların bilgilerini getiren sorgu
            NpgsqlCommand command = new NpgsqlCommand("SELECT  h.tc_kimlik_no, h.ad, h.soyad,il.ad AS ilac_adi, ri.miktar AS miktar\r\nFROM hastalar h\r\nJOIN muayeneler m ON h.tc_kimlik_no = m.tc_kimlik_no\r\nJOIN receteler r ON m.id = r.muayene_id\r\nJOIN recete_ilaclar ri ON r.recete_no = ri.recete_no\r\nJOIN ilaclar il ON ri.barkod_no = il.barkod_no\r\nWHERE h.tc_kimlik_no = @tc_no", baglanti);
            command.Parameters.AddWithValue("@tc_no", tc_no);
            // Sorgu sonucu okunan bilgiler, DataGridView'e yüklenir
            NpgsqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            reader.Close();
            baglanti.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDoktorAnaEkran yeni = new frmDoktorAnaEkran();
            yeni.Show();
            this.Hide();
        }
    }
}
