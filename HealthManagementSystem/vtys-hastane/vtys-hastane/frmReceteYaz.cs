using Npgsql;
using NpgsqlTypes;
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
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vtys_hastane
{
    public partial class frmReceteYaz : Form
    {
        public frmReceteYaz()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=MuayeneBilgiSistemi2;User Id=postgres;Password=1234");


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReceteYaz_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)

        {
            //int receteNo = Convert.ToInt32(txtReceteNo.Text);
            //int muayeneId = Convert.ToInt32(txtMuayeneID.Text);
            //DateTime tarih = Convert.ToDateTime(txtTarih.Text);
            //connection.Open();

            //// Muayeneler tablosundaki muayene ID'sine sahip bir muayene var mı kontrol et
            //string sql = "SELECT COUNT(*) FROM muayeneler WHERE ID = @id";
            //NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            //command.Parameters.AddWithValue("@id", muayeneId);
            //int count = Convert.ToInt32(command.ExecuteScalar());

            //if (count > 0)
            //{
            //    // Muayeneler tablosundaki muayene ID'sine sahip bir muayene var, reçeteler tablosundaki bu muayene ID'sine sahip kayıtları say
            //    sql = "SELECT COUNT(*) FROM receteler WHERE muayene_id = @id";
            //    command = new NpgsqlCommand(sql, connection);
            //    command.Parameters.AddWithValue("@id", muayeneId);
            //    count = Convert.ToInt32(command.ExecuteScalar());

            //    if (count == 0)
            //    {
            //        // Bu muayene ID'sine sahip bir reçete kaydı yok, reçeteler tablosuna kayıt ekle
            //        sql = "INSERT INTO receteler (recete_no, muayene_id, tarih) SELECT @recete_no, ID, @tarih FROM muayeneler WHERE ID = @id";
            //        command = new NpgsqlCommand(sql, connection);
            //        command.Parameters.AddWithValue("@recete_no", receteNo);
            //        command.Parameters.AddWithValue("@id", muayeneId);
            //        command.Parameters.AddWithValue("@tarih", tarih);
            //        command.ExecuteNonQuery();

            //        // Reçeteilaclar tablosuna kayıt ekle
            //        foreach (DataGridViewRow row in dataGridView1.Rows)
            //        {
            //            int barkodNo = Convert.ToInt32(row.Cells["Barkod_no"].Value);
            //            int miktar = Convert.ToInt32(row.Cells["Kutu_sayisi"].Value);
            //            string query = "INSERT INTO recete_ilaclar (recete_no, barkod_no, miktar) VALUES (@recete_no, @barkod_no, @miktar)";
            //            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            //            {
            //                cmd.Parameters.AddWithValue("@recete_no", receteNo);
            //                cmd.Parameters.AddWithValue("@barkod_no", barkodNo);
            //                cmd.Parameters.AddWithValue("@miktar", miktar);
            //                cmd.ExecuteNonQuery();
            //            }
            //        }


            //        // İşlemin gerçekleştiğine dair bilgi mesajı ver
            //        MessageBox.Show("Reçete ve ilaç bilgileri eklendi.");
            //    }
            //    else
            //    {
            //        // Bu muayene ID'sine sahip bir reçete kaydı zaten var
            //        MessageBox.Show("Bu muayene için zaten bir reçete kaydı mevcut.");
            //    }
            //}
            //else
            //{
            //    // Muayeneler tablosundaki muayene ID'sine sahip bir muayene bulunamadı
            //    MessageBox.Show("Bu muayene ID'sine sahip bir muayene bulunamadı. Lütfen geçerli bir muayene ID'si girin.");
            //}
            //connection.Close();








            //                // Check if more than 5 rows are selected
            //                if (dataGridView1.SelectedRows.Count > 5)
            //                {
            //    dataGridView1.AllowUserToAddRows = false;
            //    MessageBox.Show("Bir reçetede en fazla beş ilaç yazılabilir.");
            //                    return;
            //                }

            //                // Check if all selected rows have a value of 1, 2, or 3 in the second column
            //                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //                {
            //                    object cellValue = row.Cells[1].Value;
            //    if (cellValue == null || (int)cellValue < 1 || (int)cellValue > 3)
            //    {
            //        MessageBox.Show("İkinci kolona sadece 1, 2, veya 3 değerleri girebilirsiniz.");
            //        return;
            //    }
            //}

            //                int recete_no = Convert.ToInt32(txtReceteNo.Text);
            //    int muayene_id = Convert.ToInt32(txtMuayeneID.Text);
            //    DateTime tarih = Convert.ToDateTime(txtTarih.Text);
            //    connection.Open();

            //    // Muayeneler tablosundaki muayene ID'sine sahip bir muayene var mı kontrol et
            //    string sql = "SELECT COUNT(*) FROM muayeneler WHERE ID = @id";
            //    NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            //    command.Parameters.AddWithValue("@id", muayene_id);
            //    int count = Convert.ToInt32(command.ExecuteScalar());

            //    if (count > 0)
            //    {
            //        // Muayeneler tablosundaki muayene ID'sine sahip bir muayene var, reçeteler tablosundaki bu muayene ID'sine sahip kayıtları say
            //        sql = "SELECT COUNT(*) FROM receteler WHERE muayene_id = @id";
            //        command = new NpgsqlCommand(sql, connection);
            //        command.Parameters.AddWithValue("@id", muayene_id);
            //        count = Convert.ToInt32(command.ExecuteScalar());

            //        if (count == 0)
            //        {
            //            // Bu muayene ID'sine sahip bir reçete kaydı yok, reçeteler tablosuna kayıt ekle
            //            sql = "INSERT INTO receteler (recete_no, muayene_id, tarih) SELECT @recete_no, ID, @tarih FROM muayeneler WHERE ID = @id";
            //            command = new NpgsqlCommand(sql, connection);
            //            command.Parameters.AddWithValue("@recete_no", recete_no);
            //            command.Parameters.AddWithValue("@id", muayene_id);
            //            command.Parameters.AddWithValue("@tarih", tarih);
            //            command.ExecuteNonQuery();

            //            // Reçeteilaclar tablosuna kayıt ekle
            //            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //            {
            //                int barkod_no = Convert.ToInt32(row.Cells["barkod_no"].Value);
            //                int miktar = Convert.ToInt32(row.Cells["miktar"].Value);
            //                sql = "INSERT INTO recete_ilaclar (recete_no, barkod_no, miktar) VALUES (@recete_no, @barkod_no, @miktar)";
            //                command = new NpgsqlCommand(sql, connection);
            //                command.Parameters.AddWithValue("@recete_no", recete_no);
            //                command.Parameters.AddWithValue("@barkod_no", barkod_no);
            //                command.Parameters.AddWithValue("@miktar", miktar);
            //                command.ExecuteNonQuery();
            //            }

            //            // İşlemin gerçekleştiğine dair bilgi mesajı ver
            //            MessageBox.Show("Reçete ve ilaç bilgileri eklendi.");
            //        }
            //        else
            //        {
            //            // Bu muayene ID'sine sahip bir reçete kaydı zaten var
            //            MessageBox.Show("Bu muayene için zaten bir reçete kaydı mevcut.");
            //        }
            //    }
            //    else
            //    {
            //        // Muayeneler tablosundaki muayene ID'sine sahip bir muayene bulunamadı
            //        MessageBox.Show("Bu muayene ID'sine sahip bir muayene bulunamadı. Lütfen geçerli bir muayene ID'si giriniz.");
            //    }
            //    connection.Close();








            int recete_no = Convert.ToInt32(txtReceteNo.Text);
            int muayene_id = Convert.ToInt32(txtMuayeneID.Text);
            DateTime tarih = Convert.ToDateTime(txtTarih.Text);

           
            connection.Open();

            // Muayeneler tablosundaki muayene ID'sine sahip bir muayene var mı kontrol et
            string sql = "SELECT COUNT(*) FROM muayeneler WHERE ID = @id";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", muayene_id);
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0)
            {
                //Muayeneler tablosundaki muayene ID'sine sahip bir muayene var, reçeteler tablosundaki bu muayene ID'sine sahip kayıtları say
                sql = "SELECT COUNT(*) FROM receteler WHERE muayene_id = @id";
                command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", muayene_id);
                count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                {
                    //Bu muayene ID'sine sahip bir reçete kaydı yok, reçeteler tablosuna kayıt ekle
                    sql = "INSERT INTO receteler (recete_no, muayene_id, tarih) SELECT @recete_no, ID, @tarih FROM muayeneler WHERE ID = @id";
                    command = new NpgsqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@recete_no", recete_no);
                    command.Parameters.AddWithValue("@id", muayene_id);
                    command.Parameters.AddWithValue("@tarih", tarih);
                    command.ExecuteNonQuery();

                    //Reçeteilaclar tablosuna kayıt ekle
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string query = ("INSERT INTO recete_ilaclar (recete_no, barkod_no, miktar) SELECT @recete_no, @barkod_no, @miktar FROM receteler WHERE recete_no = @recete_no");
                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            if (row.Cells[0].Value != null)
                            {
                                cmd.Parameters.Add("@recete_no", NpgsqlDbType.Integer).Value = row.Cells[0].Value;
                            }
                            if (row.Cells[1].Value != null)
                            {
                                cmd.Parameters.Add("@barkod_no", NpgsqlDbType.Integer).Value = row.Cells[1].Value;
                            }
                            if (row.Cells[2].Value != null)
                            {
                                cmd.Parameters.Add("@miktar", NpgsqlDbType.Integer).Value = row.Cells[2].Value;
                            }
                            cmd.ExecuteNonQuery();
                        }
                    }


                    //İşlemin gerçekleştiğine dair bilgi mesajı ver
                    MessageBox.Show("Reçete ve ilaç bilgileri eklendi.");
                }
                else
                {
                    //Bu muayene ID'sine sahip bir reçete kaydı zaten var
                    MessageBox.Show("Bu muayene için zaten bir reçete kaydı mevcut.");
                }
            }
            else
            {
                //Muayeneler tablosundaki muayene ID'sine sahip bir muayene bulunamadı
                MessageBox.Show("Bu muayene ID'sine sahip bir muayene bulunamadı. Lütfen geçerli bir muayene ID'si girin.");
            }
            connection.Close();




        }
    

                
            
    






            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtReceteNo_TextChanged(object sender, EventArgs e)
        {
            //// Veritabanına bağlantı aç
            //string connectionString = "Server=localhost;Port=5432;Database=MuayeneBilgiSistemi2;User Id=postgres;Password=1234";
            //using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            //{
            //    connection.Open();

            //    // Muayeneler tablosundan reçete numarasına göre hasta TC kimlik numarasını getir
            //    string sql = "SELECT tc_kimlik_no FROM muayeneler WHERE recete_no = @reçete_no";
            //    NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            //    command.Parameters.AddWithValue("@reçete_no", Convert.ToInt32(txtReceteNo.Text));
            //    NpgsqlDataReader reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        txtHastaTC.Text = reader["tc_kimlik_no"].ToString();
            //    }
            //    reader.Close();

            //    // Hastalar tablosundan TC kimlik numarasına göre hasta adı ve soyadını getir
            //    sql = "SELECT ad, soyad FROM hastalar WHERE tc_kimlik_no = @tc_kimlik_no";
            //    command = new NpgsqlCommand(sql, connection);
            //    command.Parameters.AddWithValue("@tc_kimlik_no", (txtHastaTC.Text));
            //    reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        txtHastaAdı.Text = reader["ad"].ToString();
            //        txtHastaSoyadı.Text = reader["soyad"].ToString();
            //    }
            //    reader.Close();
            //}
            // Veritabanına bağlantı aç
            string connectionString = "Server=localhost;Port=5432;Database=MuayeneBilgiSistemi2;User Id=postgres;Password=1234";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Muayeneler tablosundan reçete numarasına göre id ve muayene_tarihi bilgilerini getir
                string sql = "SELECT id, muayene_tarihi FROM muayeneler WHERE recete_no = @reçete_no";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@reçete_no", Convert.ToInt32(txtReceteNo.Text));
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtMuayeneID.Text = reader["id"].ToString();
                    txtTarih.Text = reader["muayene_tarihi"].ToString();
                }
                reader.Close();

                // Muayeneler tablosundan reçete numarasına göre hasta TC kimlik numarasını getir
                sql = "SELECT tc_kimlik_no FROM muayeneler WHERE recete_no = @reçete_no";
                command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@reçete_no", Convert.ToInt32(txtReceteNo.Text));
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtHastaTC.Text = reader["tc_kimlik_no"].ToString();
                }
                reader.Close();

                // Hastalar tablosundan TC kimlik numarasına göre hasta adı ve soyadını getir
                sql = "SELECT ad, soyad FROM hastalar WHERE tc_kimlik_no = @tc_kimlik_no";
                command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@tc_kimlik_no", (txtHastaTC.Text));
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtHastaAdı.Text = reader["ad"].ToString();
                    txtHastaSoyadı.Text = reader["soyad"].ToString();
                }
                reader.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int sayac = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            //sayac++;
            //if (sayac > 5)
            //{
            //    button2.Enabled = false;
            //    MessageBox.Show("Bir reçeteye en fazla 5 ilaç eklenebilir !");
            //}
            //else
            //{
            //    // Textboxtaki değerleri oku
            //    int barkodNo = Convert.ToInt32(txtBarkodNo.Text);
            //    int miktar = Convert.ToInt32(txtKutuSayısı.Text);
            //    int recete_no = Convert.ToInt32(txtReceteNo.Text);

            //    // Textboxtaki değerleri datagride ekle
            //    dataGridView1.Rows.Add(recete_no, barkodNo, miktar);

            //}

            sayac++;
            if (sayac > 5)
            {
                button2.Enabled = false;
                MessageBox.Show("Bir reçeteye en fazla 5 ilaç eklenebilir !");
            }
            else
            {
                // Textboxtaki değerleri oku
                int barkodNo = Convert.ToInt32(txtBarkodNo.Text);
                int miktar = Convert.ToInt32(cmbKutuSayısı.SelectedItem);
                int recete_no = Convert.ToInt32(txtReceteNo.Text);

                // Textboxtaki değerleri datagride ekle
                dataGridView1.Rows.Add(recete_no, barkodNo, miktar);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void txtKutuSayısı_TextChanged(object sender, EventArgs e)
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
