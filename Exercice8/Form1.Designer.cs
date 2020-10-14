namespace Exercice8
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.classroom1 = new System.Windows.Forms.Button();
            this.classroom2 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(34, 30);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(171, 228);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // classroom1
            // 
            this.classroom1.Location = new System.Drawing.Point(40, 287);
            this.classroom1.Name = "classroom1";
            this.classroom1.Size = new System.Drawing.Size(114, 37);
            this.classroom1.TabIndex = 1;
            this.classroom1.Text = "Classroom 1";
            this.classroom1.UseVisualStyleBackColor = true;
            this.classroom1.Click += new System.EventHandler(this.classroom1_Click);
            // 
            // classroom2
            // 
            this.classroom2.Location = new System.Drawing.Point(40, 355);
            this.classroom2.Name = "classroom2";
            this.classroom2.Size = new System.Drawing.Size(113, 39);
            this.classroom2.TabIndex = 2;
            this.classroom2.Text = "Classroom 2";
            this.classroom2.UseVisualStyleBackColor = true;
            this.classroom2.Click += new System.EventHandler(this.classroom2_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(367, 335);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 43);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear list";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(268, 74);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(324, 22);
            this.textBox.TabIndex = 4;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.classroom2);
            this.Controls.Add(this.classroom1);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button classroom1;
        private System.Windows.Forms.Button classroom2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBox;
    }
}

