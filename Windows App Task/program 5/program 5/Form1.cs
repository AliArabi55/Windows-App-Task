using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            int[,] arrA = new int[3, 3];

            arrA[0, 0] = Convert.ToInt32(txtA00.Text);
            arrA[0, 1] = Convert.ToInt32(txtA01.Text);
            arrA[0, 2] = Convert.ToInt32(txtA02.Text);
            arrA[1, 0] = Convert.ToInt32(txtA10.Text);
            arrA[1, 1] = Convert.ToInt32(txtA11.Text);
            arrA[1, 2] = Convert.ToInt32(txtA12.Text);
            arrA[2, 0] = Convert.ToInt32(txtA20.Text);
            arrA[2, 1] = Convert.ToInt32(txtA21.Text);
            arrA[2, 2] = Convert.ToInt32(txtA22.Text);

            int[,] arrB = new int[3, 3];

            arrB[0, 0] = Convert.ToInt32(txtB00.Text);
            arrB[0, 1] = Convert.ToInt32(txtB01.Text);
            arrB[0, 2] = Convert.ToInt32(txtB02.Text);
            arrB[1, 0] = Convert.ToInt32(txtB10.Text);
            arrB[1, 1] = Convert.ToInt32(txtB11.Text);
            arrB[1, 2] = Convert.ToInt32(txtB12.Text);
            arrB[2, 0] = Convert.ToInt32(txtB20.Text);
            arrB[2, 1] = Convert.ToInt32(txtB21.Text);
            arrB[2, 2] = Convert.ToInt32(txtB22.Text);

            int[,] arrAB = new int[3, 3];
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        count += arrA[i, k] * arrB[k, j];
                    }
                    arrAB[i, j] = count;
                    count = 0;
                }
            }

            txtC00.Text = arrAB[0, 0].ToString();
            txtC01.Text = arrAB[0, 1].ToString();
            txtC02.Text = arrAB[0, 2].ToString();
            txtC10.Text = arrAB[1, 0].ToString();
            txtC11.Text = arrAB[1, 1].ToString();
            txtC12.Text = arrAB[1, 2].ToString();
            txtC20.Text = arrAB[2, 0].ToString();
            txtC21.Text = arrAB[2, 1].ToString();
            txtC22.Text = arrAB[2, 2].ToString();
        }
    }
}
