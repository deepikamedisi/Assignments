﻿
namespace Remotingclient
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnhighestnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(144, 51);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(98, 20);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Enter Num 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(144, 158);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(96, 20);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Enter num 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(338, 51);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 26);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(338, 152);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 26);
            this.txtnum2.TabIndex = 3;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(556, 102);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 26);
            this.txtresult.TabIndex = 4;
            // 
            // btnhighestnum
            // 
            this.btnhighestnum.Location = new System.Drawing.Point(232, 285);
            this.btnhighestnum.Name = "btnhighestnum";
            this.btnhighestnum.Size = new System.Drawing.Size(180, 37);
            this.btnhighestnum.TabIndex = 5;
            this.btnhighestnum.Text = "Highest number";
            this.btnhighestnum.UseVisualStyleBackColor = true;
            this.btnhighestnum.Click += new System.EventHandler(this.btnhighestnum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhighestnum);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnhighestnum;
    }
}

