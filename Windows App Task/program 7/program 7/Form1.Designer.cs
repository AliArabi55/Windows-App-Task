namespace program_7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPopulate = new System.Windows.Forms.Button();
            this.txtMatces = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSet2 = new System.Windows.Forms.ListBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSet1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulate.Location = new System.Drawing.Point(433, 42);
            this.btnPopulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(347, 108);
            this.btnPopulate.TabIndex = 18;
            this.btnPopulate.Text = "Populate lists with 15 different integer numbers between 1 and 100\r\n\r\n";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // txtMatces
            // 
            this.txtMatces.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatces.Location = new System.Drawing.Point(423, 426);
            this.txtMatces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatces.Name = "txtMatces";
            this.txtMatces.Size = new System.Drawing.Size(356, 38);
            this.txtMatces.TabIndex = 17;
            this.txtMatces.TextChanged += new System.EventHandler(this.txtMatces_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Matches :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "No. of matches :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Set 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lstSet2
            // 
            this.lstSet2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSet2.FormattingEnabled = true;
            this.lstSet2.ItemHeight = 26;
            this.lstSet2.Location = new System.Drawing.Point(255, 42);
            this.lstSet2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSet2.Name = "lstSet2";
            this.lstSet2.Size = new System.Drawing.Size(159, 394);
            this.lstSet2.TabIndex = 13;
            this.lstSet2.SelectedIndexChanged += new System.EventHandler(this.lstSet2_SelectedIndexChanged);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(652, 273);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(132, 38);
            this.txtNum.TabIndex = 12;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Set 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstSet1
            // 
            this.lstSet1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSet1.FormattingEnabled = true;
            this.lstSet1.ItemHeight = 26;
            this.lstSet1.Location = new System.Drawing.Point(63, 42);
            this.lstSet1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSet1.Name = "lstSet1";
            this.lstSet1.Size = new System.Drawing.Size(159, 394);
            this.lstSet1.TabIndex = 10;
            this.lstSet1.SelectedIndexChanged += new System.EventHandler(this.lstSet1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 475);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.txtMatces);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSet2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSet1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.TextBox txtMatces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSet2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSet1;
    }
}

