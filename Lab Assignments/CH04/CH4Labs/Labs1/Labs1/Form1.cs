using System.Linq.Expressions;

namespace Labs1
{
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDistanceKilo_Click(object sender, EventArgs e)
        {

        }

        private void btntokm_Click(object sender, EventArgs e)
        {
            try
            {
                double miles = double.Parse(txtMiles.Text);
                double km = miles * 1.6;
                txtKilo.Text = km.ToString("0.00");
                lblResult.Text = $"{miles} miles is equal to {km} kilometers.";
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for kilometers.");
            }

        }

        private void btntomiles_Click(object sender, EventArgs e)
        {
            try
            {
                double km = double.Parse(txtKilo.Text);
                double miles = km / 1.6;
                txtMiles.Text = miles.ToString("0.00");
                lblResult.Text = $"{km} kilometers is equal to {miles} miles.";

            }
            catch
            {
                MessageBox.Show("Please enter a valid number for miles.");
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}