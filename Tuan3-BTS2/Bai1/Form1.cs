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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //c1
            ListView.SelectedListViewItemCollection item;
            item = listView1.SelectedItems;
            if(item.Count > 0)
            {
                string str1 = item[0].Text;
                string str2 = item[0].SubItems[1].Text;
                MessageBox.Show(str1 + "-" + str2);
            }
            //c2
            ListView.SelectedListViewItemCollection a = listView1.SelectedItems;
            for(int i =0; i < a[0].SubItems.Count; i++)
            {
                MessageBox.Show(a[0].SubItems[i].Text);
            }
        }
    }
}
