using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // preparing variables 
            string operation = operationComboBox.Text;
            double number1 = double.Parse(number1TextBox.Text);
            double number2 = double.Parse(number2TextBox.Text);
            double result = 0;

            // calculations
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
                    MessageBox.Show("You cannot divide by zero");
            }
            resultTextBlock.Text = result.ToString();
        }
    }
}
