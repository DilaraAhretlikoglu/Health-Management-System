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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDoktorID.Text) == 111)
            {
                if (Convert.ToInt32(txtParola.Text) == 111)
                {
                    frmDoktorAnaEkran yeni = new frmDoktorAnaEkran();
                    yeni.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Parola !");
                }
            }
            else
            {
                MessageBox.Show("Girilen ID ye sahip Doktor Bulunmuyor !");
            }

        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
