using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice8
{
    public partial class Form1 : Form
    {
        string[] class1 = { "James", "Mike", "Bertha", "Lillia" };
        string[] class2 = { "Carla", "Ylúvatar", "Millie", "Elodin" };
        public Form1()
        {
            InitializeComponent();
        }

        private void classroom1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(class1);
        }

        private void classroom2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(class2);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            textBox.Text = " ";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox.Text = listBox.SelectedItem.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
