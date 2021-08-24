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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection a = checkedListBox1.CheckedItems;
            string str = "check item: \n";
            foreach (object i in a)
            {
                str += i.ToString();
                str += "\n";
            }
            MessageBox.Show(str);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label1.Text = progressBar1.Value.ToString() + "%";
        }
    }
}
