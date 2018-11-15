using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, x1,sum ;
            x = Convert.ToInt32(textBox1.Text);
            x1 = Convert.ToInt32(textBox2.Text);
            sum = x + x1;
            textBox3.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, x1, multiply;
            x = Convert.ToInt32(textBox4.Text);
            x1 = Convert.ToInt32(textBox5.Text);
            multiply = x * x1;
            textBox6.Text = multiply.ToString();


        }
    }
}
