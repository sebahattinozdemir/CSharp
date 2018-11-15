using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4Formlar_ArasiGECIS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Blue")
            {

                label3.Text = textBox1.Text + " " + comboBox1.Text + " color:" + "is the color of freedom";
                pictureBox1.BackColor = Color.Blue;

            }
            else if (comboBox1.Text == "Red")
            {

                label3.Text = textBox1.Text + " " + comboBox1.Text + " color:" + "is the color of attraction";
                pictureBox1.BackColor = Color.Red;

            }
            else if (comboBox1.Text == "White")
            {

                label3.Text = textBox1.Text + " " + comboBox1.Text + " color:" + "is the color of innocence";
                pictureBox1.BackColor = Color.White;

            }
            else if (comboBox1.Text == "Black")
            {

                label3.Text = textBox1.Text + " " + comboBox1.Text + " color:" + "is the color of freedom";

                pictureBox1.BackColor = Color.Black;
            }
            else if (comboBox1.Text == "Yellow")
            {

                label3.Text = textBox1.Text + " " + comboBox1.Text + " color:" + "is the color of energy";

                pictureBox1.BackColor = Color.Yellow;
            }
            else if(comboBox1.Text == "Green")
            {

                label3.Text = textBox1.Text + " " + comboBox1.Text + " color:" + "is the color of nature";
                pictureBox1.BackColor = Color.Green;

            }
        }
    }
}
