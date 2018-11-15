using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5_RadyoProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*to get the newest radio mms adresis wrute google 2018 radio mms adresleri*/


     

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*radyo romantik turk*/
            axWindowsMediaPlayer1.URL = "http://yayin.romantikturk.com.tr:6042";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://stream2.taksimbilisim.com:8010/;";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyodejavu.canliyayinda.com:8054/";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
