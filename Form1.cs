/*
/Tom Bielawski
/10-4-2020
/Starting Out With Visual C#: Tony Gaddis
/Chapter 3, Fuel Economy Calculator
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_Calculator
{
    public partial class fuelForm : Form
    {
        //Initialize the form
        public fuelForm()
        {
            InitializeComponent();
        }

        //Clear button event handler
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the text boxes
            milesTextBox.Clear();
            gallonsTextBox.Clear();

            //Clear the labels
            resultsLabel.Text = " ";

            //Return the focus to miles box
            milesTextBox.Focus();
        }

        //Close button event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Calculate button event handler
        private void calcButton_Click(object sender, EventArgs e)
        {
            //Declare variables for the math
            double milesDriven = 0;
            double gallonsUsed = 0;
            double yourMPG = 0;
           
            
                //Validate milesTextBox control by ensuring data entered is a double
                if (double.TryParse(milesTextBox.Text, out milesDriven))
                {

                    //Validate gallonsTextBox control by ensuring data entered is a double
                    if (double.TryParse(gallonsTextBox.Text, out gallonsUsed))

                    {
                        //Convert all text box entries to doubles, alternative structure
                        /*milesDriven = double.Parse(milesTextBox.Text);
                        gallonsUsed = double.Parse(gallonsTextBox.Text);*/

                        //Doing the math
                        yourMPG = milesDriven / gallonsUsed;

                        //Convert the output into a string, using the number format
                        //to present the output with commas and 2 decimal places
                        resultsLabel.Text = yourMPG.ToString("n2");
                    }

                    //If gallons data is not a double, this error:
                    else
                    {
                        //Display an error message for gallonsTextBox
                        resultsLabel.Text = " Invalid input for gallons. \nPlease enter the gallons" +
                        " using digits only";
                    }
                }

                //If miles data entered is not a double, this error:
                else
                {
                    resultsLabel.Text = "Invalid input for miles. \nPlease enter the miles using digits only";
                }
            

            //Try Catch to display a message to the user if any invalid data
            //were entered.Not needed with above TryParse method used. 
            /*catch (Exception ex)
            {
                //This customized message gives the user a little more direction
                //resultsLabel.Text ="You entered invalid data somewhere. " +
                //    "\nPlease check your entries, press CLEAR, and try again.";
            }*/
        }
    }
}
