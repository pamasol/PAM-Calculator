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

namespace Calculator_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Variables setup
            string operation = comboBoxOperation.Text;
            double number1 = Convert.ToDouble(numericUpDownInput1.Text);
            double number2 = Convert.ToDouble(numericUpDownInput2.Text);
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
