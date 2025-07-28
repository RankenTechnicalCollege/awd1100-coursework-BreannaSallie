using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {

        private const int HEIGHT = 9;
        private const int COST_PER_SQFT = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLength_Click(object sender, EventArgs e)
        {

        }
  private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLength.Text, out int length) &&
                int.TryParse(txtWidth.Text, out int width))
            {
                int totalArea = CalculateTotalArea(length, width);
                int totalCost = totalArea * COST_PER_SQFT;

                lblArea.Text = $"Area: {totalArea} sq ft";
                lblCost.Text = $"Cost: ${totalCost}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for length and width.");
            }
        }

        // This method calculates the total wall area
        private int CalculateTotalArea(int length, int width)
        {
            // 2 walls of length x height, 2 walls of width x height
            return 2 * HEIGHT * (length + width);
        }
    }
}