using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4buyuklerTURNAVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        int gs = 0;
        int fb = 0;
        int bjk = 0;
        int ts = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = rnd.Next(0,5);
            int t2 = rnd.Next(0, 5);
            int t3 = rnd.Next(0, 5);
            int t4 = rnd.Next(0, 5);

            label3.Text = Convert.ToString(t1);
            label4.Text = Convert.ToString(t2);
            label6.Text = Convert.ToString(t3);
            label5.Text = Convert.ToString(t4);


            if (t1 > t2)
            {
                gs += 3;

            }
            else if (t1 == t2)
            {
                gs += 1;
                fb += 1;
            }

            else
            {
                fb += 3;
            }

                       
            if (t3 > t4)
            {
                bjk += 3;

            }
            else if (t3 == t4)
            {
                bjk += 1;
                ts += 1;
            }

            else
            {
                ts += 3;
            }

            label35.Text = Convert.ToString(gs);
            label36.Text = Convert.ToString(fb);
            label37.Text = Convert.ToString(bjk);
            label38.Text = Convert.ToString(ts);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t1 = rnd.Next(0, 5);
            int t2 = rnd.Next(0, 5);
            int t3 = rnd.Next(0, 5);
            int t4 = rnd.Next(0, 5);

            label18.Text = Convert.ToString(t1);
            label17.Text = Convert.ToString(t2);
            label14.Text = Convert.ToString(t3);
            label13.Text = Convert.ToString(t4);


            if (t1 > t2)
            {
                ts += 3;

            }
            else if (t1 == t2)
            {
                ts += 1;
                fb += 1;
            }

            else
            {
                fb += 3;
            }


            if (t3 > t4)
            {
                gs += 3;

            }
            else if (t3 == t4)
            {
                bjk += 1;
                gs += 1;
            }

            else
            {
                bjk += 3;
            }

            label35.Text = Convert.ToString(gs);
            label36.Text = Convert.ToString(fb);
            label37.Text = Convert.ToString(bjk);
            label38.Text = Convert.ToString(ts);



        }

        private void button3_Click(object sender, EventArgs e)
        {

            int t1 = rnd.Next(0, 5);
            int t2 = rnd.Next(0, 5);
            int t3 = rnd.Next(0, 5);
            int t4 = rnd.Next(0, 5);

            label28.Text = Convert.ToString(t1);
            label27.Text = Convert.ToString(t2);
            label24.Text = Convert.ToString(t3);
            label23.Text = Convert.ToString(t4);

            if (t1 > t2)
            {
                ts += 3;

            }
            else if (t1 == t2)
            {
                ts += 1;
                gs += 1;
            }

            else
            {
                gs += 3;
            }


            if (t3 > t4)
            {
                fb += 3;

            }
            else if (t3 == t4)
            {
                fb += 1;
                bjk += 1;
            }

            else
            {
                bjk += 3;
            }

            label35.Text = Convert.ToString(gs);
            label36.Text = Convert.ToString(fb);
            label37.Text = Convert.ToString(bjk);
            label38.Text = Convert.ToString(ts);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int gs = Convert.ToInt32(label35.Text);
            int fb = Convert.ToInt32(label36.Text);
            int bjk = Convert.ToInt32(label37.Text);
            int ts = Convert.ToInt32(label38.Text);

            if(gs>fb && gs > ts && gs > bjk)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\1.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\s.ozdemir\\Desktop\\5.mp4";

                label39.Text = "Sampiyon Galatasaray";
            }

            if (fb > gs && fb > ts && fb > bjk)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\2.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\s.ozdemir\\Desktop\\5.mp4";

                label39.Text = "Sampiyon FenerBahce";
            }

            if (bjk > fb && bjk > ts && bjk > gs)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\3.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\s.ozdemir\\Desktop\\5.mp4";

                label39.Text = "Sampiyon Besiktas";
            }

            if (ts > fb && ts > gs && ts > bjk)
            {
                pictureBox1.ImageLocation = "C:\\Users\\s.ozdemir\\Desktop\\4.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\s.ozdemir\\Desktop\\5.mp4";

                label39.Text = "Sampiyon Trabzon";
            }
        }
    }
}
