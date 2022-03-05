using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int count = 0;
        int angka1 = 0;
        int angka2 = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void btntam_Click(object sender, EventArgs e)
        {
            count = 1;
            angka1 = int.Parse(textBox1.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void btnsam_Click(object sender, EventArgs e)
        {
            textBox1.Text = (angka1 + int.Parse(textBox1.Text)).ToString();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
