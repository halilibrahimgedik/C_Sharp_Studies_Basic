using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetinBelgesiOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaadi, dosyayolu;
        StreamWriter sw;

        private void btnYolSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()== DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw =File.CreateText(dosyayolu+"//"+ dosyaadi +".txt");
            sw.Close();
            MessageBox.Show("Dosya"+dosyayolu+ " adlı yere kaydedilmiştir..");
        }
    }
}
