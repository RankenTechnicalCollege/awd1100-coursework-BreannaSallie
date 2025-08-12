using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_3   // match Program.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // EXACT signature requested by the lab
        public string ParseBid(string bidString)
        {
            if (string.IsNullOrWhiteSpace(bidString))
                return "Invalid Bid";

            string input = bidString.Trim();

            // Accept only the formats from the handout
            var mA = Regex.Match(input, @"^\$\s*(\d+(?:\.0{1,2})?)\s*$", RegexOptions.IgnoreCase);          // $34, $ 34.0, $34.00
            var mB = Regex.Match(input, @"^(\d+(?:\.0{1,2})?)\s*$", RegexOptions.IgnoreCase);               // 34, 34.0, 34.00
            var mC = Regex.Match(input, @"^(\d+(?:\.0{1,2})?)\s+dollars?$", RegexOptions.IgnoreCase);       // 34 dollars, 34.00 dollars

            decimal amount;
            if (mA.Success && decimal.TryParse(mA.Groups[1].Value, NumberStyles.Number, CultureInfo.InvariantCulture, out amount)) { }
            else if (mC.Success && decimal.TryParse(mC.Groups[1].Value, NumberStyles.Number, CultureInfo.InvariantCulture, out amount)) { }
            else if (mB.Success && decimal.TryParse(mB.Groups[1].Value, NumberStyles.Number, CultureInfo.InvariantCulture, out amount)) { }
            else
                return "Invalid Bid";

            if (amount < 10m)
                return "Bid must be at least $10";

            return $"Bid of ${amount:0.00} accepted!";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string msg = ParseBid(txtBid.Text);
            lblResult.Text = msg;
            lblResult.ForeColor = msg.StartsWith("Bid of $") ? Color.SeaGreen : Color.Firebrick;
        }
    }
}
