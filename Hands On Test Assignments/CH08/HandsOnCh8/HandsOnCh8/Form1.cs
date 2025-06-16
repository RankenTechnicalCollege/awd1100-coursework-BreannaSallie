using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactLookup
{
    public partial class Form1 : Form
    {
        // Parallel lists for storing contact information
        List<string> firstNames = new List<string> { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        List<string> lastNames = new List<string> { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        List<string> phoneNumbers = new List<string> { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < firstNames.Count; i++)
            {
                if (string.Equals(firstNames[i], input, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(lastNames[i], input, StringComparison.OrdinalIgnoreCase))
                {
                    lblFirstName.Text = "First Name: " + firstNames[i];
                    lblLastName.Text = "Last Name: " + lastNames[i];
                    lblPhone.Text = "Phone #: " + phoneNumbers[i];
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                lblFirstName.Text = "First Name: error";
                lblLastName.Text = "Last Name: error";
                lblPhone.Text = "Phone #: error";
                MessageBox.Show("User Not Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
