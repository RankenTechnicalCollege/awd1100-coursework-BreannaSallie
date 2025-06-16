using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtCardNum.Text;
            char[] result = new char[input.Length];
            int digitsCount = 0;

            // Count total number of digits/letters first
            foreach (char c in input)
            {
                if (char.IsDigit(c) || char.IsLetter(c))
                {
                    digitsCount++;
                }
            }

            int visibleCount = 0;

            // Replace characters with #
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];

                if (char.IsDigit(c) || char.IsLetter(c))
                {
                    if (visibleCount < 4)
                    {
                        result[i] = c;
                        visibleCount++;
                    }
                    else
                    {
                        result[i] = '#';
                    }
                }
                else
                {
                    result[i] = c; // Keep space or dash
                }
            }

            lblMasked.Text = new string(result);
        }
    }
}