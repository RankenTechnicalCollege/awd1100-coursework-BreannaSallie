using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] gameNames =
            {
"Player Unknown's Battlegrounds (PUBG)",
"League of Legends",
"Call of Duty: Black Ops III",
"Battlefield 4",
"Super Mario Odyssey",
            };
            string[] publishers =
            {
                "Bluehole",
                "Riot Games",
                "Activision",
                "Electronic Arts",
                "Nintendo",
            };

            decimal[] prices = { 35, 0, 60, 20, 60 };

            string keyword = txtSearch.Text.ToLower();
            bool found = false;

            for (int i = 0; i < gameNames.Length; i++)
            {
                if (gameNames[i].ToLower().Contains(keyword) || publishers[i].ToLower().Contains(keyword))
                {
                    lblName.Text = gameNames[i];
                    lblPublisher.Text = publishers[i];
                    lblPrice.Text = $"${prices[i]:0.00}";
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                lblName.Text = "Not found";
                lblPublisher.Text = string.Empty;
                lblPrice.Text = string.Empty;
            }
        }
    }
}

     