using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program4
{
    public partial class Form1 : Form
    {
        int y;
        public Form1()
        {
            InitializeComponent();
            lstnumber.Items.Add("--------------------------------------------------------------");
            lstnumber.Items.Add(" i\t\t i*2\t\t i*i");
            lstnumber.Items.Add("--------------------------------------------------------------");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty event handler
        }
    }
}
