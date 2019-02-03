using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCQS_Paper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (radioButton101.Checked)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Sorry Wrong");
            }
        }

        private void button201_Click(object sender, EventArgs e)
        {
            if (radioButton202.Checked)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Sorry Wrong");
            }

        }

        private void button301_Click(object sender, EventArgs e)
        {
            if (radioButton304.Checked)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Sorry Wrong");
            }
        }

        private void button401_Click(object sender, EventArgs e)
        {
            if (radioButton402.Checked)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Sorry Wrong");
            }
        }

        private void button501_Click(object sender, EventArgs e)
        {
            if (radioButton501.Checked)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Sorry Wrong");
            }
        }
    }
}
