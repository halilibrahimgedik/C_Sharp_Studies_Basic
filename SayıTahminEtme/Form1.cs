using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTahminEtme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.Text= Convert.ToString(random.Next(1, 6));
            label2.Text = Convert.ToString(random.Next(1, 6));
            label3.Text = Convert.ToString(random.Next(1, 6));
            label4.Text = Convert.ToString(random.Next(1, 6));
            if (textBox1.Text==label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
                textBox1.BackColor = Color.Red;

            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
                textBox2.BackColor = Color.Red;

            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
                textBox3.BackColor = Color.Red;

            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
                textBox4.BackColor = Color.Red;

            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.Empty;
            label1.Text = "";
            textBox2.Text = "";
            textBox2.BackColor = Color.Empty;
            label2.Text = "";
            textBox3.Text = "";
            textBox3.BackColor = Color.Empty;
            label3.Text = "";
            textBox4.Text = "";
            textBox4.BackColor = Color.Empty;
            label4.Text = "";
            button1.Enabled=true;
            button2.Enabled = false;

        }
    }
}
