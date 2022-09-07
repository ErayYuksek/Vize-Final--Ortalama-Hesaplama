using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string adsoyad =txtadsoyad.Text;
            string durum = "";
            int vize = Convert.ToInt32(txtvize.Text);
            int final = Convert.ToInt32(txtfinal.Text);
            int ortalama = vize * 40 / 100 + final * 60 / 100;

            if (ortalama>50)
            {
                durum = "Geçti";

            }
            else
            {
                durum = "kaldı";
            }

            txtdurum.Text = durum;
            txtortalama.Text = ortalama.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtadsoyad.Text);
            
            
            listBox1.Items.Add(txtvize.Text);

            
            listBox1.Items.Add(txtfinal.Text);
            
            listBox1.Items.Add(txtdurum.Text);
            
            listBox1.Items.Add(txtortalama.Text);





          

            txtadsoyad.Focus();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {

            txtadsoyad.Clear();
            txtvize.Clear();
            txtfinal.Clear();
            txtortalama.Clear();
            txtdurum.Clear();

            txtadsoyad.Focus();
        }

        private void lstboxclear_Click(object sender, EventArgs e)
        {
           

        }
    }
}
