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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public string mesaj;
        public string mesaj2;
        public string mesaj3;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
            comboBox1.Items.Add(mesaj);
            comboBox1.Items.Add(mesaj2);
            comboBox1.Items.Add(mesaj3);

        }
    }
}
