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

        private void btngo_Click(object sender, EventArgs e)
        {
            lstnumber.Items.Clear();
            lstnumber.Items.Add("--------------------------------------------------------------");
            lstnumber.Items.Add(" i\t\t i*2\t\t i*i");
            lstnumber.Items.Add("--------------------------------------------------------------");

            int number = int.Parse(txtnumber.Text);

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 1; i <= number; i++)
            {
                lstnumber.Items.Add(i + "\t\t " + i * 2 + "\t\t" + i * i);
                sum1 += i;
                sum2 += (i * 2);
                sum3 += (i * i);
            }
            lstnumber.Items.Add("--------------------------------------------------------------");
            lstnumber.Items.Add(sum1 + "\t\t " + sum2 + "\t\t" + sum3);
        }
    }
}
