using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_ve_List_Box
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtBox1.Text);
            listBox1.Items.Add(txtBox2.Text);
            listBox1.Items.Add(txtBox3.Text);
            listBox1.Items.Add(txtBox4.Text);




        }

        
    }
}
