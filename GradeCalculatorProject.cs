#region Student Identification
/*  Author: Kyle Chapman 
 *  Co-Author: Angelica Kusik
 *  Student Number: 100849912
 *  Date: February 12, 2022
 *  Description: GradeCalculator is a C# Windows application
 *               that enables the user to enter a numeric grade to 
 *               up to 7 courses and calculate the corresponding letter 
 *               grade, the numeric average grade for the semester and
 *               the respective average letter grade.
 *  
 *  
 */  

#endregion



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class GradeCalculatorProject : Form
    {
        public GradeCalculatorProject()
        {
            InitializeComponent();
        }
        #region "Variable Declarations"
        //Declare an array to store all input textBoxes in the form.
        TextBox[] inputTextBoxArray;

        //Declare an array to store all output labels used to display the letter grades in the form.
        Label[] outputLabelArray;
        #endregion
        #region "Event Handlers"
        /// <summary>
        /// When the form loads, assign values to the arrays based on the input textboxes and
        /// output labels on the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, EventArgs e)
        {
            //Declare an array to hold all input textboxes.
            inputTextBoxArray = new TextBox[] { textBoxCourse1Input, textBoxCourse2Input, textBoxCourse3Input, textBoxCourse4Input, textboxCourse5Input, textboxCourse6Input, textboxCourse7Input };
            //Declare an array to hold all output labels.
            outputLabelArray = new Label[] { labelCourse1Output, labelCourse2Output, labelCourse3Output, labelCourse4Output, labelCourse5Output, labelCourse6Output, labelCourse7Output };
            //Reset the form to its default when the form is loaded.
            ResetForm();
        }
        /// <summary>
        /// Calculates the average numeric and letter grades for the semester when at least 
        /// valid grade is entered and the remaining textboxes are either valid or blank.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            //Declare a variable to hold the number of validated textboxes
            int blankTextboxes = 0;
            //Declare a variable to hold the number of blank textboxes
            int validTextboxes = 0;
            //Declare variables to hold the average grade and grade total.
            double gradeTotal = 0.0;
            double gradeAverage = 0.0;
            int convertedGradeAverage = 0;
            //Declare a constant to hold the minimum acceptable number of valid textboxes
            const int MinimumValidTextboxes = 1; 

            //Check all textboxes
            for (int index = 0; index < inputTextBoxArray.Length; index++)
            {
                //if the current textbox input is valid (numeric, in-range or blank)...
                if (ValidateTextBox(inputTextBoxArray[index]))
                {
                    //If textbox is valid, add it to validTexbox variable.
                    validTextboxes++;
                    //Add grade to gradeTotal
                    gradeTotal += double.Parse(inputTextBoxArray[index].Text);
                }
                else if (inputTextBoxArray[index].Text == String.Empty)
                {
                    //If textbox is blank, add it to blankTexbox variable.
                    blankTextboxes++;
                }
            }

            if (validTextboxes >= MinimumValidTextboxes && validTextboxes + blankTextboxes == inputTextBoxArray.Length)
            {
                //If at least one textbox valid, and all remaining textboxes are either valid or blank
                //Clear error message label.
                labelErrorMessageOutput.Text = String.Empty;

                //Calculate average grade
                gradeAverage = Math.Round(gradeTotal / validTextboxes, 2);

                //Display average grade.
                textBoxSemesterNumGrade.Text = gradeAverage.ToString();

                //Convert average grade to letter grade.
                //but first convert average grade from double to int
                convertedGradeAverage = (int)gradeAverage;
                labelSemesterLetterGradeOutput.Text = GetLetterGrade(convertedGradeAverage);

                // Disable input controls until the form is reset.
                buttonCalculate.Enabled = false;
                SetControlsEnabled(inputTextBoxArray, false);
                buttonReset.Focus();

            }
            else
            {
                //Display an error message if user attempt to calculate and all textboxes are blank.
                labelErrorMessageOutput.Text += "Please enter at least one valid grade to calculate.";
                
                //Disable calculate button and set focus on reset button.
                buttonCalculate.Enabled = false;
                buttonReset.Focus();
            }
        }
        /// <summary>
        /// Clears the input and output fields and resets form to its default state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            ResetForm();
        }
        /// <summary>
        /// That's right, it closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Checks if textbox input is valid. If so, letter grade is displayed on respective 
        /// output label. If input is not valid, displays error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxLeave(object sender, EventArgs e)
        {
            //Clear error messages as the user re-entry inputs.
            labelErrorMessageOutput.Text = String.Empty;

            //Check all textboxes
            for (int index = 0; index < inputTextBoxArray.Length; index++)
            {
                //if the current textbox input is valid (numeric, in-range or blank)...
                if (ValidateTextBox(inputTextBoxArray[index]))
                {
                    //In case the user entered a double value, convert the string to double
                    double doubleGradeInput = double.Parse(inputTextBoxArray[index].Text);

                    //And then convert it to integer, so it can be transfered to getLetter.
                    int integerGradeInput = Convert.ToInt32(doubleGradeInput);

                    //Display the respective letter grade on the correspondent output label.
                    outputLabelArray[index].Text = GetLetterGrade(integerGradeInput);
                }
            }
        }
        #endregion
        #region "Functions"

        /// <summary>
        /// Given an array of controls, this function clears their text.
        /// </summary>
        /// <param name="controlArray">An array of controls with a text property to clear</param>
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }
        /// <summary>
        /// Enables all controls in the form so user can not enter a new input.
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">true to enable, false to disable</param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            //Cicle through all controls in the form and set them to enabled or disabled 
            //depending on the value of enabledStatus.
            foreach (Control controlToSet in controlArray)
            {
                controlToSet.Enabled = enabledStatus;
            }
        }
        //Reset the form to its default state. Clears control, sets focus, maybe changes some variables. TODO: align this description
        private void ResetForm()
        {
            // Clear input fields.
            ClearControls(inputTextBoxArray);
            ClearControls(outputLabelArray);

            // Clear error messages output field.
            labelErrorMessageOutput.Text = String.Empty;


            // Clear semester grade output fields.
            textBoxSemesterNumGrade.Text = String.Empty;
            labelSemesterLetterGradeOutput.Text = String.Empty;

            // Re-enable any controls that may be disabled.
            // Consider using the SetControlsEnabled for part of this.
            buttonCalculate.Enabled = true;
            SetControlsEnabled(inputTextBoxArray, true);

            // Set focus back into input textbox of course 1.
            textBoxCourse1Input.Focus();
        }
        /// <summary>
        /// Validates a single textbox input.
        /// </summary>
        /// <param name="textBoxToValidate"></param>
        /// <returns></returns>
        private bool ValidateTextBox(TextBox textBoxToValidate)
        {
            //Declare a variable to store the grade value.
            double grade;
            //Declare the variables to hold the minimum and maximum grade range values. 
            const int MinimumGrade = 0;
            const int MaximumGrade = 100;

            //Check if the textbox input contains an number.
            if (double.TryParse(textBoxToValidate.Text, out grade))
            {
                //if so, check if the number is within the range.
                if (grade >= MinimumGrade && grade <= MaximumGrade)
                {
                    //If validation succeed, return true
                    return true;
                }
                else
                {
                    //if range validation fail, display an error message and return false.
                    labelErrorMessageOutput.Text += "Entry " + textBoxToValidate.Text + " is not a valid grade. Please enter a grade between the range of " + MinimumGrade + " to " + MaximumGrade + "." + Environment.NewLine;
                    textBoxToValidate.Focus();
                    return false;
                }
            }
            //if texbox input is not a number, check if it is blank.
            else if (textBoxToValidate.Text == String.Empty)
            {
                //if blank, do not display error message but set validation to false.
                return false;
            }
            else
            {
                //if textbox input is not a number nor blank, display an error message and set validation to false.
                labelErrorMessageOutput.Text += "Entry " + textBoxToValidate.Text + " is not a valid grade. Please enter a numerical grade." + Environment.NewLine;
                textBoxToValidate.Focus();
                return false;
            }
        }
         // a function to determine a letter grade based on the numeric grade parameter
         private string GetLetterGrade(int grade)
        {
            int[] gradeArray = {0, 50, 52, 58, 60, 62, 68, 70, 72, 78, 80, 82, 90};
            string[] letterArray = { "F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A", "A+" };
            // This is the return value
            string letterGrade = "";

            // count through each index of the grade array
            for (int index = 0; index < gradeArray.Length; index++)
            {
                //if the current grade is above the numeric grade, assign it the corresponding letter grade.
                if (grade >= gradeArray[index])
                {
                    letterGrade = letterArray[index];
                }
                else
                {
                    return letterGrade;
                }
            }
            return letterGrade;
        }
        #endregion


    }
}
