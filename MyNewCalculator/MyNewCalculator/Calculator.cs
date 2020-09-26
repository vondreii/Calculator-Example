using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNewCalculator
{
    public partial class Calculator : Form
    {
        private string currentCalculation = "";
        private bool equalsAlreadyPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }
        
        private void button_num0_Click(object sender, EventArgs e)
        {
            AddToCalculation("0");
        }

        private void button_num1_Click(object sender, EventArgs e)
        {
            AddToCalculation("1");
        }

        private void button_num2_Click(object sender, EventArgs e)
        {
            AddToCalculation("2");
        }

        private void button_num3_Click(object sender, EventArgs e)
        {
            AddToCalculation("3");
        }

        private void button_num4_Click(object sender, EventArgs e)
        {
            AddToCalculation("4");
        }

        private void button_num5_Click(object sender, EventArgs e)
        {
            AddToCalculation("5");
        }

        private void button_num6_Click(object sender, EventArgs e)
        {
            AddToCalculation("6");
        }

        private void button_num7_Click(object sender, EventArgs e)
        {
            AddToCalculation("7");
        }

        private void button_num8_Click(object sender, EventArgs e)
        {
            AddToCalculation("8");
        }

        private void button_num9_Click(object sender, EventArgs e)
        {
            AddToCalculation("9");
        }

        private void button_leftBracket_Click(object sender, EventArgs e)
        {
            AddToCalculation("(");
        }

        private void button_rightBracket_Click(object sender, EventArgs e)
        {
            AddToCalculation(")");
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            AddToCalculation("/");
        }

        private void button_times_Click(object sender, EventArgs e)
        {
            AddToCalculation("*");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            AddToCalculation("-");
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            AddToCalculation("+");
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            AddToCalculation(".");
        }
        
        private string Format(string answer)
        {
            // Formats times and divide symbols
            return answer.ToString().Replace("*", "x").ToString().Replace("/", "÷");
        }

        private void AddToCalculation(string numberOrOperator)
        {
            currentCalculation += numberOrOperator; // Keeps track of the user typing new numbers/operators to the calculation
            output_result.Text = Format(currentCalculation); // Displays the updated calculation back to the user
            equalsAlreadyPressed = false;
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (equalsAlreadyPressed)
            {
                return;
            }

            try
            {
                output_result.Text = Format(new DataTable().Compute(currentCalculation, null).ToString()); // Computes the answer
                output_calculation.Text = Format(currentCalculation); // Shows the answer to the user
                currentCalculation = output_result.Text; // Resets the calculation
                err_not_valid.Visible = false;
                equalsAlreadyPressed = true;
            }
            catch
            {
                err_not_valid.Visible = true;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // Reset all output
            output_result.Text = "";
            output_calculation.Text = "";
            currentCalculation = "";
        }

        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            output_result.Text = Format(currentCalculation);
        }
    }
}
