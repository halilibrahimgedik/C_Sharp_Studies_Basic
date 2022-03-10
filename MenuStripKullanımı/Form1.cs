using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripKullanımı
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

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Red;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void açıkYeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu çalışma Halil İbrahim Gedik tarafından yapılmıştır...","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void theTomorrowWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/rQMQvvJssWs");
            label1.Text = "Yarınının Sınırında";
        }

        private void inceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/vgNN9sk2MWw");
            label1.Text = "Inception";
        }

        private void marvelİnfinityWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/NWepvH6LnEw");
            label1.Text = "Sonsuzluk Savaşı";
        }

        private void spiderManNoWayHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/mQ_F_0jA59k");
            label1.Text = "Spider-Man Eve Dönüş Yok";
        }

        private void theSocialNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/q3mSOWEM5bY");
            label1.Text = "The Social Network";
        }

        private void ınterstellarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/vVJeYMRam0o");
            label1.Text = "Yıldızlar Arasında";
        }
    }
}
