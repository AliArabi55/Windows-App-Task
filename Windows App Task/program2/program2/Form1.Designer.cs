namespace program2
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
            this.btnsub = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbladdandsub = new System.Windows.Forms.Label();
            this.lbltxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(381, 322);
            this.btnsub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(100, 37);
            this.btnsub.TabIndex = 11;
            this.btnsub.Text = "اطرح";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(489, 322);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 37);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "اجمع";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbladdandsub
            // 
            this.lbladdandsub.BackColor = System.Drawing.SystemColors.Control;
            this.lbladdandsub.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdandsub.Location = new System.Drawing.Point(381, 257);
            this.lbladdandsub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdandsub.Name = "lbladdandsub";
            this.lbladdandsub.Size = new System.Drawing.Size(208, 36);
            this.lbladdandsub.TabIndex = 9;
            this.lbladdandsub.Text = "0";
            this.lbladdandsub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.Location = new System.Drawing.Point(452, 206);
            this.lbltxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(57, 29);
            this.lbltxt.TabIndex = 8;
            this.lbltxt.Text = "عداد";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 565);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbladdandsub);
            this.Controls.Add(this.lbltxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lbladdandsub;
        private System.Windows.Forms.Label lbltxt;
    }
}

