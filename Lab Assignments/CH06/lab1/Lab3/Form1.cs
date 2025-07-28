using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text;
            int count = CountVowels(phrase);
            lblVowCount.Text = $"Vowel Count: {count}";
        }

        // Method to count vowels
        private int CountVowels(string phrase)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in phrase)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}