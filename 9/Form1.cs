﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders9___alarm_programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for(int i = 0; i< 25; i++)
            {
                comboBox1.Items.Add(i);
            }

            for(int j = 0; j < 60;j++)
            {

                comboBox2.Items.Add(j);
            }

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.Minute.ToString();
            label6.Text = DateTime.Now.Hour.ToString();
            if (comboBox1.Text == label6.Text && comboBox2.Text == label5.Text)
            {
                timer1.Enabled=false;              
                axWindowsMediaPlayer1.URL = "C:\\Users\\s.ozdemir\\Desktop\\c.mp4";
            }
        }
    }
}
