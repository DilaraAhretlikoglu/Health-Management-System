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
    public partial class frmPersonelGiris : Form
    {
        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtPersonelID .Text)== 111)
            {
                if (Convert.ToInt32(txtParola.Text) == 111)
                {
                    frmPersonelAnaEkran yeni = new frmPersonelAnaEkran();
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
                MessageBox.Show("Girilen ID ye sahip Personel Bulunmuyor !");
            }


        }
    }
}
