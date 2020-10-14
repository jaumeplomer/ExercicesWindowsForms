using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9
{
    public partial class Form1 : Form
    {
        int i = 0;
        int y = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void evenButton_Click(object sender, EventArgs e)
        {   
            if (i <= 10)
            {
                comboBox1.Items.Add(i);
            }
            i = i+2;    
        }

        private void oddButton_Click(object sender, EventArgs e)
        {
            if (y <= 10)
            {
                comboBox1.Items.Add(y);
            }
            y = y + 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
