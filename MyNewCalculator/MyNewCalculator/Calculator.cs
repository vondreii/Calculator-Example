using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MyNewCalculator
{
    public partial class Calculator : Form
    {
        private string currentCalculation = ""; // Stores the calculation that the user is entering
        private bool equalsAlreadyPressed = false; // Checks whether or not the equals sign has been pressed twice in a row

        public Calculator()
        {
            InitializeComponent();
            MaximumSize = new Size(790, 1060); // Configure the size of the program's screen
            MinimumSize = new Size(790, 1060);
        }

        // Event handlers for number and operator buttons. 
        private void button_num0_Click(object sender, EventArgs e)
        {
            AddToCalculation("0"); // Once pressed, the corresponding number/operator is added to the pending calculation
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

        private void button_plus_Click(object sender, EventArgs e)
        {
            AddToCalculation("+");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            AddToCalculation("-");
        }

        private void button_times_Click(object sender, EventArgs e)
        {
            AddToCalculation("*");
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            AddToCalculation("/");
        }

        private void button_leftBracket_Click(object sender, EventArgs e)
        {
            AddToCalculation("(");
        }

        private void button_rightBracket_Click(object sender, EventArgs e)
        {
            AddToCalculation(")");
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            AddToCalculation(".");
        }

        private void AddToCalculation(string numberOrOperator)
        {
            currentCalculation += numberOrOperator; // This adds the number or operator to the calculation
            output_result.Text = Format(currentCalculation); // This displays the updated calculation back onto the screen
            equalsAlreadyPressed = false; // The equals button is not being pressed twice at this point
        }

        private string Format(string answer)
        {
            return answer.ToString().Replace("*", "x").ToString().Replace("/", "÷"); // Format times and divide symbols
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (equalsAlreadyPressed)
            {
                return; // If the equals button has already been pressed, stop executing this code block
            }
            try
            {
                output_result.Text = Format(new DataTable().Compute(currentCalculation, null).ToString()); // Compute the answer
                output_calculation.Text = Format(currentCalculation); // Moves the calculation 
                currentCalculation = output_result.Text; // Resets the calculation
                err_not_valid.Visible = false; // Make error warning invisible
                equalsAlreadyPressed = true; // The equals button has been pressed
            }
            catch
            {
                err_not_valid.Visible = true; // If an error occurs in the above code (i.e. invalid calcuation), show error warning
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            output_result.Text = ""; // The large textbox that holds the answer becomes empty
            output_calculation.Text = ""; // The textbox above the answer that displays the ongoing calculation also becomes empty
            currentCalculation = ""; // The calculation itself is reset 
        }

        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0) // If the calculation is not empty
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1); // Remove the last number or operator from the calculation
            }
            output_result.Text = Format(currentCalculation); // Re-display the calculation onto the screen
        }
    }
}
