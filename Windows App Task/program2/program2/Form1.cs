using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (x < 10)
            {
                lbladdandsub.Text = (++x).ToString();
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (x > -10)
            {
                lbladdandsub.Text = (--x).ToString();
            }
        }
    }
}
