using System;
using System.Windows.Forms;

namespace Lab5

{
    public partial class Form1 : Form
    {
        private void label1_Click(object sender, EventArgs e) { }
        public Form1()
        {
            InitializeComponent();
            this.Shown += (s, e) => txtPhrase.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text ?? string.Empty;
            int vowelCount = 0;

            // Count vowels (case-insensitive), y is NOT a vowel
            for (int i = 0; i < phrase.Length; i++)
            {
                char c = char.ToLower(phrase[i]);
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                }
            }

            lblResult.Text = $"There are {vowelCount} vowels in your phrase";
        }
    }
}