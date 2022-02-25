using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_kullanımı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat, dakika,saniye=0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye==30)
            {
                
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if (dakika==10)
                {
                    
                    saat++;
                    label1.Text = saat.ToString();
                    dakika = 0;
                }
               
            }
            

        }
    }
}
