using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            string wood = GetWood();
            int drawers = GetDrawers();

            double woodCost = CalculateWoodCost(wood);
            double drawerCost = CalculateDrawerCost(drawers);
            double totalCost = CalculateTotalCost(wood, drawers);

            lblWoodCost.Text = $"Cost of Wood: ${woodCost}";
            lblDrawerCost.Text = $"Cost of Drawers: ${drawerCost}";
            lblTotalCost.Text = $"Total Cost: ${totalCost}";
        }

        private string GetWood()
        {
            string input = txtWood.Text.ToLower();

            switch (input)
            {
                case "m":
                    return "mahogany";
                case "o":
                    return "oak";
                case "p":
                    return "pine";
                default:
                    return "other";
            }
        }

        private int GetDrawers()
        {
            int.TryParse(txtDrawers.Text, out int numDrawers);
            return numDrawers;
        }

        private double CalculateWoodCost(string woodType)
        {
            switch (woodType)
            {
                case "pine":
                    return 100.0;
                case "oak":
                    return 140.0;
                default:
                    return 180.0; // includes mahogany and other
            }
        }

        private double CalculateDrawerCost(int numDrawers)
        {
            return numDrawers * 30.0;
        }

        private double CalculateTotalCost(string woodType, int numDrawers)
        {
            double woodCost = CalculateWoodCost(woodType);
            double drawerCost = CalculateDrawerCost(numDrawers);
            return woodCost + drawerCost;
        }
    }
}