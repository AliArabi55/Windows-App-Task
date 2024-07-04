using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program_6
{
    public partial class Form1 : Form
    {
        int addarray = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddArray_Click(object sender, EventArgs e)
        {
            txtAddArray.Text = addarray.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstgenerate.Items.Clear();

            int number = Int32.Parse(txtRNumber.Text);
            int bet = int.Parse(txtBetween.Text);
            int a = int.Parse(txtAnd.Text);
        }
    }
}
