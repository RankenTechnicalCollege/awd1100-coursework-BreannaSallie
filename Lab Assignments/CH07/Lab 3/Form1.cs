using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private readonly List<Account> _accounts = new List<Account>
{
    new Account("psmith",  "pass1", "Paul",   false), // active
    new Account("jcam",    "pass2", "Jace",   false), // active
    new Account("bsallie", "pass3", "Sallie", false), // active
    new Account("rfawn",   "pass4", "Ralph",  true),  // disabled
    new Account("bjordan", "pass5", "Jordan", false), // active
};

        public Form1()
        {
            InitializeComponent();
            // Optional polish:
            this.AcceptButton = btnLogin;          // Enter triggers Login
            lblResult.Text = string.Empty;         // start empty
        }

        // UML: BankForm.Login(username, password) : Account
        private Account Login(string username, string password)
        {
            string u = (username ?? string.Empty).Trim();
            string p = (password ?? string.Empty).Trim();

            if (u.Length == 0 || p.Length == 0)
                throw new NoUsernamePasswordException("You must enter a username and password");

            // Find account by username (case-insensitive)
            Account match = null;
            foreach (var a in _accounts)
            {
                if (string.Equals(a.Username, u, StringComparison.OrdinalIgnoreCase))
                {
                    match = a;
                    break;
                }
            }

            if (match == null || match.Password != p)
                throw new IncorrectPasswordException("Incorrect Username/Password");

            if (match.IsDisabled)
                throw new AccountDisabledException("Account Disabled");

            return match;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Black;
            lblResult.Text = string.Empty;

            try
            {
                var acct = Login(txtUsername.Text, txtPassword.Text);
                lblResult.Text = $"Welcome {acct.FirstName}!";
            }
            catch (NoUsernamePasswordException ex) { ShowError(ex.Message); }
            catch (IncorrectPasswordException ex) { ShowError(ex.Message); }
            catch (AccountDisabledException ex) { ShowError(ex.Message); }
        }

        private void ShowError(string msg)
        {
            lblResult.ForeColor = Color.Red;
            lblResult.Text = msg;
        }
    }
}