using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BT_Thu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection item;
            item = listView1.SelectedItems;
            if (item.Count > 0)
            {
                string str1 = item[0].Text;
                string str2 = item[0].SubItems[1].Text;
                MessageBox.Show(str1 + "-" + str2);
            }
        }
    }
}
