using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH5_Labs
{
    public partial class Form1 : Form
    {
        List<double> scores = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            double input;

            if (double.TryParse(txtInput.Text, out input))
            {
                if (input == 999)
                {
                    DisplayResults();
                    txtInput.Enabled = false;
                    btnEnter.Enabled = false;
                }
                else if (input >= 0 && input <= 100)
                {
                    scores.Add(input);
                    txtInput.Clear();
                    txtInput.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid score. Please enter a number between 0 and 100, or 999 to stop.");
                    txtInput.Clear();
                    txtInput.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void DisplayResults()
        {
            double sum = scores.Sum();
            double average = scores.Average();
            double min = scores.Min();
            double max = scores.Max();

            lblNumScores.Text = $"Number of scores: {scores.Count}";
            lblSum.Text = $"Sum of test scores: {sum}";
            lblAverage.Text = $"Average test scores: {average:F1}";
            lblLowest.Text = $"Lowest test scores: {min}";
            lblHighest.Text = $"Highest test scores: {max}";
        }
    }
}