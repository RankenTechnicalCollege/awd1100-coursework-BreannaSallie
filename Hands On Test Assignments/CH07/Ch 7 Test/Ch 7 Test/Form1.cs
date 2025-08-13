using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ch7Test   
{
    public partial class TestScoresForm : Form
    {
        private readonly TestStatistics _stats = new TestStatistics();

        public TestScoresForm()
        {
            InitializeComponent();
            // initialize captions once
            InitializeCaptions();
            UpdateUi();
        }

        private void InitializeCaptions()
        {
            lblError.Text = string.Empty;

            lblCount.AutoSize = true;
            lblSum.AutoSize = true;
            lblAverage.AutoSize = true;
            lblMax.AutoSize = true;
            lblMin.AutoSize = true;

            // starting text
            lblCount.Text = "Number of scores: 0";
            lblSum.Text = "Sum of scores: 0";
            lblAverage.Text = "Average score: 0";
            lblMax.Text = "Highest score: 0";
            lblMin.Text = "Lowest score: 0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            // numeric check first
            if (!float.TryParse(txtScore.Text, out float score))
            {
                lblError.Text = "Please enter a numeric test score (0–100).";
                txtScore.SelectAll();
                txtScore.Focus();
                return;
            }

            try
            {
                _stats.AddScore(score); // range check is inside, throws on invalid

                txtScore.Clear();
                txtScore.Focus();
            }
            catch (ArgumentException ex)
            {
                // invalid range: ignore update, show friendly message
                lblError.Text = ex.Message;
                txtScore.SelectAll();
                txtScore.Focus();
            }

            UpdateUi();
        }

        private void UpdateUi()
        {
            // one label per line: caption + value
            lblCount.Text = "Number of scores: " + _stats.Count;
            lblSum.Text = "Sum of scores: " + _stats.Sum.ToString("0.##");
            lblAverage.Text = "Average score: " + _stats.Average.ToString("0.##");
            lblMax.Text = "Highest score: " + _stats.Max.ToString("0.##");
            lblMin.Text = "Lowest score: " + _stats.Min.ToString("0.##");
        }
    }
}
