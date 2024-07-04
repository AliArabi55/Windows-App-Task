namespace program_6
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAddArray = new System.Windows.Forms.TextBox();
            this.btnAddArray = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnd = new System.Windows.Forms.TextBox();
            this.txtBetween = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRNumber = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lstgenerate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(284, 474);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 39);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAddArray
            // 
            this.txtAddArray.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddArray.Enabled = false;
            this.txtAddArray.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddArray.Location = new System.Drawing.Point(563, 375);
            this.txtAddArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddArray.Name = "txtAddArray";
            this.txtAddArray.Size = new System.Drawing.Size(156, 35);
            this.txtAddArray.TabIndex = 20;
            this.txtAddArray.TextChanged += new System.EventHandler(this.txtAddArray_TextChanged);
            // 
            // btnAddArray
            // 
            this.btnAddArray.AutoSize = true;
            this.btnAddArray.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArray.Location = new System.Drawing.Point(305, 372);
            this.btnAddArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddArray.Name = "btnAddArray";
            this.btnAddArray.Size = new System.Drawing.Size(249, 39);
            this.btnAddArray.TabIndex = 19;
            this.btnAddArray.Text = "Add Array Members";
            this.btnAddArray.UseVisualStyleBackColor = true;
            this.btnAddArray.Click += new System.EventHandler(this.btnAddArray_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "and";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "between";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAnd
            // 
            this.txtAnd.BackColor = System.Drawing.SystemColors.Info;
            this.txtAnd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnd.Location = new System.Drawing.Point(441, 156);
            this.txtAnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnd.Name = "txtAnd";
            this.txtAnd.Size = new System.Drawing.Size(99, 35);
            this.txtAnd.TabIndex = 16;
            this.txtAnd.TextChanged += new System.EventHandler(this.txtAnd_TextChanged);
            // 
            // txtBetween
            // 
            this.txtBetween.BackColor = System.Drawing.SystemColors.Info;
            this.txtBetween.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetween.Location = new System.Drawing.Point(441, 98);
            this.txtBetween.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBetween.Name = "txtBetween";
            this.txtBetween.Size = new System.Drawing.Size(99, 35);
            this.txtBetween.TabIndex = 15;
            this.txtBetween.TextChanged += new System.EventHandler(this.txtBetween_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Positive Integer Random Numbers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRNumber
            // 
            this.txtRNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtRNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRNumber.Location = new System.Drawing.Point(441, 43);
            this.txtRNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRNumber.Name = "txtRNumber";
            this.txtRNumber.Size = new System.Drawing.Size(99, 35);
            this.txtRNumber.TabIndex = 13;
            this.txtRNumber.TextChanged += new System.EventHandler(this.txtRNumber_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(305, 41);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 39);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lstgenerate
            // 
            this.lstgenerate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstgenerate.FormattingEnabled = true;
            this.lstgenerate.ItemHeight = 23;
            this.lstgenerate.Location = new System.Drawing.Point(116, 41);
            this.lstgenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstgenerate.Name = "lstgenerate";
            this.lstgenerate.Size = new System.Drawing.Size(159, 464);
            this.lstgenerate.TabIndex = 11;
            this.lstgenerate.SelectedIndexChanged += new System.EventHandler(this.lstgenerate_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 555);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAddArray);
            this.Controls.Add(this.btnAddArray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnd);
            this.Controls.Add(this.txtBetween);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRNumber);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstgenerate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAddArray;
        private System.Windows.Forms.Button btnAddArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnd;
        private System.Windows.Forms.TextBox txtBetween;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lstgenerate;

    }
}

