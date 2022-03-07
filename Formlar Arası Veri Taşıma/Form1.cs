using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Veri_Taşıma
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
            Form2 form=new Form2();
            form.mesaj =textBox1.Text;
            form.mesaj2 = textBox2.Text;
            form.mesaj3 = textBox3.Text;
            form.Show();

            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox6.Text= textBox4.Text + textBox5.Text;
        }
    }
}
