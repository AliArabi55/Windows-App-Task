using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program_8
{
    public partial class Form1 : Form
    {
        int[] arr = new int[11];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstArray.Items.Clear();

            Random rn = new Random();

            for (int i = 0; i < 11; i++)
            {
                arr[i] = rn.Next(1, 100);
            }

            int temp;
            for (int i = 0; i < 11; i++)
            {
                for (int j = i + 1; j < 11; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                lstArray.Items.Add(arr[i].ToString());
            }
        }
    }
}
