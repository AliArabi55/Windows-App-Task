using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            bool num1 = int.TryParse(txtnumber.Text, out x);
            bool num2 = double.TryParse(txtnumber.Text, out y);
            if (num1 == true)
            {
                lstint.Items.Add(x);
            }
            else if (num2 == true)
            {
                lstfloat.Items.Add(y);
            }
            else
            {
                lststring.Items.Add(txtnumber.Text);
            }
            txtnumber.Clear();
            txtnumber.Focus();
        }

        private void lststring_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }
    }
}
