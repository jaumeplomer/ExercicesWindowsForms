﻿namespace Exercice3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.operand1 = new System.Windows.Forms.TextBox();
            this.operand2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(30, 199);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 37);
            this.sumButton.TabIndex = 3;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(395, 202);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(84, 34);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // operand1
            // 
            this.operand1.Location = new System.Drawing.Point(134, 50);
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(119, 22);
            this.operand1.TabIndex = 5;
            this.operand1.TextChanged += new System.EventHandler(this.operand1_TextChanged_1);
            // 
            // operand2
            // 
            this.operand2.Location = new System.Drawing.Point(133, 119);
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(119, 22);
            this.operand2.TabIndex = 6;
            this.operand2.TextChanged += new System.EventHandler(this.operand2_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(141, 283);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(110, 22);
            this.result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.operand2);
            this.Controls.Add(this.operand1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox operand1;
        private System.Windows.Forms.TextBox operand2;
        private System.Windows.Forms.TextBox result;
    }
}

