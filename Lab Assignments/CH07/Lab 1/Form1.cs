using Lab_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = string.Empty;

            try
            {
                if (!float.TryParse(txtWeight.Text, out float weight))
                    throw new FormatException("INVALID WEIGHT");

                if (!float.TryParse(txtHeight.Text, out float height))
                    throw new FormatException("INVALID HEIGHT");

                var result = BmiCalculator.CalcBmi(weight, height);

                lblStatus.Text = $"BMI: {result.BmiValue:F1}\nCategory: {ToDisplay(result.WeightCategory)}";
            }
            catch (InvalidWeightException ex) { ShowError(ex.Message); }
            catch (InvalidHeightException ex) { ShowError(ex.Message); }
            catch (FormatException ex) { ShowError(ex.Message); }
        }

        private void ShowError(string msg)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = msg;
        }

        private string ToDisplay(WeightCategory c)
        {
            switch (c)
            {
                case WeightCategory.NORMAL: return "Normal BMI";
                case WeightCategory.UNDERWEIGHT: return "Underweight";
                case WeightCategory.OVERWEIGHT: return "Overweight";
                case WeightCategory.OBESE: return "Obese";
                default: return c.ToString();
            }
        }
    }
}
