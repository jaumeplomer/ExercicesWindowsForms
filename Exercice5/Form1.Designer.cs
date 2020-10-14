namespace Exercice5
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
            this.checkBoxPangolin = new System.Windows.Forms.CheckBox();
            this.checkBoxCoati = new System.Windows.Forms.CheckBox();
            this.checkBoxBat = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxPangolin
            // 
            this.checkBoxPangolin.AutoSize = true;
            this.checkBoxPangolin.Location = new System.Drawing.Point(51, 68);
            this.checkBoxPangolin.Name = "checkBoxPangolin";
            this.checkBoxPangolin.Size = new System.Drawing.Size(85, 21);
            this.checkBoxPangolin.TabIndex = 0;
            this.checkBoxPangolin.Text = "Pangolin";
            this.checkBoxPangolin.UseVisualStyleBackColor = true;
            this.checkBoxPangolin.CheckedChanged += new System.EventHandler(this.checkBoxPangolin_CheckedChanged);
            // 
            // checkBoxCoati
            // 
            this.checkBoxCoati.AutoSize = true;
            this.checkBoxCoati.Location = new System.Drawing.Point(51, 132);
            this.checkBoxCoati.Name = "checkBoxCoati";
            this.checkBoxCoati.Size = new System.Drawing.Size(62, 21);
            this.checkBoxCoati.TabIndex = 1;
            this.checkBoxCoati.Text = "Coati";
            this.checkBoxCoati.UseVisualStyleBackColor = true;
            this.checkBoxCoati.CheckedChanged += new System.EventHandler(this.checkBoxCoati_CheckedChanged);
            // 
            // checkBoxBat
            // 
            this.checkBoxBat.AutoSize = true;
            this.checkBoxBat.Location = new System.Drawing.Point(51, 195);
            this.checkBoxBat.Name = "checkBoxBat";
            this.checkBoxBat.Size = new System.Drawing.Size(51, 21);
            this.checkBoxBat.TabIndex = 2;
            this.checkBoxBat.Text = "Bat";
            this.checkBoxBat.UseVisualStyleBackColor = true;
            this.checkBoxBat.CheckedChanged += new System.EventHandler(this.checkBoxBat_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxBat);
            this.Controls.Add(this.checkBoxCoati);
            this.Controls.Add(this.checkBoxPangolin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPangolin;
        private System.Windows.Forms.CheckBox checkBoxCoati;
        private System.Windows.Forms.CheckBox checkBoxBat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

