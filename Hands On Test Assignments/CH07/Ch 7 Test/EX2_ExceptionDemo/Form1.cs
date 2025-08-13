using System;
using System.Windows.Forms;

namespace Ch7Test   
{
    public partial class ExceptionsForm : Form
    {
        public ExceptionsForm()
        {
            InitializeComponent();
        }

        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 1, b = 0;
                int c = a / b; // DivideByZeroException -> ArithmeticException
            }
            catch (ArithmeticException)
            {
                MessageBox.Show(
                    "You tried to divide by zero. Use a non-zero number.",
                    "Arithmetic Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse("not a number"); // FormatException
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "That text isn’t a valid number. Try digits only (e.g., 82).",
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInvalidCast_Click(object sender, EventArgs e)
        {
            try
            {
                object o = new Button();
                string s = (string)o; // InvalidCastException
                _ = s.Length;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(
                    "That object can’t be converted to the requested type.",
                    "Invalid Cast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNullRef_Click(object sender, EventArgs e)
        {
            try
            {
                string s = null;
                int len = s.Length; // NullReferenceException
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(
                    "You used something that hasn’t been created yet (null).",
                    "Null Reference", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
