using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            string operador = listBox.SelectedItem.ToString();
            if (operador == "+")
            {
                int c = a + b;
                resultTextBox.Text = c.ToString();
            }
            else if (operador == "-")
            {
                int c = a - b;
                resultTextBox.Text = c.ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            resultTextBox.Clear();
            operatorTextBox.Clear();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operador = listBox.SelectedItem.ToString();
            if (operador == "+")
            {
                operatorTextBox.Text = "+";
            }
            else if (operador == "-")
            {
                operatorTextBox.Text = "-";
            }
        }

        private void operatorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
