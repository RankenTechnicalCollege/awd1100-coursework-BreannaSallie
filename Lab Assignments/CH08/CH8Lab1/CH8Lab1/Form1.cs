using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH8Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int[] zipCodes = { 63101, 63103, 63105, 63109, 63113, 63118, 63130, 63133, 63136, 63137 };
            decimal[] charges = { 20, 12, 25, 15, 10, 23, 18, 20, 17, 12 };

            lblResult.Text = "";
            if (int.TryParse(txtZipCode.Text, out int zipCode))
            {
                bool found = false;
                for (int i = 0; i < zipCodes.Length; i++)
                {
                    if (zipCode == zipCodes[i])
                    {
                        lblResult.Text = "$" + charges[i].ToString("F2");
                        found = true;
                        break;

                    }
                }
                if (!found)
                {
                    lblResult.Text = "Zip code not found.";
                }
            }
            else
            {
                lblResult.Text = "Please enter a valid zip code.";
            }
        }
    }
}

