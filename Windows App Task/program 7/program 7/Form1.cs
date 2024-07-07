using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            lstSet1.Items.Clear();
            lstSet2.Items.Clear();

            int[] set1 = new int[15];
            int[] set2 = new int[15];

            Random rn = new Random();
            for (int i = 0; i < 15; i++)
            {
                set1[i] = rn.Next(1, 100);
                set2[i] = rn.Next(1, 100);
                lstSet1.Items.Add(set1[i].ToString());
                lstSet2.Items.Add(set2[i].ToString());
            }

            int count = 0;
            string mat = "";
            for (int f = 0; f < 15; f++)
            {
                for (int k = 0; k < 15; k++)
                {
                    if (set1[f] == set2[k])
                    {
                        count++;
                        mat += set1[f].ToString() + ", ";
                    }
                }
            }
            txtNum.Text = count.ToString();
            txtMatces.Text = mat;
        }

        private void lstSet1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lstSet2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtMatces_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
