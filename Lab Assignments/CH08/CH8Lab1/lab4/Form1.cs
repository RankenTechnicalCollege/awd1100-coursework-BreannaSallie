using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class MovieDatabase : Form
    {
        public MovieDatabase()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] movieNames = {
            "The Lion King",
            "Moana",
            "Frozen",
            "Encanto",
            "Tangled",
            };
            string[] directors =
            {
                "Roger Allers",
                "Ron Clements",
                "Byron Howard",
                "Nathan Greno"
            };
            string[] descriptions =
            {
                "A young lion cub finds his placce in the circle of life and learns about the importance of family.",
                "A spirited young girl sails out across the ocean to save her island and discovers her true destiny.",
                "Two sisters must work together to save their kingdom from eternal winter.",
                "A magical family in Columbia must come together to save their enchanted home.",
                "A princess embarks on a journey after leaving her tower to find freedom with the the help of her long hair."
            };
            string keyword = txtSearch.Text.ToLower();
            bool found = false;

            for (int i = 0; i < movieNames.Length; i++)
            {
                if (movieNames[i].ToLower().Contains(keyword) || directors[i].ToLower().Contains(keyword))
                {
                    lblName.Text = movieNames[i];
                    lblDirector.Text = directors[i];
                    lblDescription.Text = descriptions[i];
                    found = true;
                    break;
                }
            }

            if (!found)
        {
                lblName.Text = "Movie not found.";
                lblDirector.Text = string.Empty;
                lblDescription.Text = string.Empty;
            }
        }
    }
}

