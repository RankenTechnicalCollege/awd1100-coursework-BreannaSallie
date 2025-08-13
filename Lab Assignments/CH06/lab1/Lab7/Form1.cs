using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        // Sample account data (C# 7.3 compatible initializers)
        readonly List<string> accountNumbers = new List<string> { "123-456-789", "456-789-123" };
        readonly List<string> pins = new List<string> { "1234", "5678" };
        readonly List<decimal> balances = new List<decimal> { 10000.00m, 5000.00m };
        readonly List<string> names = new List<string> { "Mr. Smith", "Ms. Johnson" };

        int currentUserIndex = -1;

        public Form1()
        {
            InitializeComponent();
            lblBalance.Text = "TEST";


            lblBalance.AutoSize = true;

            
            lblMessage.Text = "";
            lblBalance.Text = "";
        }

        private void btnDeposit_Click_1(object sender, EventArgs e) => btnDeposit_Click(sender, e);
        private void btnWithdraw_Click_1(object sender, EventArgs e) => btnWithdraw_Click(sender, e);
        private void btnLogout_Click_1(object sender, EventArgs e) => btnLogout_Click(sender, e);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtAccount.Text.Trim(), txtPin.Text.Trim());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!TryParseMoney(txtDeposit.Text, out var amount) || amount <= 0)
            {
                MessageBox.Show("Enter a positive deposit amount.");
                txtDeposit.SelectAll(); return;
            }
            MakeDeposit(amount);
            txtDeposit.Clear();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!TryParseMoney(txtWithdraw.Text, out var amount) || amount <= 0)
            {
                MessageBox.Show("Enter a positive withdrawal amount.");
                txtWithdraw.SelectAll(); return;
            }
            MakeWithdrawal(amount);
            txtWithdraw.Clear();
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
                lblMessage.Text = $"Welcome {names[index]}!";
                // <-- update the balance label right here
                lblBalance.Text = $"Your account balance is {balances[currentUserIndex]:C2}";
            }
            else
            {
                Logout();
                lblMessage.Text = "Invalid account or pin. Try again.";
            }
        }

        private void Logout()
        {
            currentUserIndex = -1;
            lblMessage.Text = "You have been logged out.";
            lblBalance.Text = "";     // clear balance display
        }

        private void MakeDeposit(decimal amount)
        {
            if (currentUserIndex < 0) { MessageBox.Show("Please login first."); return; }

            balances[currentUserIndex] += amount;
            lblMessage.Text = "Deposit successful!";
            // <-- always refresh the balance label
            lblBalance.Text = $"Your account balance is {balances[currentUserIndex]:C2}";
        }

        private void MakeWithdrawal(decimal amount)
        {
            if (currentUserIndex < 0) { MessageBox.Show("Please login first."); return; }

            if (amount > balances[currentUserIndex])
            {
                lblMessage.Text = "Insufficient funds.";
                return;
            }

            balances[currentUserIndex] -= amount;
            lblMessage.Text = "Withdrawal successful!";
            // <-- always refresh the balance label
            lblBalance.Text = $"Your account balance is {balances[currentUserIndex]:C2}";
        }

        // -------- Helpers ----------------------------------------------------
        private static bool TryParseMoney(string s, out decimal value) =>
            decimal.TryParse(s, NumberStyles.Currency, CultureInfo.CurrentCulture, out value);

        private void lbldeposit_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}