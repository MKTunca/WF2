using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = Convert.ToString(ad.Text);
            string a2 = Convert.ToString(soyad.Text);
            string birlesme = toplam(a1, a2);
            MessageBox.Show(birlesme);
            
        }
        public string toplam(string a, string b)
        {
          string sonuc = "";
            sonuc = a + " " + b;
            return sonuc;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1.Text = sayi1.Text.Replace(".", ",");
            sayi2.Text = sayi2.Text.Replace(".", ",");
            double s1 = Convert.ToDouble(sayi1.Text);
            double s2 = Convert.ToDouble(sayi2.Text);
            double carpma = carpim(s1, s2);
            MessageBox.Show(carpma.ToString());
        }
        public double carpim(double a,double b )
        {
            double sonuc = 0;
            sonuc = a * b;
            return sonuc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi3.Text = sayi3.Text.Replace(".", ",");
            sayi4.Text = sayi4.Text.Replace(".", ",");
            double s3 = Convert.ToDouble(sayi3.Text);
            double s4 = Convert.ToDouble(sayi4.Text);
            double bolum = bolme(s3, s4);
            MessageBox.Show(bolum.ToString());
        }
        public double bolme(double c,double d)
        {
            double sonuc = 0;
            sonuc = c / d;
            return sonuc;
        }


    }
}
