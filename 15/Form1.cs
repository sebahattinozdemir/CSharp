using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisi
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

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        int firstHorse;
        int secondHorse;
        int thirdHorse;
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time=Convert.ToInt32(label7.Text);

            time++;
            label7.Text = time.ToString();

           
            firstHorse = pictureBox1.Left;
            secondHorse = pictureBox2.Left;
            thirdHorse = pictureBox3.Left;

            int f = rnd.Next(10, 20);
            int s = rnd.Next(10, 20);
            int t = rnd.Next(10, 20);

            firstHorse += f;
            secondHorse += s;
            thirdHorse += t;

            pictureBox1.Left = firstHorse;
            pictureBox2.Left = secondHorse;
            pictureBox3.Left = thirdHorse;

            if(pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox2.Left)
            {
                label11.Text = "1 numarali at one gecti";
            }

            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label11.Text = "2 numarali at one gecti";
            }

            if (pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left)
            {
                label11.Text = "3 numarali at one gecti";
            }

            if (label4.Left <= pictureBox1.Left)
            {
                time = 0;

                timer1.Stop();
                label5.Text = "1 NUMARALI AT KAZANDI";

                
            }

            if (label4.Left <= pictureBox2.Left)
            {
                time = 0;

                timer1.Stop();
                label5.Text = "2 NUMARALI AT KAZANDI";


            }
            if (label4.Left <= pictureBox3.Left)
            {
                time = 0;
                
                timer1.Stop();
                label5.Text = "3 NUMARALI AT KAZANDI";
                

            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
