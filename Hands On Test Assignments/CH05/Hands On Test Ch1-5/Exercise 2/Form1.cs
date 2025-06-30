using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double gpa;

            // Validate input
            if (!double.TryParse(txtNumGrade.Text, out gpa))
            {
                lblResult.Text = "Please enter a valid numeric GPA.";
                return;
            }

            // Validate GPA range
            if (gpa < 0.0 || gpa > 4.0)
            {
                lblResult.Text = "GPA must be between 0.0 and 4.0.";
                return;
            }

            // Determine the letter grade
            string letterGrade;

            if (gpa > 3.0)
            {
                letterGrade = "A";
            }
            else if (gpa > 2.0)
            {
                letterGrade = "B";
            }
            else if (gpa > 1.0)
            {
                letterGrade = "C";
            }
            else if (gpa > 0.0)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Show result
            lblGradeText.Text = "Letter Grade:";
            lblResult.Text = letterGrade;
        }

    }
    }
