using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            comboBoxOperation.SelectedIndex = 0;
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // Variables setup
            string operation = comboBoxOperation.SelectedItem.ToString();
            double number1 = Convert.ToDouble(numericUpDownInput1.Value);
            double number2 = Convert.ToDouble(numericUpDownInput2.Value);
            double result = 0;

            // Calculation
            if (operation == "+")
                result = number1 + number2;
            else if (operation == "-")
                result = number1 - number2;
            else if (operation == "*")
                result = number1 * number2;
            else if (operation == "/")
            {
                if (number2 != 0)
                    result = number1 / number2;
                else
                    MessageBox.Show("You can't divide by zero");
            }
            labelResult.Text = result.ToString();
        }
    }
}
