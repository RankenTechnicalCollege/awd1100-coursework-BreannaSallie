using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Vowels : Form
    {
        public Vowels()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCountVowels_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text;
            int vowelCount = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                string currentChar = phrase.Substring(i, 1).ToLower();

                switch (currentChar)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        vowelCount++;
                        break;
                }
            }

            lblResult.Text = $"There are {vowelCount} vowels in your phrase.";
        }
    }
}