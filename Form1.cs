using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(richTextBox1.Text);

            if (Operation == "+")
            {
                Result = FirstNumber + SecondNumber;
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = FirstNumber - SecondNumber;
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = FirstNumber * SecondNumber;
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    richTextBox1.Text = "Error!";
                }
                else
                {
                    Result = FirstNumber / SecondNumber;
                    richTextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}
