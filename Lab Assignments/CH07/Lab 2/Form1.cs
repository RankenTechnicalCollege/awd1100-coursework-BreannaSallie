using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = System.Drawing.Color.Black;
            lblStatus.Text = string.Empty;

            try
            {
                // Parse with the right numeric types
                if (!short.TryParse(txtItemNumber.Text.Trim(), out short item))
                    throw new FormatException("INVALID ITEM NUMBER");

                if (!byte.TryParse(txtQuantity.Text.Trim(), out byte qty))
                    throw new FormatException("INVALID QUANTITY");

                if (!byte.TryParse(txtEstimatedDays.Text.Trim(), out byte days))
                    throw new FormatException("INVALID DELIVERY DAYS");

                // Constructor will throw custom exceptions if ranges are wrong
                var order = new Order(item, qty, days);

                lblStatus.Text = "Order is valid";
            }
            catch (InvalidItemNumberException ex) { ShowError(ex.Message); }
            catch (InvalidQuantityException ex) { ShowError(ex.Message); }
            catch (InvalidDeliveryDaysException ex) { ShowError(ex.Message); }
            catch (FormatException ex) { ShowError(ex.Message); }
        }

        private void ShowError(string msg)
        {
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Text = msg;
        }
    }
}