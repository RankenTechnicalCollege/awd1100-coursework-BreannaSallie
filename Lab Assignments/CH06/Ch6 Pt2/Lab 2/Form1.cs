using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_2   // Match your Program.cs namespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Lab method: sorts the array in place
        public void SortWords(string[] unsortedWords)
        {
            Array.Sort(unsortedWords, StringComparer.CurrentCultureIgnoreCase);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input = txtPhrase.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                if (lblStatus != null)
                {
                    lblStatus.Text = "Type a phrase first.";
                    lblStatus.ForeColor = Color.Firebrick;
                }
                return;
            }

            // split on spaces + punctuation
            char[] sep = " ,.;:!?\"'\t\r\n()[]{}".ToCharArray();
            string[] words = input.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                if (lblStatus != null)
                {
                    lblStatus.Text = "No words found.";
                    lblStatus.ForeColor = Color.Firebrick;
                }
                return;
            }

            SortWords(words); // sort in place

            txtSorted.ReadOnly = false;          // allow programmatic write
            txtSorted.Text = string.Join(" ", words);
            txtSorted.ReadOnly = true;

            if (lblStatus != null)
            {
                lblStatus.Text = "Sorted!";
                lblStatus.ForeColor = Color.SeaGreen;
            }
        }
    }
}
