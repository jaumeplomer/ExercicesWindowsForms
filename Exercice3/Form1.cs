using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            operand1.Clear();
            operand2.Clear();
            result.Clear();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(operand1.Text);
            int b = Convert.ToInt32(operand2.Text);
            int c = a + b;
            result.Text = c.ToString();
        }

        private void operand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operand2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
