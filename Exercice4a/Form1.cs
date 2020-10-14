using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            operatorTextBox.Text = "+";
        }

        private void substactButton_Click(object sender, EventArgs e)
        {
            operatorTextBox.Text = "-";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if (operatorTextBox.Text == "+")
            {
                int c = a + b;
                resultTextBox.Text = c.ToString();
            }
            else if(operatorTextBox.Text == "-")
            {
                int c = a - b;
                resultTextBox.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Click an operation to do.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            resultTextBox.Clear();
            operatorTextBox.Clear();
        }

        private void operatorTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
