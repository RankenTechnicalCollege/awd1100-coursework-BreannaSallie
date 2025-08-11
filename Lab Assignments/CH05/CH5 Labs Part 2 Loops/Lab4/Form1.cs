using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        decimal danielleSales = 0;
        decimal edwardSales = 0;
        decimal francisSales = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDanielle_Click(object sender, EventArgs e)
        {
            AddSale("Danielle");
        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            AddSale("Edward");
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            AddSale("Francis");
        }

        private void AddSale(string seller)
        {
            if (decimal.TryParse(txtSaleAmount.Text, out decimal amount))
            {
                if (seller == "Danielle") danielleSales += amount;
                else if (seller == "Edward") edwardSales += amount;
                else if (seller == "Francis") francisSales += amount;

                UpdateDisplay();
                txtSaleAmount.Clear();
                txtSaleAmount.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the sale amount.");
            }
        }

        private void UpdateDisplay()
        {
            lblDanielle.Text = $"Danielle Sales: {danielleSales:C}";
            lblEdward.Text = $"Edward Sales: {edwardSales:C}";
            lblFrancis.Text = $"Francis Sales: {francisSales:C}";

            decimal grandTotal = danielleSales + edwardSales + francisSales;
            lblGrandTotal.Text = $"Grand Total: {grandTotal:C}";

            // Find top seller
            string topSeller = "";
            decimal highestSales = Math.Max(danielleSales, Math.Max(edwardSales, francisSales));

            if (highestSales == danielleSales) topSeller = "Danielle";
            else if (highestSales == edwardSales) topSeller = "Edward";
            else if (highestSales == francisSales) topSeller = "Francis";

            lblTopSeller.Text = $"{topSeller} has the most sales";
        }
    }
}