
namespace GradeCalculator
{
    partial class GradeCalculatorProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCourse1 = new System.Windows.Forms.Label();
            this.textBoxCourse1Input = new System.Windows.Forms.TextBox();
            this.labelCourse1Output = new System.Windows.Forms.Label();
            this.labelCourse2 = new System.Windows.Forms.Label();
            this.textBoxCourse2Input = new System.Windows.Forms.TextBox();
            this.labelCourse2Output = new System.Windows.Forms.Label();
            this.labelCourse3 = new System.Windows.Forms.Label();
            this.textBoxCourse3Input = new System.Windows.Forms.TextBox();
            this.labelCourse3Output = new System.Windows.Forms.Label();
            this.labelCourse4 = new System.Windows.Forms.Label();
            this.textBoxCourse4Input = new System.Windows.Forms.TextBox();
            this.labelCourse4Output = new System.Windows.Forms.Label();
            this.labelCourse5 = new System.Windows.Forms.Label();
            this.textboxCourse5Input = new System.Windows.Forms.TextBox();
            this.labelCourse5Output = new System.Windows.Forms.Label();
            this.labelCourse6 = new System.Windows.Forms.Label();
            this.textboxCourse6Input = new System.Windows.Forms.TextBox();
            this.labelCourse6Output = new System.Windows.Forms.Label();
            this.labelCourse7 = new System.Windows.Forms.Label();
            this.textboxCourse7Input = new System.Windows.Forms.TextBox();
            this.labelCourse7Output = new System.Windows.Forms.Label();
            this.labelSemesterOutput = new System.Windows.Forms.Label();
            this.textBoxSemesterNumGrade = new System.Windows.Forms.TextBox();
            this.labelSemesterLetterGradeOutput = new System.Windows.Forms.Label();
            this.labelErrorMessageOutput = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelCourse1
            // 
            this.labelCourse1.Location = new System.Drawing.Point(58, 43);
            this.labelCourse1.Name = "labelCourse1";
            this.labelCourse1.Size = new System.Drawing.Size(110, 35);
            this.labelCourse1.TabIndex = 0;
            this.labelCourse1.Text = "Course 1:";
            // 
            // textBoxCourse1Input
            // 
            this.textBoxCourse1Input.Location = new System.Drawing.Point(174, 43);
            this.textBoxCourse1Input.Name = "textBoxCourse1Input";
            this.textBoxCourse1Input.Size = new System.Drawing.Size(175, 35);
            this.textBoxCourse1Input.TabIndex = 1;
            this.textBoxCourse1Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse1Input, "Enter numerical grade for course 1.");
            this.textBoxCourse1Input.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelCourse1Output
            // 
            this.labelCourse1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse1Output.Location = new System.Drawing.Point(394, 44);
            this.labelCourse1Output.Name = "labelCourse1Output";
            this.labelCourse1Output.Size = new System.Drawing.Size(175, 35);
            this.labelCourse1Output.TabIndex = 2;
            this.labelCourse1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelCourse1Output, "Displays course 1 equivalent letter grade output.");
            // 
            // labelCourse2
            // 
            this.labelCourse2.Location = new System.Drawing.Point(58, 105);
            this.labelCourse2.Name = "labelCourse2";
            this.labelCourse2.Size = new System.Drawing.Size(110, 35);
            this.labelCourse2.TabIndex = 3;
            this.labelCourse2.Text = "Course 2:";
            // 
            // textBoxCourse2Input
            // 
            this.textBoxCourse2Input.Location = new System.Drawing.Point(174, 102);
            this.textBoxCourse2Input.Name = "textBoxCourse2Input";
            this.textBoxCourse2Input.Size = new System.Drawing.Size(175, 35);
            this.textBoxCourse2Input.TabIndex = 4;
            this.textBoxCourse2Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse2Input, "Enter numerical grade for course 2.");
            this.textBoxCourse2Input.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelCourse2Output
            // 
            this.labelCourse2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse2Output.Location = new System.Drawing.Point(394, 103);
            this.labelCourse2Output.Name = "labelCourse2Output";
            this.labelCourse2Output.Size = new System.Drawing.Size(175, 35);
            this.labelCourse2Output.TabIndex = 5;
            this.labelCourse2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelCourse2Output, "Displays course 2 equivalent letter grade output.");
            // 
            // labelCourse3
            // 
            this.labelCourse3.Location = new System.Drawing.Point(58, 167);
            this.labelCourse3.Name = "labelCourse3";
            this.labelCourse3.Size = new System.Drawing.Size(110, 35);
            this.labelCourse3.TabIndex = 6;
            this.labelCourse3.Text = "Course 3:";
            // 
            // textBoxCourse3Input
            // 
            this.textBoxCourse3Input.Location = new System.Drawing.Point(174, 166);
            this.textBoxCourse3Input.Name = "textBoxCourse3Input";
            this.textBoxCourse3Input.Size = new System.Drawing.Size(175, 35);
            this.textBoxCourse3Input.TabIndex = 7;
            this.textBoxCourse3Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse3Input, "Enter numerical grade for course 3.");
            this.textBoxCourse3Input.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelCourse3Output
            // 
            this.labelCourse3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse3Output.Location = new System.Drawing.Point(394, 167);
            this.labelCourse3Output.Name = "labelCourse3Output";
            this.labelCourse3Output.Size = new System.Drawing.Size(175, 35);
            this.labelCourse3Output.TabIndex = 8;
            this.labelCourse3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelCourse3Output, "Displays course 3 equivalent letter grade output.");
            // 
            // labelCourse4
            // 
            this.labelCourse4.Location = new System.Drawing.Point(58, 235);
            this.labelCourse4.Name = "labelCourse4";
            this.labelCourse4.Size = new System.Drawing.Size(110, 35);
            this.labelCourse4.TabIndex = 9;
            this.labelCourse4.Text = "Course 4:";
            // 
            // textBoxCourse4Input
            // 
            this.textBoxCourse4Input.Location = new System.Drawing.Point(174, 232);
            this.textBoxCourse4Input.Name = "textBoxCourse4Input";
            this.textBoxCourse4Input.Size = new System.Drawing.Size(175, 35);
            this.textBoxCourse4Input.TabIndex = 10;
            this.textBoxCourse4Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxCourse4Input, "Enter numerical grade for course 4.");
            this.textBoxCourse4Input.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelCourse4Output
            // 
            this.labelCourse4Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse4Output.Location = new System.Drawing.Point(394, 233);
            this.labelCourse4Output.Name = "labelCourse4Output";
            this.labelCourse4Output.Size = new System.Drawing.Size(175, 35);
            this.labelCourse4Output.TabIndex = 11;
            this.labelCourse4Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelCourse4Output, "Displays course 4 equivalent letter grade output.");
            // 
            // labelCourse5
            // 
            this.labelCourse5.Location = new System.Drawing.Point(58, 297);
            this.labelCourse5.Name = "labelCourse5";
            this.labelCourse5.Size = new System.Drawing.Size(110, 35);
            this.labelCourse5.TabIndex = 12;
            this.labelCourse5.Text = "Course 5:";
            // 
            // textboxCourse5Input
            // 
            this.textboxCourse5Input.Location = new System.Drawing.Point(174, 294);
            this.textboxCourse5Input.Name = "textboxCourse5Input";
            this.textboxCourse5Input.Size = new System.Drawing.Size(175, 35);
            this.textboxCourse5Input.TabIndex = 13;
            this.textboxCourse5Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textboxCourse5Input, "Enter numerical grade for course 5.");
            this.textboxCourse5Input.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelCourse5Output
            // 
            this.labelCourse5Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse5Output.Location = new System.Drawing.Point(394, 295);
            this.labelCourse5Output.Name = "labelCourse5Output";
            this.labelCourse5Output.Size = new System.Drawing.Size(175, 35);
            this.labelCourse5Output.TabIndex = 14;
            this.labelCourse5Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelCourse5Output, "Displays course 5 equivalent letter grade output.");
            // 
            // labelCourse6
            // 
            this.labelCourse6.Location = new System.Drawing.Point(58, 365);
            this.labelCourse6.Name = "labelCourse6";
            this.labelCourse6.Size = new System.Drawing.Size(110, 35);
            this.labelCourse6.TabIndex = 15;
            this.labelCourse6.Text = "Course 6:";
            // 
            // textboxCourse6Input
            // 
            this.textboxCourse6Input.Location = new System.Drawing.Point(174, 362);
            this.textboxCourse6Input.Name = "textboxCourse6Input";
            this.textboxCourse6Input.Size = new System.Drawing.Size(175, 35);
            this.textboxCourse6Input.TabIndex = 16;
            this.textboxCourse6Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textboxCourse6Input, "Enter numerical grade for course 6.");
            this.textboxCourse6Input.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelCourse6Output
            // 
            this.labelCourse6Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse6Output.Location = new System.Drawing.Point(394, 363);
            this.labelCourse6Output.Name = "labelCourse6Output";
            this.labelCourse6Output.Size = new System.Drawing.Size(175, 35);
            this.labelCourse6Output.TabIndex = 17;
            this.labelCourse6Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelCourse6Output, "Displays course 6 equivalent letter grade output.");
            // 
            // labelCourse7
            // 
            this.labelCourse7.Location = new System.Drawing.Point(58, 429);
            this.labelCourse7.Name = "labelCourse7";
            this.labelCourse7.Size = new System.Drawing.Size(110, 35);
            this.labelCourse7.TabIndex = 18;
            this.labelCourse7.Text = "Course 7:";
            // 
            // textboxCourse7Input
            // 
            this.textboxCourse7Input.Location = new System.Drawing.Point(174, 426);
            this.textboxCourse7Input.Name = "textboxCourse7Input";
            this.textboxCourse7Input.Size = new System.Drawing.Size(175, 35);
            this.textboxCourse7Input.TabIndex = 19;
            this.textboxCourse7Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textboxCourse7Input, "Enter numerical grade for course 7.");
            this.textboxCourse7Input.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelCourse7Output
            // 
            this.labelCourse7Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse7Output.Location = new System.Drawing.Point(394, 427);
            this.labelCourse7Output.Name = "labelCourse7Output";
            this.labelCourse7Output.Size = new System.Drawing.Size(175, 35);
            this.labelCourse7Output.TabIndex = 20;
            this.labelCourse7Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelCourse7Output, "Displays course 7 equivalent letter grade output.");
            // 
            // labelSemesterOutput
            // 
            this.labelSemesterOutput.Location = new System.Drawing.Point(58, 490);
            this.labelSemesterOutput.Name = "labelSemesterOutput";
            this.labelSemesterOutput.Size = new System.Drawing.Size(110, 35);
            this.labelSemesterOutput.TabIndex = 21;
            this.labelSemesterOutput.Text = "Semester:";
            // 
            // textBoxSemesterNumGrade
            // 
            this.textBoxSemesterNumGrade.Location = new System.Drawing.Point(174, 491);
            this.textBoxSemesterNumGrade.Name = "textBoxSemesterNumGrade";
            this.textBoxSemesterNumGrade.ReadOnly = true;
            this.textBoxSemesterNumGrade.Size = new System.Drawing.Size(175, 35);
            this.textBoxSemesterNumGrade.TabIndex = 22;
            this.textBoxSemesterNumGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxSemesterNumGrade, "Displays average numerical grade for the semester.");
            this.textBoxSemesterNumGrade.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelSemesterLetterGradeOutput
            // 
            this.labelSemesterLetterGradeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSemesterLetterGradeOutput.Location = new System.Drawing.Point(394, 491);
            this.labelSemesterLetterGradeOutput.Name = "labelSemesterLetterGradeOutput";
            this.labelSemesterLetterGradeOutput.Size = new System.Drawing.Size(175, 35);
            this.labelSemesterLetterGradeOutput.TabIndex = 23;
            this.labelSemesterLetterGradeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelSemesterLetterGradeOutput, "Displays average letter grade for the semester.");
            // 
            // labelErrorMessageOutput
            // 
            this.labelErrorMessageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelErrorMessageOutput.Location = new System.Drawing.Point(58, 559);
            this.labelErrorMessageOutput.Name = "labelErrorMessageOutput";
            this.labelErrorMessageOutput.Size = new System.Drawing.Size(511, 222);
            this.labelErrorMessageOutput.TabIndex = 24;
            this.labelErrorMessageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelErrorMessageOutput, "Displays error messages.");
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(58, 807);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(131, 40);
            this.buttonCalculate.TabIndex = 25;
            this.buttonCalculate.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.buttonCalculate, "Click to calculate.");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculateClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(248, 807);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(131, 40);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to reset form.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(438, 807);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 40);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Click to exit program.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // GradeCalculatorProject
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(626, 883);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelErrorMessageOutput);
            this.Controls.Add(this.labelSemesterLetterGradeOutput);
            this.Controls.Add(this.textBoxSemesterNumGrade);
            this.Controls.Add(this.labelSemesterOutput);
            this.Controls.Add(this.labelCourse7Output);
            this.Controls.Add(this.textboxCourse7Input);
            this.Controls.Add(this.labelCourse7);
            this.Controls.Add(this.labelCourse6Output);
            this.Controls.Add(this.textboxCourse6Input);
            this.Controls.Add(this.labelCourse6);
            this.Controls.Add(this.labelCourse5Output);
            this.Controls.Add(this.textboxCourse5Input);
            this.Controls.Add(this.labelCourse5);
            this.Controls.Add(this.labelCourse4Output);
            this.Controls.Add(this.textBoxCourse4Input);
            this.Controls.Add(this.labelCourse4);
            this.Controls.Add(this.labelCourse3Output);
            this.Controls.Add(this.textBoxCourse3Input);
            this.Controls.Add(this.labelCourse3);
            this.Controls.Add(this.labelCourse2Output);
            this.Controls.Add(this.textBoxCourse2Input);
            this.Controls.Add(this.labelCourse2);
            this.Controls.Add(this.labelCourse1Output);
            this.Controls.Add(this.textBoxCourse1Input);
            this.Controls.Add(this.labelCourse1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradeCalculatorProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angelica\'s Grade Calculator";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourse1;
        private System.Windows.Forms.TextBox textBoxCourse1Input;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelCourse1Output;
        private System.Windows.Forms.Label labelCourse2;
        private System.Windows.Forms.TextBox textBoxCourse2Input;
        private System.Windows.Forms.Label labelCourse2Output;
        private System.Windows.Forms.Label labelCourse3;
        private System.Windows.Forms.TextBox textBoxCourse3Input;
        private System.Windows.Forms.Label labelCourse3Output;
        private System.Windows.Forms.Label labelCourse4;
        private System.Windows.Forms.TextBox textBoxCourse4Input;
        private System.Windows.Forms.Label labelCourse4Output;
        private System.Windows.Forms.Label labelCourse5;
        private System.Windows.Forms.TextBox textboxCourse5Input;
        private System.Windows.Forms.Label labelCourse5Output;
        private System.Windows.Forms.Label labelCourse6;
        private System.Windows.Forms.TextBox textboxCourse6Input;
        private System.Windows.Forms.Label labelCourse6Output;
        private System.Windows.Forms.Label labelCourse7;
        private System.Windows.Forms.TextBox textboxCourse7Input;
        private System.Windows.Forms.Label labelCourse7Output;
        private System.Windows.Forms.Label labelSemesterOutput;
        private System.Windows.Forms.TextBox textBoxSemesterNumGrade;
        private System.Windows.Forms.Label labelSemesterLetterGradeOutput;
        private System.Windows.Forms.Label labelErrorMessageOutput;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

