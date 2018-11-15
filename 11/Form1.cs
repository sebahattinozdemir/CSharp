using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders9TimerKullanimi
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
        int saniye =0;
        int salise = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            int salise = Convert.ToInt32(label3.Text);
            salise++;
            label3.Text = salise.ToString();
            timer1.Interval = 100;
            if(salise == 10)
            {

                salise = 0;
                label4.Text = salise.ToString();
                saniye++;
                label4.Text = saniye.ToString();
                timer1.Interval = 100;
            }


        }
    }
}
