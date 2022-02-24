using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Kullanımı
{
    public partial class form1 : System.Windows.Forms.Form
    {
        public form1()
        {
            InitializeComponent();
        }
        int sayac=0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 5)
            {
                this.BackColor = Color.LightBlue;
            }
            else if (sayac == 10) { this.BackColor = Color.LightGreen; }
            else if (sayac == 15) { this.BackColor = Color.LightGreen; }
            else if (sayac == 20) { this.BackColor = Color.Blue; }
            else if (sayac == 25) { this.BackColor = Color.Yellow; }
            else if (sayac == 30) { this.BackColor = Color.PeachPuff; }
            if (sayac==30)
            {
                sayac=0;
            }
        }
    }
}
