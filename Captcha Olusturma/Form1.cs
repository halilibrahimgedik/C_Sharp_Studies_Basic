using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char [] dizi1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            char[] dizi2 = { '-','*','#','*','/','+','!','%' };
            string[] dizi4 = {"A","B","C","D","E","F","G","H" };
            string[] dizi5 = { ".", ",", "&", "$", "'", "£", "<", ">" };
            Random random = new Random();
            int s1, s2, s3 ,s4,s5;
            s1=random.Next(0,10);
            s2 =random.Next(0,dizi1.Length);
            s3=random.Next(0,dizi2.Length);
            s4=random.Next(0,dizi4.Length);
            s5 = random.Next(0, dizi5.Length);
            label1.Text = Convert.ToString(s1) + dizi1[s2].ToString() + dizi2[s3].ToString() + dizi4[s4] + dizi5[s5];
        }
    }
}
