using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "KARE";

            label2.Visible = true;

            label4.Visible = true;

            label5.Visible = true;

            button3.Visible = true;

            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DIKDORTGEN";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            label5.Visible = true;

            button4.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Kenar, Alan, Cevre;
            

            Kenar = Convert.ToInt32(textBox1.Text);
            Alan = Kenar * Kenar;
            label6.Text = Alan.ToString();
            Cevre = 4 *Kenar;
            label7.Text = Cevre.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kisaKenar, Alan, Cevre;
            int uzunKenar;

            kisaKenar = Convert.ToInt32(textBox1.Text);
            uzunKenar = Convert.ToInt32(textBox2.Text);

            Alan = kisaKenar * uzunKenar;
            label6.Text = Alan.ToString();
            Cevre = 2 * kisaKenar + 2 * uzunKenar;
            label7.Text = Cevre.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
