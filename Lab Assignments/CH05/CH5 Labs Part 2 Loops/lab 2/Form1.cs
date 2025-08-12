using System;
using System.Windows.Forms;

namespace Lab_2   // <-- change to match Program.cs
{
    public partial class Form1 : Form
    {
        // Running totals that persist between clicks
        double sum = 0;
        int count = 0;
        double min = double.PositiveInfinity;
        double max = double.NegativeInfinity;

        public Form1()
        {
            InitializeComponent();
            Text = "Test Scores";
            this.AcceptButton = btnEnter;   // Enter key submits
            UpdateLabels();                  // show initial zeros
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblSum.Text = "SUM=" + sum.ToString("0.0");
            if (!double.TryParse(txtScore.Text.Trim(), out double score))
            {
                MessageBox.Show("Please enter a valid numeric test score.");
                txtScore.SelectAll();
                txtScore.Focus();
                return;
            }

            // Update accumulators
            count++;
            sum += score;
            if (score < min) min = score;
            if (score > max) max = score;

            UpdateLabels();

            txtScore.Clear();
            txtScore.Focus();
        }

        private void UpdateLabels()
        {
            double avg = (count == 0) ? 0.0 : sum / count;

            lblCount.Text = $"Number of scores: {count}";
            lblSum.Text = $"Sum of test scores: {sum:0.0}";
            lblAvg.Text = $"Average test score: {avg:0.0}";
            lblLowest.Text = $"Lowest test score: {(count == 0 ? 0.0 : min):0.0}";
            lblHighest.Text = $"Highest test score: {(count == 0 ? 0.0 : max):0.0}";
        }

        // Optional: wire a Reset button to this handler if you add one
        private void btnReset_Click(object sender, EventArgs e)
        {
            sum = 0;
            count = 0;
            min = double.PositiveInfinity;
            max = double.NegativeInfinity;

            txtScore.Enabled = true;
            btnEnter.Enabled = true;
            txtScore.Clear();

            UpdateLabels();
            txtScore.Focus();
        }
    }
}