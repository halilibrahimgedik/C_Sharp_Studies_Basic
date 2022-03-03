using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrencı_Sınav_Durumu_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            txtBoxSınav1.Focus();
            double s1, s2, s3, ortalama;
            string durum;
            s1 = Convert.ToDouble(txtBoxSınav1.Text);
            s2 = Convert.ToDouble(txtBoxSınav2.Text);
            s3 = Convert.ToDouble(txtBoxSınav3.Text);
            ortalama= (s1+ s2+ s3) /3;
            if (ortalama>=50)
            {
                durum = "geçtiniz..";
            }
            else
            {
                durum = "kaldınız..";
            }

            lblDurum.Text = "ortalama:" +ortalama.ToString("0.000")+ " "+durum;
        }
    }
}
