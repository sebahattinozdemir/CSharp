using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders7_radioButton__MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);

            double toplam = sayi1 + sayi2;
            double fark = sayi1 - sayi2;
            double carpim = sayi1 * sayi2;
            double bolme = sayi1 / sayi2;

            label7.Text = Convert.ToString(toplam);
            label8.Text = Convert.ToString(carpim);
            label9.Text = Convert.ToString(bolme);
            label10.Text = Convert.ToString(fark);


        }
    }
}
