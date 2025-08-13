using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        // constants used by the required methods
        private const int HEIGHT = 9;              // wall height in feet
        private const double COST_PER_SQFT = 6.0;  // price per square foot

        public Form1()
        {
            InitializeComponent();
            Text = "Painting Estimate";
            this.AcceptButton = btnCalculate;   // Enter key triggers Calculate

            // optional: starting text
            lblArea.Text = "Area: 0 sq ft";
            lblCost.Text = "Cost: $0";
        }

        // === REQUIRED by unit tests ===
        private int CalculateTotalArea(int length, int width)
        {
            // total paintable wall area: 2*h*(L + W)
            return 2 * HEIGHT * (length + width);
        }

        // === REQUIRED by unit tests ===
        private double CalculatePaintEstimate(int totalArea)
        {
            return totalArea * COST_PER_SQFT;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLength.Text.Trim(), out int length) ||
                !int.TryParse(txtWidth.Text.Trim(), out int width) ||
                length <= 0 || width <= 0)
            {
                MessageBox.Show("Please enter positive whole numbers for length and width.");
                return;
            }

            int area = CalculateTotalArea(length, width);
            double cost = CalculatePaintEstimate(area);

            lblArea.Text = $"Area: {area} sq ft";
            lblCost.Text = $"Cost: {cost:C0}";   // e.g., $3,888
        }

        // Designer had this wired; keep it so the Designer loads without errors.
        private void lblLength_Click(object sender, EventArgs e)
        {
            // no action needed
        }
    }
}