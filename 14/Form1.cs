using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int i = 0;
        static int j = 0;
      

        Random rnd = new Random();
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
           
            if(dice1 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\1.jpg";
            }
            if (dice1 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\2.jpg";
            }
            if (dice1 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\3.jpg";
            }
            if (dice1 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\4.jpg";
            }
            if (dice1 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\5.jpg";
            }
            if (dice1 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\6.jpg";
            }

            if (dice2 == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\1.jpg";
            }
            if (dice2 == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\2.jpg";
            }
            if (dice2 == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\3.jpg";
            }
            if (dice2 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\4.jpg";
            }
            if (dice2 == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\5.jpg";
            }
            if (dice2 == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\6.jpg";
            }

            label2.Text = dice1.ToString();
            label4.Text = dice2.ToString();
            sum = sum + (dice1 + dice2);

            label6.Text = sum.ToString();

            button1.Enabled = false;
            button2.Enabled = true;
            if (sum > sum1 && sum >= 40)
            {
                label19.Show();
                label19.Text = "Player 1 wins.";
                i++;
                label17.Text = i.ToString();
            }
            else if (sum1 > sum && sum1 >= 40)
            {
                label19.Show();
                label19.Text = "Player 2 wins.";
                j++;
                label17.Text = j.ToString();
            }
        }
        int sum1 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            if (dice1 == 1)
            {
                pictureBox4.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\1.jpg";
            }
            if (dice1 == 2)
            {
                pictureBox4.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\2.jpg";
            }
            if (dice1 == 3)
            {
                pictureBox4.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\3.jpg";
            }
            if (dice1 == 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\4.jpg";
            }
            if (dice1 == 5)
            {
                pictureBox4.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\5.jpg";
            }
            if (dice1 == 6)
            {
                pictureBox4.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\6.jpg";
            }

            if (dice2 == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\1.jpg";
            }
            if (dice2 == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\2.jpg";
            }
            if (dice2 == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\3.jpg";
            }
            if (dice2 == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\4.jpg";
            }
            if (dice2 == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\5.jpg";
            }
            if (dice2 == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\6.jpg";
            }

            label11.Text = dice1.ToString();
            label9.Text = dice2.ToString();
            sum1 = sum1 + (dice1 + dice2);

            label7.Text = sum1.ToString();
            button2.Enabled = false;
            button1.Enabled = true;

            if (sum > sum1 && sum >= 40)
            {
                label19.Show();
                label19.Text = "Player 1 wins.";
                i++;
                label17.Text = i.ToString();
            }
            else if (sum1 > sum && sum1 >= 40)
            {
                label19.Show();
                label19.Text = "Player 2 wins.";
                j++;
                label17.Text = j.ToString();
            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label19.Hide();
        }
    }
}
