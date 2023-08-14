using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vtys_hastane
{
    public partial class frmİlacRapor : Form
    {
        public frmİlacRapor()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=MuayeneBilgiSistemi2;User Id=postgres;Password=1234");
        private void btnListele_Click(object sender, EventArgs e)
        {
            // Barkod_no bilgisi alınır
            int barkod_no =Convert.ToInt32( txtBarkodNo.Text);

            // Veritabanı bağlantısı açılır
            baglanti.Open();

            // İlacın olup olmadığını kontrol eden sorgu
            NpgsqlCommand checkCommand = new NpgsqlCommand("SELECT COUNT(*) FROM ilaclar WHERE barkod_no = @barkod_no", baglanti);
            checkCommand.Parameters.AddWithValue("@barkod_no", barkod_no);

            // Eğer ilac bulunamazsa, kullanıcıya bir bilgi mesajı gösterilir
            if (Convert.ToInt32(checkCommand.ExecuteScalar()) == 0)
            {
                MessageBox.Show("Girilen barkod_no'ya ait bir ilac bulunamadı.");
                return;
            }

            // Barkod_no'su verilen ilacı kullanan hastaların bilgilerini getiren sorgu
            NpgsqlCommand command = new NpgsqlCommand("SELECT h.tc_kimlik_no, h.ad, h.soyad, h.dogum_yeri, h.dogum_tarihi, h.medeni_durum, h.adres, h.telefon, ri.barkod_no FROM hastalar h JOIN muayeneler m ON h.tc_kimlik_no = m.tc_kimlik_no JOIN receteler r ON m.id = r.muayene_id JOIN recete_ilaclar ri ON r.recete_no = ri.recete_no WHERE ri.barkod_no = @barkod_no", baglanti);
            command.Parameters.AddWithValue("@barkod_no", barkod_no);

            // Sorgu sonucu okunan bilgiler, DataGridView'e yüklenir
            NpgsqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            reader.Close();
            baglanti.Close();

        }

        private void frmİlacRapor_Load(object sender, EventArgs e)
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
