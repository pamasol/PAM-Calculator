using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            opperator.Text = "-";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float input1 = 0;
            float input2 = 0;
            float output = 0;
            float.TryParse(firstnum.Text, out input1);
            float.TryParse(secondnum.Text, out input2);
            if (Addition.Checked)
            {
                output = input1 + input2;
                result.Text = output.ToString();
            }
            else if (Subtraktion.Checked)
            {
                output = input1 - input2;
                result.Text = output.ToString();
            }
            else if (Multiplikation.Checked)
            {
                output = input1 * input2;
                result.Text = output.ToString();
            }
            else if (Division.Checked)
            {
                if (input2 == 0)
                {
                    result.Text = "ERROR!!";
                }else
                {
                    output = input1 / input2;
                    result.Text = output.ToString();
                }

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            opperator.Text = "+";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Multiplikation_CheckedChanged(object sender, EventArgs e)
        {
            opperator.Text = "⋅";
        }

        private void Division_CheckedChanged(object sender, EventArgs e)
        {
            opperator.Text = "÷";
        }
    }
}
