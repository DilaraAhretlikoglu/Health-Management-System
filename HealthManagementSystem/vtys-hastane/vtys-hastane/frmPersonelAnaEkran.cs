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
    public partial class frmPersonelAnaEkran : Form
    {
        public frmPersonelAnaEkran()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmHastaEkle yeni = new frmHastaEkle();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHastalarıListele yeni = new frmHastalarıListele();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmSecim yeni = new frmSecim();
            yeni.Show();
            this.Hide();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            frmHastaGuncelle yeni = new frmHastaGuncelle();
            yeni.Show();
            this.Hide();
        }

        private void frmPersonelAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
