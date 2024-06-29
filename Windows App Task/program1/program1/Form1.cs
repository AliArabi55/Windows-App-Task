using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int x;
            bool flag = int.TryParse(txtnumber.Text, out x);
            if (flag == false)
            {
                MessageBox.Show("Enter Integer number :)");
                txtnumber.Clear();
                txtnumber.Focus();
                return;
            }
            if (x % 3 == 0)
            {
                lst3.Items.Add(x);
            }
            if (x % 5 == 0)
            {
                lst5.Items.Add(x);
            }
            if (x % 7 == 0)
            {
                lst7.Items.Add(x);
            }
            if (x % 3 != 0 && x % 5 != 0 && x % 7 != 0)
            {
                lstall.Items.Add(x);
            }
            txtnumber.Clear();
            txtnumber.Focus();
        }
    }
}
