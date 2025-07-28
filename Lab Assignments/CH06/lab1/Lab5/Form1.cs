using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            string input = txtCardNumber.Text;
            string masked = MaskNumber(input, '#', 4);
            lblMasked.Text = masked;
        }

        // Mask all letters/digits except the last 4
        private string MaskNumber(string unmaskedCC, char replacementChar, int numDigitsToPreserve)
        {
            int preserveCount = 0;
            string result = "";

            // Work from right to left to preserve the last digits/letters
            for (int i = unmaskedCC.Length - 1; i >= 0; i--)
            {
                char c = unmaskedCC[i];

                if (Char.IsDigit(c) || Char.IsLetter(c))
                {
                    preserveCount++;
                    if (preserveCount <= numDigitsToPreserve)
                        result = c + result;
                    else
                        result = replacementChar + result;
                }
                else
                {
                    // Keep special characters like spaces and dashes
                    result = c + result;
                }
            }

            return result;
        }
    }
}
