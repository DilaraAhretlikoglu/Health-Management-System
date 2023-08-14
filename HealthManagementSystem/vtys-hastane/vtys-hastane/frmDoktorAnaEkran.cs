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
    public partial class frmDoktorAnaEkran : Form
    {
        public frmDoktorAnaEkran()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMuayeneEkle yeni= new frmMuayeneEkle();
            yeni.Show();
            this.Hide();
        }

        private void frmDoktorAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmSecim yeni=new frmSecim();
            yeni.Show();
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMuayeneKayıtDefteri yeni = new frmMuayeneKayıtDefteri();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReceteYaz yeni = new frmReceteYaz();
            yeni.Show();
            this.Hide();
        }

        private void btnReceteleriListele_Click(object sender, EventArgs e)
        {
            frmReceteListeleme yeni = new  frmReceteListeleme();
            yeni.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmİlacRapor yeni=new frmİlacRapor();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRaporHasta yeni = new frmRaporHasta();
            yeni.Show();
            this.Hide();
        }

        private void btnİlaçEkle_Click(object sender, EventArgs e)
        {
            frmİlaçEkle yeni=new frmİlaçEkle();
            yeni.Show();
            this.Hide();
        }
    }
}
