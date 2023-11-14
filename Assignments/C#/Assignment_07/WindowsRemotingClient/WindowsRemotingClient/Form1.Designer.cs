
namespace WindowsRemotingClient
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.btnHighest = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(258, 34);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(115, 26);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(258, 143);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(115, 26);
            this.txtNum2.TabIndex = 1;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(36, 37);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(121, 20);
            this.lblnum1.TabIndex = 2;
            this.lblnum1.Text = "Enter Number 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(36, 149);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(121, 20);
            this.lblnum2.TabIndex = 3;
            this.lblnum2.Text = "Enter Number 2";
            // 
            // btnHighest
            // 
            this.btnHighest.Location = new System.Drawing.Point(12, 252);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(182, 45);
            this.btnHighest.TabIndex = 4;
            this.btnHighest.Text = "Highest Number";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(516, 75);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(143, 26);
            this.txtresult.TabIndex = 5;
            // 
            // btnSmallest
            // 
            this.btnSmallest.Location = new System.Drawing.Point(228, 252);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(182, 49);
            this.btnSmallest.TabIndex = 6;
            this.btnSmallest.Text = "Smallest Number";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(449, 256);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(198, 40);
            this.btnMultiplication.TabIndex = 7;
            this.btnMultiplication.Text = "Multiplication Number";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.Location = new System.Drawing.Point(709, 255);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(175, 43);
            this.btnRemainder.TabIndex = 8;
            this.btnRemainder.Text = "Remainder";
            this.btnRemainder.UseVisualStyleBackColor = true;
            this.btnRemainder.Click += new System.EventHandler(this.btnRemainder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 686);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSmallest);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnRemainder;
    }
}

