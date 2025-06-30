using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_PT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            double gpa;
            int testScore;

            // Try parsing user input
            bool isGpaValid = double.TryParse(txtGPA.Text, out gpa);
            bool isScoreValid = int.TryParse(txtTestScore.Text, out testScore);

            if (!isGpaValid || !isScoreValid)
            {
                lblResult.Text = "Please enter valid numeric values.";
                return;
            }

            // Apply the logic
            if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))
            {
                lblResult.Text = "Accept";
            }
            else
            {
                lblResult.Text = "Reject";
            }
        }
    }
    }

