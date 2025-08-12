using System;
using System.Windows.Forms;

namespace Lab_4   // <-- match Program.cs
{
    public partial class Form1 : Form
    {
        private readonly int[] numbers = new int[20];
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateDisplay();
            this.AcceptButton = btnEnter; // Enter key submits
        }

        // EXACT signature from the lab
        public void CalculateStats(out int min, out int max, out double sum, out double avg, params int[] numbers)
        {
            min = 0; max = 0; sum = 0.0; avg = 0.0;
            if (numbers == null || numbers.Length == 0) return;

            min = numbers[0];
            max = numbers[0];
            sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int n = numbers[i];
                if (n < min) min = n;
                if (n > max) max = n;
                sum += n;
            }

            avg = sum / numbers.Length;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtValue.Text.Trim(), out int value))
            {
                MessageBox.Show("Please enter a valid integer.");
                txtValue.SelectAll(); txtValue.Focus();
                return;
            }

            if (count >= 20)
            {
                MessageBox.Show("Maximum of 20 numbers reached.");
                txtValue.Enabled = false;
                btnEnter.Enabled = false;
                return;
            }

            numbers[count++] = value;

            UpdateDisplay();
            txtValue.Clear();
            txtValue.Focus();
        }

        private void UpdateDisplay()
        {
            lblCount.Text = $"Numbers Entered: {count}/20";

            if (count == 0)
            {
                lblLowest.Text = "Lowest: 0";
                lblHighest.Text = "Highest: 0";
                lblSum.Text = "Sum: 0.0";
                lblAvg.Text = "Average: 0.0";
                return;
            }

            int min, max; double sum, avg;
            int[] slice = new int[count];
            Array.Copy(numbers, slice, count);

            CalculateStats(out min, out max, out sum, out avg, slice);

            lblLowest.Text = $"Lowest: {min}";
            lblHighest.Text = $"Highest: {max}";
            lblSum.Text = $"Sum: {sum:0.0}";
            lblAvg.Text = $"Average: {avg:0.0}";
        }
    }
}
