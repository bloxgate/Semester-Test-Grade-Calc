﻿namespace Semester_Grade_Calculator
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
            this.FQG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SQG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DSG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RSTS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FQG
            // 
            this.FQG.Location = new System.Drawing.Point(190, 37);
            this.FQG.Name = "FQG";
            this.FQG.Size = new System.Drawing.Size(80, 22);
            this.FQG.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Quarter Grade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SQG
            // 
            this.SQG.Location = new System.Drawing.Point(190, 65);
            this.SQG.Name = "SQG";
            this.SQG.Size = new System.Drawing.Size(80, 22);
            this.SQG.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Quarter Grade";
            // 
            // DSG
            // 
            this.DSG.Location = new System.Drawing.Point(190, 93);
            this.DSG.Name = "DSG";
            this.DSG.Size = new System.Drawing.Size(80, 22);
            this.DSG.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desired Semester Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Required Semester Test Score";
            // 
            // RSTS
            // 
            this.RSTS.Location = new System.Drawing.Point(249, 169);
            this.RSTS.Name = "RSTS";
            this.RSTS.Size = new System.Drawing.Size(100, 22);
            this.RSTS.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "DO THE MATH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RSTS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DSG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SQG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FQG);
            this.Name = "Form1";
            this.Text = "Semester Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FQG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SQG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DSG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RSTS;
        private System.Windows.Forms.Button button1;
    }
}

