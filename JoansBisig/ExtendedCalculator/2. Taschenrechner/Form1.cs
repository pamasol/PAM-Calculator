using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Taschenrechner
{
    public partial class calculator : Form
    {
        double input1 = 0;
        double input2;
        double output;
        int opperator = 0; //1:plus 2:minus 3:mal 4:geteilt 5:y hoch x

        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e) //Eingabe 1
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e) //Eingabe 2
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e) //Eingabe 3
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e) //Eingabe 4
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e) //Eingabe 5
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e) //Eingabe 6
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e) //Eingabe 7
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e) //Eingabe8
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e) //Eingabe 9
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = eingabefeld.Text + "9";
            }
        }

        private void zero_Click(object sender, EventArgs e) //Eingabe 0
        {
            if (eingabefeld.ReadOnly == false)
            {
                if (eingabefeld.Text != "")
                {
                    eingabefeld.Text = eingabefeld.Text + "0";
                }
            }
        }

        private void plusminus_Click(object sender, EventArgs e) //Eingabe Plus oder Minus
        {
            if (eingabefeld.ReadOnly == false && eingabefeld.Text != "")
            {

                input2 = Convert.ToDouble(eingabefeld.Text);

                input2 = input2 * -1;
                eingabefeld.Text = input2.ToString();
            }
        }

        private void plus_Click(object sender, EventArgs e) //Operator Plus definieren und Eingabe zwischenspeichern
        {
            eingabefeld.ReadOnly = false;
            if (zwischenspeicher.Text == "")
            {
                if (eingabefeld.Text == "")
                {
                    input1 = 0;
                    zwischenspeicher.Text = input1.ToString() + "+";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
                else
                {
                    input1 = Convert.ToDouble(eingabefeld.Text);
                    zwischenspeicher.Text = input1.ToString() + "+";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
            }
            else
            {
                if (eingabefeld.Text == "")
                {
                    input2 = 0;
                }
                else
                {
                    input2 = Convert.ToDouble(eingabefeld.Text);
                }
                switch (opperator)
                {
                    case 1:
                        input1 = input1 + input2;
                        zwischenspeicher.Text = input1 + "+";
                        eingabefeld.Text = "";
                        break;
                    case 2:
                        input1 = input1 - input2;
                        zwischenspeicher.Text = input1 + "+";
                        eingabefeld.Text = "";
                        break;
                    case 3:
                        input1 = input1 * input2;
                        zwischenspeicher.Text = input1 + "+";
                        eingabefeld.Text = "";
                        break;
                    case 4:
                        input1 = input1 / input2;
                        zwischenspeicher.Text = input1 + "+";
                        eingabefeld.Text = "";
                        break;
                    case 5:
                        input1 = Math.Pow(input1, input2);
                        zwischenspeicher.Text = input1 + "+";
                        eingabefeld.Text = "";
                        break;
                }
                opperator = 1;
            }
        }

        private void comma_Click(object sender, EventArgs e) //Eingabe Komma
        {
            if (eingabefeld.ReadOnly == false)
            {
                if (eingabefeld.Text == "")
                {
                    eingabefeld.Text = eingabefeld.Text + "0.";
                }
                else
                {
                    eingabefeld.Text = eingabefeld.Text + ".";
                }
            }
        }

        private void gleich_Click(object sender, EventArgs e)  //Ausrechnen
        {
            if (eingabefeld.Text == "")
            {
                MessageBox.Show("Bitte zuerst Wert eingeben!");
            }
            else
            {
                input2 = Convert.ToDouble(eingabefeld.Text);
                if (opperator == 1)                                //Plus
                {
                    output = (input1) + (input2);
                    eingabefeld.Text = output.ToString();
                    zwischenspeicher.Text = "";
                    eingabefeld.ReadOnly = true;
                }
                else if (opperator == 2)                           //Minus
                {
                    output = (input1) - (input2);
                    eingabefeld.Text = output.ToString();
                    zwischenspeicher.Text = "";
                    eingabefeld.ReadOnly = true;

                }
                else if (opperator == 3)                           //Mal
                {
                    output = input1 * input2;
                    eingabefeld.Text = output.ToString();
                    zwischenspeicher.Text = "";
                    eingabefeld.ReadOnly = true;

                }
                else if (opperator == 4)                           //Geteilt
                {
                    output = input1 / input2;
                    eingabefeld.Text = output.ToString();
                    zwischenspeicher.Text = "";
                    eingabefeld.ReadOnly = true;

                }
                else if (opperator == 5)
                {
                    output = Math.Pow(input1, input2);
                    eingabefeld.Text = output.ToString();
                    zwischenspeicher.Text = "";
                    eingabefeld.ReadOnly = true;
                }
                History();
            }
        }
        public void History()                                  //History
        {
            if (toolStripTextBox1.Text == "")                  
            {
                toolStripTextBox1.Text = output.ToString();
                toolStripTextBox1.Visible = true;

            }else if (toolStripTextBox2.Text == "")
            {
                toolStripTextBox2.Text = output.ToString();
                toolStripTextBox2.Visible = true;

            }
            else if (toolStripTextBox3.Text == "")
            {
                toolStripTextBox3.Text = output.ToString();
                toolStripTextBox3.Visible = true;

            }
            else if (toolStripTextBox4.Text == "")
            {
                toolStripTextBox4.Text = output.ToString();
                toolStripTextBox4.Visible = true;

            }
            else if (toolStripTextBox5.Text == "")
            {
                toolStripTextBox5.Text = output.ToString();
                toolStripTextBox5.Visible = true;

            }
            else if (toolStripTextBox6.Text == "")
            {
                toolStripTextBox6.Text = output.ToString();
                toolStripTextBox6.Visible = true;


            }
            else if (toolStripTextBox7.Text == "")
            {
                toolStripTextBox7.Text = output.ToString();
                toolStripTextBox7.Visible = true;

            }
            else if (toolStripTextBox8.Text == "")
            {
                toolStripTextBox8.Text = output.ToString();
                toolStripTextBox8.Visible = true;

            }
            else if (toolStripTextBox9.Text == "")
            {
                toolStripTextBox9.Text = output.ToString();
                toolStripTextBox9.Visible = true;

            }
            else if (toolStripTextBox10.Text == "")
            {
                toolStripTextBox10.Text = output.ToString();
                toolStripTextBox10.Visible = true;

            }else
            {
                toolStripTextBox1.Text = toolStripTextBox2.Text;
                toolStripTextBox2.Text = toolStripTextBox3.Text;
                toolStripTextBox3.Text = toolStripTextBox4.Text;
                toolStripTextBox4.Text = toolStripTextBox5.Text;
                toolStripTextBox5.Text = toolStripTextBox6.Text;
                toolStripTextBox6.Text = toolStripTextBox7.Text;
                toolStripTextBox7.Text = toolStripTextBox8.Text;
                toolStripTextBox8.Text = toolStripTextBox9.Text;
                toolStripTextBox9.Text = toolStripTextBox10.Text;
                toolStripTextBox10.Text = output.ToString();
            }


        }

        private void AC_Click(object sender, EventArgs e) //Alles löschen
        {
            zwischenspeicher.Text = "";
            eingabefeld.Text = "";
            eingabefeld.ReadOnly = false;

            toolStripTextBox1.Text = "";
            toolStripTextBox1.Visible = false;
            toolStripTextBox2.Text = "";
            toolStripTextBox2.Visible = false;
            toolStripTextBox3.Text = "";
            toolStripTextBox3.Visible = false;
            toolStripTextBox4.Text = "";
            toolStripTextBox4.Visible = false;
            toolStripTextBox5.Text = "";
            toolStripTextBox5.Visible = false;
            toolStripTextBox6.Text = "";
            toolStripTextBox6.Visible = false;
            toolStripTextBox7.Text = "";
            toolStripTextBox7.Visible = false;
            toolStripTextBox8.Text = "";
            toolStripTextBox8.Visible = false;
            toolStripTextBox9.Text = "";
            toolStripTextBox9.Visible = false;
            toolStripTextBox10.Text = "";
            toolStripTextBox10.Visible = false;
        }

        private void C_Click(object sender, EventArgs e) //Eingabefeld löschen
        {
            eingabefeld.Text = "";
            eingabefeld.ReadOnly = false;
        }

        private void minus_Click(object sender, EventArgs e) //Operator Minus definieren und Eingabe zwischenspeichern
        {
            eingabefeld.ReadOnly = false;
            if (zwischenspeicher.Text == "")
            {
                if (eingabefeld.Text == "")
                {
                    input1 = 0;
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
                else
                {
                    input1 = Convert.ToDouble(eingabefeld.Text);
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }

            }
            else
            {
                if (eingabefeld.Text == "")
                {
                    input2 = 0;
                }
                else
                {
                    input2 = Convert.ToDouble(eingabefeld.Text);
                }
                switch (opperator)
                {
                    case 1:
                        input1 = input1 + input2;
                        zwischenspeicher.Text = input1 + "-";
                        eingabefeld.Text = "";
                        break;
                    case 2:
                        input1 = input1 - input2;
                        zwischenspeicher.Text = input1 + "-";
                        eingabefeld.Text = "";
                        break;
                    case 3:
                        input1 = input1 * input2;
                        zwischenspeicher.Text = input1 + "-";
                        eingabefeld.Text = "";
                        break;
                    case 4:
                        input1 = input1 / input2;
                        zwischenspeicher.Text = input1 + "-";
                        eingabefeld.Text = "";
                        break;
                    case 5:
                        input1 = Math.Pow(input1, input2);
                        zwischenspeicher.Text = input1 + "-";
                        eingabefeld.Text = "";
                        break;
                }

                opperator = 2;
            }
            
        }

        private void mal_Click(object sender, EventArgs e) //Operator Mal definieren und Eingabe zwischenspeichern
        {
            eingabefeld.ReadOnly = false;
            if (zwischenspeicher.Text == "")
            {
                if (eingabefeld.Text == "")
                {
                    input1 = 0;
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
                else
                {
                    input1 = Convert.ToDouble(eingabefeld.Text);
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
            }
            else
            {
                if (eingabefeld.Text == "")
                {
                    input2 = 0;
                }
                else
                {
                    input2 = Convert.ToDouble(eingabefeld.Text);
                }
                switch (opperator)
                {
                    case 1:
                        input1 = input1 + input2;
                        zwischenspeicher.Text = input1 + "⋅";
                        eingabefeld.Text = "";
                        break;
                    case 2:
                        input1 = input1 - input2;
                        zwischenspeicher.Text = input1 + "⋅";
                        eingabefeld.Text = "";
                        break;
                    case 3:
                        input1 = input1 * input2;
                        zwischenspeicher.Text = input1 + "⋅";
                        eingabefeld.Text = "";
                        break;
                    case 4:
                        input1 = input1 / input2;
                        zwischenspeicher.Text = input1 + "⋅";
                        eingabefeld.Text = "";
                        break;
                    case 5:
                        input1 = Math.Pow(input1, input2);
                        zwischenspeicher.Text = input1 + "⋅";
                        eingabefeld.Text = "";
                        break;
                }

                opperator = 3;
            }

        }

        private void geteilt_Click(object sender, EventArgs e) //Operator Geteilt definieren und Eingabe zwischenspeichern
        {
            eingabefeld.ReadOnly = false;
            if (zwischenspeicher.Text == "")
            {
                if (eingabefeld.Text == "")
                {
                    input1 = 0;
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
                else
                {
                    input1 = Convert.ToDouble(eingabefeld.Text);
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
            }
            else
            {
                if (eingabefeld.Text == "")
                {
                    input2 = 0;
                }
                else
                {
                    input2 = Convert.ToDouble(eingabefeld.Text);
                }
                switch (opperator)
                {
                    case 1:
                        input1 = input1 + input2;
                        zwischenspeicher.Text = input1 + "÷";
                        eingabefeld.Text = "";
                        break;
                    case 2:
                        input1 = input1 - input2;
                        zwischenspeicher.Text = input1 + "÷";
                        eingabefeld.Text = "";
                        break;
                    case 3:
                        input1 = input1 * input2;
                        zwischenspeicher.Text = input1 + "÷";
                        eingabefeld.Text = "";
                        break;
                    case 4:
                        input1 = input1 / input2;
                        zwischenspeicher.Text = input1 + "÷";
                        eingabefeld.Text = "";
                        break;
                    case 5:
                        input1 = Math.Pow(input1, input2);
                        zwischenspeicher.Text = input1 + "÷";
                        eingabefeld.Text = "";
                        break;
                }

                opperator = 4;
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox1.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox2.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox3.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox4.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox5.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox6.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox7_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox7.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox8_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox8.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox9_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox9.Text;
            eingabefeld.ReadOnly = false;
        }

        private void toolStripTextBox10_Click(object sender, EventArgs e)
        {
            history.HideDropDown();
            eingabefeld.Text = toolStripTextBox10.Text;
            eingabefeld.ReadOnly = false;
        }

        private void Wurzel_Click(object sender, EventArgs e)
        {
            if (eingabefeld.Text == "")
            {
                MessageBox.Show("Bitte zuerst Wert eingeben!");
            }
            else
            {
                double resultatwurzel;
                resultatwurzel = Convert.ToDouble(eingabefeld.Text);
                resultatwurzel = Math.Sqrt(resultatwurzel);
                eingabefeld.Text = resultatwurzel.ToString();
                eingabefeld.ReadOnly = true;
                output = Convert.ToSingle(resultatwurzel);
                History();
            }
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            eingabefeld.ReadOnly = false;
            eingabefeld.Text = Math.PI.ToString();
        }

        private void Quadrieren_Click(object sender, EventArgs e)
        {
            if (eingabefeld.Text == "")
            {
                MessageBox.Show("Bitte zuerst Wert eingeben!");

            }
            else
            {
                output = Convert.ToDouble(eingabefeld.Text);
                output = output * output;
                eingabefeld.Text = output.ToString();
                History();
            }

        }

        private void yhochx_Click_1(object sender, EventArgs e)
        {
            eingabefeld.ReadOnly = false;
            if (zwischenspeicher.Text == "")
            {
                if (eingabefeld.Text == "")
                {
                    input1 = 0;
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
                else
                {
                    input1 = Convert.ToDouble(eingabefeld.Text);
                    zwischenspeicher.Text = input1.ToString() + "-";
                    opperator = 2;
                    eingabefeld.Text = "";
                }
            }
            else
            {
                if (eingabefeld.Text == "")
                {
                    input2 = 0;
                }
                else
                {
                    input2 = Convert.ToDouble(eingabefeld.Text);
                }
                switch (opperator)
                {
                    case 1:
                        input1 = input1 + input2;
                        zwischenspeicher.Text = input1 + "x^y";
                        eingabefeld.Text = "";
                        break;
                    case 2:
                        input1 = input1 - input2;
                        zwischenspeicher.Text = input1 + "x^y";
                        eingabefeld.Text = "";
                        break;
                    case 3:
                        input1 = input1 * input2;
                        zwischenspeicher.Text = input1 + "x^y";
                        eingabefeld.Text = "";
                        break;
                    case 4:
                        input1 = input1 / input2;
                        zwischenspeicher.Text = input1 + "x^y";
                        eingabefeld.Text = "";
                        break;
                    case 5:
                        input1 = Math.Pow(input1, input2);
                        zwischenspeicher.Text = input1 + "x^y";
                        eingabefeld.Text = "";
                        break;
                }

                opperator = 5;
            }

        }

        private void einsdurchx_Click(object sender, EventArgs e)
        {
            if (eingabefeld.Text == "")
            {
                MessageBox.Show("Bitte zuerst Wert eingeben!");
            }
            else
            {
                output = Convert.ToDouble(eingabefeld.Text);
                output = 1 / output;
                eingabefeld.Text = output.ToString();
                History();

            }
        }
    }
}