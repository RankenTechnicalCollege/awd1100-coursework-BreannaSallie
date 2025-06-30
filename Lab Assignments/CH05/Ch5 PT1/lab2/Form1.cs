using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            int speed;

            // Validate input from txtWindSpeed
            bool isValid = int.TryParse(txtWindSpeed.Text, out speed);

            if (!isValid || speed < 0)
            {
                lblCategoryResult.Text = "Please enter a valid wind speed.";
                return;
            }

            // Determine hurricane category
            if (speed >= 157)
            {
                lblCategoryResult.Text = "Category 5 Hurricane";
            }
            else if (speed >= 130)
            {
                lblCategoryResult.Text = "Category 4 Hurricane";
            }
            else if (speed >= 111)
            {
                lblCategoryResult.Text = "Category 3 Hurricane";
            }
            else if (speed >= 96)
            {
                lblCategoryResult.Text = "Category 2 Hurricane";
            }
            else if (speed >= 74)
            {
                lblCategoryResult.Text = "Category 1 Hurricane";
            }
            else
            {
                lblCategoryResult.Text = "Not a hurricane";
            }
        }
    }
    }
