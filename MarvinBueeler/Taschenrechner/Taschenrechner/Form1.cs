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
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            float c = 0;

            float.TryParse(textBox1.Text, out a);
            float.TryParse(textBox2.Text, out b);
            float.TryParse(textBox2.Text, out c);

            c = a + b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            float c = 0;

            float.TryParse(textBox1.Text, out a);
            float.TryParse(textBox2.Text, out b);
            float.TryParse(textBox2.Text, out c);

            c = a * b;
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            float c = 0;

            float.TryParse(textBox1.Text, out a);
            float.TryParse(textBox2.Text, out b);
            float.TryParse(textBox2.Text, out c);

            c = a - b;
            textBox3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            float c = 0;

            float.TryParse(textBox1.Text, out a);
            float.TryParse(textBox2.Text, out b);
            float.TryParse(textBox2.Text, out c);

            c = a / b;
            textBox3.Text = c.ToString();
        }
    }
}
