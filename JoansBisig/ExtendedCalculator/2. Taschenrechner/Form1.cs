using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Taschenrechner
{
    public partial class calculator : Form
    {
        float input1 = 0;
        float input2;
        float output;
        int opperator = 0; //1:plus 2:minus 3:mal 4:geteilt

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
            if (eingabefeld.ReadOnly == false)
            {

                float.TryParse(eingabefeld.Text, out input2);

                input2 = input2 * -1;
                eingabefeld.Text = input2.ToString();
            }
        }

        private void plus_Click(object sender, EventArgs e) //Operator Plus definieren und Eingabe zwischenspeichern
        {
            if (zwischenspeicher.Text == "")
            {
                float.TryParse(eingabefeld.Text, out input1);
                zwischenspeicher.Text = input1.ToString() + "+";
                opperator = 1;
                eingabefeld.Text = "";
            }
            else
            {
                float.TryParse(eingabefeld.Text, out input2);
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

        private void gleich_Click(object sender, EventArgs e) //Ausrechnen
        {
            float.TryParse(eingabefeld.Text, out input2);
            if (opperator == 1)                                //Plus
            {
                output = (input1) + (input2);
                eingabefeld.Text = output.ToString();
                zwischenspeicher.Text = "";
                eingabefeld.ReadOnly = true;
            }
            else if (opperator == 2)                          //Minus
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

            History:

            if (toolStripTextBox1.Text == "")                  //History
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


        }

        private void AC_Click(object sender, EventArgs e) //Alles löschen
        {
            zwischenspeicher.Text = "";
            eingabefeld.Text = "";
            eingabefeld.ReadOnly = false;
        }

        private void C_Click(object sender, EventArgs e) //Eingabefeld löschen
        {
            if (eingabefeld.ReadOnly == false)
            {
                eingabefeld.Text = "";
            }
        }

        private void minus_Click(object sender, EventArgs e) //Operator Minus definieren und Eingabe zwischenspeichern
        {
            if (zwischenspeicher.Text == "")
            {
                float.TryParse(eingabefeld.Text, out input1);
                zwischenspeicher.Text = input1.ToString() + "-";
                opperator = 2;
                eingabefeld.Text = "";
            }
            else
            {
                float.TryParse(eingabefeld.Text, out input2);
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
                }

                opperator = 2;
               /*float.TryParse(eingabefeld.Text, out input2);

                input1 = input1 - input2;
                zwischenspeicher.Text = input1.ToString() + "-";
                eingabefeld.Text = "";*/
            }

        }

        private void mal_Click(object sender, EventArgs e) //Operator Mal definieren und Eingabe zwischenspeichern
        {
            if (zwischenspeicher.Text == "")
            {
                float.TryParse(eingabefeld.Text, out input1);
                zwischenspeicher.Text = input1.ToString() + "⋅";
                opperator = 3;
                eingabefeld.Text = "";
            }
            else
            {
                float.TryParse(eingabefeld.Text, out input2);
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
                }

                opperator = 3;
            }

        }

        private void geteilt_Click(object sender, EventArgs e) //Operator Geteilt definieren und Eingabe zwischenspeichern
        {
            if (zwischenspeicher.Text == "")
            {
                float.TryParse(eingabefeld.Text, out input1);
                zwischenspeicher.Text = input1.ToString() + "÷";
                opperator = 4;
                eingabefeld.Text = "";
            }
            else
            {
                float.TryParse(eingabefeld.Text, out input2);
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
                }

                opperator = 4;
            }

        }

        private void platzhalter_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox10_Click(object sender, EventArgs e)
        {
            
        }
    }
}