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
        
        private void button_num_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text; // This adds the number or operator to the calculation

            output_result.Text = currentCalculation; // This displays the updated calculation back onto the screen.

            equalsAlreadyPressed = false; // The equals button was not pressed recently
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (equalsAlreadyPressed) // If the equals button has already just been pressed, exit the function
            {
                return; 
            }

            try
            {
                string formattedCalculation = currentCalculation.ToString().Replace("x", "*").ToString().Replace("÷", "/"); // replaces text with symbols used in programming

                output_result.Text = new DataTable().Compute(formattedCalculation, null).ToString(); // Calculate the answer of the calculation, and display it in the large textbox.

                output_calculation.Text = currentCalculation; // Move the calculation that is being displayed to show above the answer.

                currentCalculation = output_result.Text; // Resets the calculation that is being entered. Uses the answer as the new value.

                err_not_valid.Visible = false; // Error message is made invisible, since all the code above completed and no error occurred

                equalsAlreadyPressed = true; // The equals button has been pressed
            }
            catch (Exception exception)
            {
                err_not_valid.Visible = true; // show the error message
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
            output_result.Text = currentCalculation; // Re-display the calculation onto the screen
        }
    }
}