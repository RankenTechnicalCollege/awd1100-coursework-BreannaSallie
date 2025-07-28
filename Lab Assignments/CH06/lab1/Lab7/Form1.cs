using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        // Sample account data
        List<string> accountNumbers = new List<string> { "123-456-789", "456-789-123" };
        List<string> pins = new List<string> { "1234", "5678" };
        List<decimal> balances = new List<decimal> { 10000.00m, 5000.00m };
        List<string> names = new List<string> { "Mr. Smith", "Ms. Johnson" };

        int currentUserIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtAccount.Text, txtPin.Text);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDeposit.Text, out decimal amount))
                MakeDeposit(amount);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdraw.Text, out decimal amount))
                MakeWithdrawal(amount);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Login(string accountNum, string pin)
        {
            int index = accountNumbers.IndexOf(accountNum);

            if (index != -1 && pins[index] == pin)
            {
                currentUserIndex = index;
                lblMessage.Text = $"Welcome {names[index]}!\nYour account balance is ${balances[index]:N2}";
            }
            else
            {
                Logout(); // Clear previous user if any
                lblMessage.Text = "Invalid account or pin. Try again.";
            }
        }

        private void Logout()
        {
            currentUserIndex = -1;
            lblMessage.Text = "You have been logged out.";
        }

        private void MakeDeposit(decimal depositAmount)
        {
            if (currentUserIndex >= 0)
            {
                balances[currentUserIndex] += depositAmount;
                lblMessage.Text = $"Deposit successful!\nNew balance: ${balances[currentUserIndex]:N2}";
            }
        }

        private void MakeWithdrawal(decimal withdrawalAmount)
        {
            if (currentUserIndex >= 0)
            {
                if (balances[currentUserIndex] >= withdrawalAmount)
                {
                    balances[currentUserIndex] -= withdrawalAmount;
                    lblMessage.Text = $"Withdrawal successful!\nNew balance: ${balances[currentUserIndex]:N2}";
                }
                else
                {
                    lblMessage.Text = "Insufficient funds.";
                }
            }
        }
    }
}
