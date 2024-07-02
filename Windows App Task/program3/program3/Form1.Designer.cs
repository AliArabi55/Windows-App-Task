namespace program3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lststring = new System.Windows.Forms.ListBox();
            this.lstfloat = new System.Windows.Forms.ListBox();
            this.lstint = new System.Windows.Forms.ListBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "نص";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "عدد بعلامه عشرية";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "عدد صحيح";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lststring
            // 
            this.lststring.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lststring.FormattingEnabled = true;
            this.lststring.ItemHeight = 24;
            this.lststring.Location = new System.Drawing.Point(531, 156);
            this.lststring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lststring.Name = "lststring";
            this.lststring.Size = new System.Drawing.Size(177, 196);
            this.lststring.TabIndex = 12;
            this.lststring.SelectedIndexChanged += new System.EventHandler(this.lststring_SelectedIndexChanged);
            // 
            // lstfloat
            // 
            this.lstfloat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstfloat.FormattingEnabled = true;
            this.lstfloat.ItemHeight = 24;
            this.lstfloat.Location = new System.Drawing.Point(304, 156);
            this.lstfloat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstfloat.Name = "lstfloat";
            this.lstfloat.Size = new System.Drawing.Size(177, 196);
            this.lstfloat.TabIndex = 11;
            this.lstfloat.SelectedIndexChanged += new System.EventHandler(this.lstfloat_SelectedIndexChanged);
            // 
            // lstint
            // 
            this.lstint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstint.FormattingEnabled = true;
            this.lstint.ItemHeight = 24;
            this.lstint.Location = new System.Drawing.Point(75, 156);
            this.lstint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstint.Name = "lstint";
            this.lstint.Size = new System.Drawing.Size(177, 196);
            this.lstint.TabIndex = 10;
            this.lstint.SelectedIndexChanged += new System.EventHandler(this.lstint_SelectedIndexChanged);
            // 
            // btncheck
            // 
            this.btncheck.AutoSize = true;
            this.btncheck.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(237, 59);
            this.btncheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(343, 41);
            this.btncheck.TabIndex = 9;
            this.btncheck.Text = "ضع العدد في القائمه الصحيحه";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(304, 15);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(200, 36);
            this.txtnumber.TabIndex = 8;
            this.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lststring);
            this.Controls.Add(this.lstfloat);
            this.Controls.Add(this.lstint);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.txtnumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lststring;
        private System.Windows.Forms.ListBox lstfloat;
        private System.Windows.Forms.ListBox lstint;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.TextBox txtnumber;
    }
}

