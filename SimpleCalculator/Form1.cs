using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /**********************************************************************
         * Team 4: George Gachoki, Jason Thomas, Tonya Martinez, Travis Johnson
         * 5-3-2020
         * "Week 4 Murach Coding Assignments (Teamwork)"
         * "Extra 6-1 Create a simple calculator"
         **********************************************************************/
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0m; // create return variable for calculation result

            switch (operator1) // determine type of calculation
            {
                case "+": // if calculation is addition
                    result = operand1 + operand2;
                    break;
                case "-": // if calculation is subtraction
                    result = operand1 - operand2;
                    break;
                case "*": // if calculation is multiplication
                    result = operand1 * operand2;
                    break;
                case "/": // if calculation is division
                    result = operand1 / operand2;
                    break;
            }

            return result; // return calculation result
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text); // create & assign Operand 1 variable
            string operator1 = txtOperator.Text; // create & assign Operator variable
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text); // create & assign Operand 2 variable
            decimal result = Calculate(operand1, operator1, operand2); // run calculation with Calculate & assign Result variable

            txtResult.Text = Math.Round(result, 4).ToString(); // display Result rounded to four decimal places
            txtOperand1.Focus(); // give focus to Operand 1 textbox
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // close form
        }

        private void ClearResults(object sender, EventArgs e)
        {
            txtResult.Text = ""; // clear Result textbox
        }
    }
}