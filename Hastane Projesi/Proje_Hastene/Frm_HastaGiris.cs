using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastene
{
    public partial class Frm_HastaGiris : Form
    {
        public Frm_HastaGiris()
        {
            InitializeComponent();
        }

        private void Frm_HastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaDetay fr = new FrmHastaDetay();
            fr.tc = MskTc.Text;
            fr.Show();
            this.Hide();
     

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeKayıt fr = new FrmUyeKayıt();
            fr.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
