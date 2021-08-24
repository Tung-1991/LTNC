using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tong = 0, a = 0, b = 0, c = 0, d = 0;
            int tong2 = 0;
            if (checkBox1.Checked == true)
            {
                a = 100000;
            }
            if (checkBox2.Checked == true)
            {
                b = 1200000;
            }
            if (checkBox3.Checked == true)
            {
                c = 150000;
            }
            if (checkBox4.Checked == true)
            {
                d = 100000;
            }
            if (numericUpDown1.Value > 0)
            {
                tong2 = (int)(numericUpDown1.Value * 90000);
            }
            tong = a + b + c + d + tong2;
            textBox2.Text = tong.ToString();
        }
    }
}
