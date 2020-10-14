using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice5
{
    public partial class Form1 : Form
    {
        String a, b, c = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxPangolin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxCoati_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxPangolin.Checked == true)
            {
                a = "Pangolin";
            }
            else
            {
                a = " ";
            }
            if (checkBoxCoati.Checked == true)
            {
                b = "Coati";
            }
            else
            {
                b = " ";
            }
            if (checkBoxBat.Checked == true)
            {
                c = "Bat";
            }
            else
            {
                c = " ";
            }
            textBox1.Text = "The animals you selected are: " + a + " " + b + " " + c;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
