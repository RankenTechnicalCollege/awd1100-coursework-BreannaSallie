using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        // List to store entered scores
        private List<double> scores = new List<double>();

        public Form1()
        {
            InitializeComponent();
            this.Shown += (s, e) => txtScore.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double value;

            // Check if the input is a number
            if (!double.TryParse(txtScore.Text.Trim(), out value))
            {
                MessageBox.Show("Invalid input. Please enter a number.");
                txtScore.SelectAll();
                txtScore.Focus();
                return;
            }

            // If the user enters 999, stop accepting input
            if (value == 999)
            {
                UpdateSummary();
                txtScore.Enabled = false;
                btnEnter.Enabled = false;
                return;
            }

            // Validate range
            if (value < 0 || value > 100)
            {
                MessageBox.Show("Invalid score. Please enter a value between 0 and 100.");
                txtScore.SelectAll();
                txtScore.Focus();
                return;
            }

            // Add score and update labels
            scores.Add(value);
            UpdateSummary();
            txtScore.Clear();
            txtScore.Focus();
        }

        private void UpdateSummary()
        {
            lblCount.Text = "Number of scores: " + scores.Count;

            if (scores.Count > 0)
            {
                lblSum.Text = "Sum of test scores: " + scores.Sum().ToString("F1");
                lblAvg.Text = "Average test score: " + scores.Average().ToString("F1");
                lblMin.Text = "Lowest test score: " + scores.Min().ToString("F1");
                lblMax.Text = "Highest test score: " + scores.Max().ToString("F1");
            }
            else
            {
                lblSum.Text = "Sum of test scores: 0.0";
                lblAvg.Text = "Average test score: 0.0";
                lblMin.Text = "Lowest test score: 0.0";
                lblMax.Text = "Highest test score: 0.0";
            }
        }
    }
}
