using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;
     

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            sayac += 10;
            button2.Enabled = true;
            button3.Enabled = true;
            if (sayac==100)
            {
                button3.Enabled = false;
                button1.Enabled = false;
            }
            label1.Text = sayac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
            sayac = sayac - 10;
            label1.Text =sayac.ToString();
            button1.Enabled = true;
            button3.Enabled = true;
            if (sayac ==0)
            {   
                button2.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();

            if (sayac % 10 == 0)
            {
                progressBar1.Value += 10;
                if (sayac == 100)
                {
                    timer1.Stop();
                    button3.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;

                }
            }
        }
    }
}
