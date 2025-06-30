using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hands_On_Test_Ch1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double inches;

            // Read and validate input from txtInches
            if (double.TryParse(txtInches.Text, out inches))
            {
                double centimeters = inches * 2.54;
                lblResult.Text = $"{inches} inches = {centimeters:F2} cm";
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";
            }
        }
    }
    }

