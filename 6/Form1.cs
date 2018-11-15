using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders6_ygsLys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce, matematik, sosyal, fen;
            double ygs1, ygs2, ygs3, ygs4,ygs5,ygs6;
            turkce    = Convert.ToDouble(textBox1.Text);
            matematik = Convert.ToDouble(textBox1.Text);
            sosyal    = Convert.ToDouble(textBox1.Text);
            fen       = Convert.ToDouble(textBox1.Text);

            ygs1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 3.998) + (fen * 2.999);
            label11.Text = Convert.ToString(ygs1);
            ygs2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 2.999) + (fen * 3.998);
            label12.Text = Convert.ToString(ygs2);
            ygs3 = 100.160 + (turkce * 3.998) + (sosyal * 2.999) + (matematik * 1.999) + (fen * 1);
            label13.Text = Convert.ToString(ygs3);
            ygs4 = 100.160 + (turkce * 2.999) + (sosyal * 3.998) + (matematik * 1.999) + (fen * 1);
            label14.Text = Convert.ToString(ygs4);
            ygs5 = 100.160 + (turkce * 3.698) + (sosyal * 1.999) + (matematik * 3.299) + (fen * 1);
            label15.Text = Convert.ToString(ygs5);
            ygs6 = 100.160 + (turkce * 3.298) + (sosyal * 1) + (matematik * 3.699) + (fen * 1.999);
            label16.Text = Convert.ToString(ygs6);



        }
    }
}
