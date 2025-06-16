using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nightRanges = { 2, 4, 7, int.MaxValue };
            decimal[] nightlyRates = { 200m, 180m, 160m, 145m };

            lblNightlyCost.Text = "";
            lblTotalCost.Text = "";

            if (int.TryParse(txtNights.Text, out int nights) && nights > 0)
            {
                for (int i = 0; i < nightRanges.Length; i++)
                {
                    if (nights <= nightRanges[i])
                    {
                        decimal nightlyRate = nightlyRates[i];
                        decimal totalCost = nights * nightlyRate;
                        lblNightlyCost.Text = "$" + nightlyRate.ToString("0.00");
                        lblTotalCost.Text = "$" + totalCost.ToString("0.00");
                        break;
                    }
                }
            }
            else
            {
                lblNightlyCost.Text = "Invalid input";
                lblTotalCost.Text = "";
            }
        }
    }
}

