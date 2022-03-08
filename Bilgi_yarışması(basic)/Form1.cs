using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarışması_basic_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 1;
        int dogru=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text = Convert.ToString(a);
            richTextBox1.Text = " What is capital of Turkey ?";
            btnA.Text = "Ankara";
            btnB.Text = "İstanbul";
            btnC.Text = "Antalya";
            btnD.Text = "İzmir";

        }

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            a = a+ 1;
            label1.Text = Convert.ToString(a);
            btnA.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnB.Enabled = true;
            btnA.BackColor = Color.Transparent;
            btnC.BackColor = Color.Transparent;
            btnD.BackColor = Color.Transparent;
            btnB.BackColor = Color.Transparent;

            if (label1.Text == "2")
            {
                richTextBox1.Text = " Which country is the most popular with Kebab ?";
                btnA.Text = "Turkey";
                btnB.Text = "Germany";
                btnC.Text = "England";
                btnD.Text = "Italy";
            }
            if (label1.Text == "3")
            {
                richTextBox1.Text = " Which star is not popular in worldwide?";
                btnA.Text = "Angelina jolie";
                btnB.Text = "Bradd pit";
                btnC.Text = "Andrew Garfield";
                btnD.Text = "Chloe zoe";
            }



        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                btnB.BackColor = Color.Green;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
                dogru += 1;
                label2.Text = Convert.ToString(dogru);
            }
            if (label1.Text == "2")
            {
                btnB.BackColor = Color.Red;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
               
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                btnA.BackColor = Color.Red;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
            }
            if (label1.Text == "2")
            {
                btnA.BackColor = Color.Green;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                btnC.BackColor = Color.Red;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
            }
            if (label1.Text == "2")
            {
                btnC.BackColor = Color.Red;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                btnD.BackColor = Color.Red;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
            }
            if (label1.Text == "2")
            {
                btnD.BackColor = Color.Red;
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnB.Enabled = false;
            }
        }
    }
}
