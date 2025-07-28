using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            // Get and validate user input
            if (float.TryParse(txtGPA.Text, out float gpa) &&
                int.TryParse(txtTestScore.Text, out int testScore))
            {
                // Check if student is accepted
                bool accepted = IsStudentAccepted(gpa, testScore);

                // Show result in the label
                lblResults.Text = accepted ? "Accept" : "Reject";
            }
            else
            {
                // Show error message if input is invalid
                MessageBox.Show("Please enter valid numbers for GPA and test score.");
            }
        }

        // Logic for acceptance decision
        private bool IsStudentAccepted(float gpa, int testScore)
        {
            if (gpa >= 3.0 && testScore >= 60)
                return true;
            else if (gpa < 3.0 && testScore >= 80)
                return true;
            else
                return false;
        }
    }
}