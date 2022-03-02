using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metot_Çalışmalar_basiz_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int _Toplam(int s1, int s2)
        {
         return s1+ s2;
        }

        int _Çarpım(int s1, int s2)
        {
            return s1 * s2;
        }

        int _Bölüm(int s1, int s2)
        {
            return s1 / s2;
        }

        int _Çıkarma (int s1, int s2)
        {
            return s1 - s2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s=Convert.ToInt32(txtBoxToplam.Text);
            int y= Convert.ToInt32(txtBoxÇarpım.Text);
            label1.Text = "Toplamları: " + _Toplam(s,y).ToString();
            label2.Text= "Çarpımları: "+ _Çarpım(s,y).ToString();
        }
    }
}
