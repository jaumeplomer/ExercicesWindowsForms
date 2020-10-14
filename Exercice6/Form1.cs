using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = " ";

            if (radioButtonBlue.Checked == true)
            {
                a = "Blue";
            }
            else if (radioButtonWhite.Checked == true)
            {
                a = "White";
            }
            else if(radioButtonRed.Checked == true)
            {
                a = "Red";
            }
            textBox1.Text = "The selected colour is: " + a;
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWhite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
