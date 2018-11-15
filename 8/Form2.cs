using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adana_Seyahat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add("1");
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
                listBox5.Items.Add(radioButton1.Text);
            else
                listBox5.Items.Add(radioButton2.Text);

            listBox6.Items.Add(comboBox2.Text);

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add("2");
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
                listBox5.Items.Add(radioButton1.Text);
            else
                listBox5.Items.Add(radioButton2.Text);

            listBox6.Items.Add(comboBox2.Text);

            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add("3");
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
                listBox5.Items.Add(radioButton1.Text);
            else
                listBox5.Items.Add(radioButton2.Text);

            listBox6.Items.Add(comboBox2.Text);

            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add("4");
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
                listBox5.Items.Add(radioButton1.Text);
            else
                listBox5.Items.Add(radioButton2.Text);

            listBox6.Items.Add(comboBox2.Text);

            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add("5");
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
                listBox5.Items.Add(radioButton1.Text);
            else
                listBox5.Items.Add(radioButton2.Text);

            listBox6.Items.Add(comboBox2.Text);

            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add("6");
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
                listBox5.Items.Add(radioButton1.Text);
            else
                listBox5.Items.Add(radioButton2.Text);

            listBox6.Items.Add(comboBox2.Text);

            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add("1");
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
                listBox5.Items.Add(radioButton1.Text);
            else
                listBox5.Items.Add(radioButton2.Text);

            listBox6.Items.Add(comboBox2.Text);

            button7.Enabled = false; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

        }
    }
}
