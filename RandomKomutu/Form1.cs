using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomKomutu
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x=rnd.Next(1,100);
            int y = rnd.Next(1, 100);
            int z = rnd.Next(1, 100);
            label1.Text = x.ToString();
            label2.Text = y.ToString();
            label3.Text = z.ToString();
        }
    }
}
