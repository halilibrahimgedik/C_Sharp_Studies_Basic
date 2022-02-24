using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tc_Tel_Resim_MaskedBox_Tarih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Add(maskedTextBox1.Text+" "+ maskedTextBox2.Text + " "+maskedTextBox3.Text + " " + comboBox1.Text + " "+dateTimePicker1.Text);
            comboBox1.Items.Add(comboBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
