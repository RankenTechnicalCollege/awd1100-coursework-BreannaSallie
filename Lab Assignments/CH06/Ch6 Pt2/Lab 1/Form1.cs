using System;
using System.Windows.Forms;

namespace Lab1   // <-- or whatever your project namespace is
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Lab method
        private void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            int t = num1; num1 = num4; num4 = t;   // swap 1 <-> 4
            t = num2; num2 = num3; num3 = t;       // swap 2 <-> 3
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out int n1) ||
                !int.TryParse(txtNum2.Text, out int n2) ||
                !int.TryParse(txtNum3.Text, out int n3) ||
                !int.TryParse(txtNum4.Text, out int n4))
            {
                if (lblStatus != null) lblStatus.Text = "Enter 4 whole numbers.";
                return;
            }

            Reverse4(ref n1, ref n2, ref n3, ref n4);

            txtNum1.Text = n1.ToString();
            txtNum2.Text = n2.ToString();
            txtNum3.Text = n3.ToString();
            txtNum4.Text = n4.ToString();

            if (lblStatus != null) lblStatus.Text = "Reversed!";
        }
    }
}
