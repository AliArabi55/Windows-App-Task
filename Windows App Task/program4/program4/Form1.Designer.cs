namespace program4
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
            this.lstnumber = new System.Windows.Forms.ListBox();
            this.btngo = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstnumber
            // 
            this.lstnumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstnumber.FormattingEnabled = true;
            this.lstnumber.ItemHeight = 22;
            this.lstnumber.Location = new System.Drawing.Point(453, 36);
            this.lstnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstnumber.Name = "lstnumber";
            this.lstnumber.Size = new System.Drawing.Size(435, 422);
            this.lstnumber.TabIndex = 9;
            this.lstnumber.SelectedIndexChanged += new System.EventHandler(this.lstnumber_SelectedIndexChanged);
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(321, 98);
            this.btngo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(87, 39);
            this.btngo.TabIndex = 8;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(107, 143);
            this.btnsub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(87, 39);
            this.btnsub.TabIndex = 7;
            this.btnsub.Text = "<< -";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(227, 143);
            this.btnplus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(87, 39);
            this.btnplus.TabIndex = 6;
            this.btnplus.Text = "+ >>";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(107, 98);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(205, 36);
            this.txtnumber.TabIndex = 5;
            this.txtnumber.Text = "0";
            this.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 500);
            this.Controls.Add(this.lstnumber);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtnumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstnumber;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.TextBox txtnumber;
    }
}

