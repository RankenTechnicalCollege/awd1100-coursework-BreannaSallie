namespace Labs2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int chicken1 = int.Parse(txtChicken1.Text);
                int chicken2 = int.Parse(txtChicken2.Text);
                int chicken3 = int.Parse(txtChicken3.Text);
                int chicken4 = int.Parse(txtChicken4.Text);

                int totaleggs = chicken1 + chicken2 + chicken3 + chicken4;
                int dozens = totaleggs / 12;
                int remainder = totaleggs % 12;

                lblResult.Text = $"Total; {dozens} dozen and {remainder} eggs";


            }
            catch
            {
                MessageBox.Show("Please enter valid whole numbers for all the chickens.");
            }
        }


        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
