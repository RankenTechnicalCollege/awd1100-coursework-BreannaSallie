using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double length, width;

            // Validate input from text boxes
            if (!double.TryParse(txtLength.Text, out length) || !double.TryParse(txtWidth.Text, out width))
            {
                lblAreaResult.Text = "Please enter valid numbers.";
                lblWkFeeResult.Text = "";
                lblTotalCostResult.Text = "";
                return;
            }

            if (length <= 0 || width <= 0)
            {
                lblAreaResult.Text = "Length and width must be greater than 0.";
                lblWkFeeResult.Text = "";
                lblTotalCostResult.Text = "";
                return;
            }

            // Calculate area
            double area = length * width;
            lblAreaResult.Text = $"{area:F2} sq ft";

            // Determine weekly fee
            double weeklyFee;

            if (area >= 600)
            {
                weeklyFee = 50;
            }
            else if (area >= 400)
            {
                weeklyFee = 35;
            }
            else
            {
                weeklyFee = 25;
            }

            // Display weekly fee
            lblWkFeeResult.Text = $"${weeklyFee}";

            // Calculate total cost for 20-week season
            double totalCost = weeklyFee * 20;
            lblTotalCostResult.Text = $"${totalCost}";
        }
    }
    }
