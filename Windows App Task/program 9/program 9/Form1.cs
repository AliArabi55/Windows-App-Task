using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program_9
{
    public partial class Form1 : Form
    {
        int[] arr = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            lstArray.Items.Clear();
            Random rn = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rn.Next(1, 50);
                lstArray.Items.Add(arr[i].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            bool flag = false;
            string a = "";
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == x)
                {
                    flag = true;
                    a += i.ToString() + ",";
                    txtLocation.Text = a;
                }
            }
            if (flag == false)
            {
                txtLocation.Text = "Not";
            }
        }
    }
}
