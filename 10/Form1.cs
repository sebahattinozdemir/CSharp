using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_9_trafik_lambalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int sayi;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayi = Convert.ToInt32(label1.Text);
            sayi++;
            label1.Text = sayi.ToString();
            if(sayi < 30)
            {
                button1.BackColor = Color.Red;


            }
            if(sayi>=30 && sayi <= 50)
            {
                button2.BackColor = Color.Yellow;
            }

            if(sayi>50 && sayi <= 70)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;

            }
            if(sayi == 70)
            {
                button3.BackColor = Color.Gray;
                sayi = 0;
                label1.Text = sayi.ToString();
            }
         
        }

      
    }
}
