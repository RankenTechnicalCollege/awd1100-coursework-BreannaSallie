using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        // Variables to track sales totals
        double danielleSales = 0;
        double edwardSales = 0;
        double francisSales = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Button: Danielle
        private void btnDanielle_Click(object sender, EventArgs e)
        {
            AddSale(ref danielleSales);
        }

        // Button: Edward
        private void btnEdward_Click(object sender, EventArgs e)
        {
            AddSale(ref edwardSales);
        }

        // Button: Francis
        private void btnFrancis_Click(object sender, EventArgs e)
        {
            AddSale(ref francisSales);
        }

        // Method to add sales
        private void AddSale(ref double salespersonSales)
        {
            double amount;

            if (double.TryParse(txtAmount.Text, out amount) && amount >= 0)
            {
                salespersonSales += amount;
                UpdateDisplay();
                txtAmount.Clear();
                txtAmount.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid, non-negative sale amount.");
                txtAmount.Clear();
                txtAmount.Focus();
            }
        }

        // Method to update the display labels
        private void UpdateDisplay()
        {
            double grandTotal = danielleSales + edwardSales + francisSales;

            lblDanielle.Text = $"Danielle Sales: {danielleSales:C}";
            lblEdward.Text = $"Edward Sales: {edwardSales:C}";
            lblFrancis.Text = $"Francis Sales: {francisSales:C}";
            lblGrandTotal.Text = $"Grand Total: {grandTotal:C}";

            string topSalesperson = "Danielle";
            double topSales = danielleSales;

            if (edwardSales > topSales)
            {
                topSales = edwardSales;
                topSalesperson = "Edward";
            }

            if (francisSales > topSales)
            {
                topSales = francisSales;
                topSalesperson = "Francis";
            }

            lblTopSales.Text = $"{topSalesperson} has the most sales";
        }

        // Optional: Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            danielleSales = 0;
            edwardSales = 0;
            francisSales = 0;
            UpdateDisplay();
            txtAmount.Clear();
        }
    }
}

