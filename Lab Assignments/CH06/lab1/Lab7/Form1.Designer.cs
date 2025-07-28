namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accnum = new System.Windows.Forms.Label();
            this.pinnum = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lbldeposit = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblwithdraw = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accnum
            // 
            this.accnum.Location = new System.Drawing.Point(35, 33);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(100, 23);
            this.accnum.TabIndex = 0;
            this.accnum.Text = "Account #";
            // 
            // pinnum
            // 
            this.pinnum.Location = new System.Drawing.Point(35, 70);
            this.pinnum.Name = "pinnum";
            this.pinnum.Size = new System.Drawing.Size(100, 23);
            this.pinnum.TabIndex = 1;
            this.pinnum.Text = "Pin #";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(103, 30);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(171, 20);
            this.txtAccount.TabIndex = 2;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(103, 67);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(171, 20);
            this.txtPin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(299, 46);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(35, 110);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(339, 49);
            this.lblMessage.TabIndex = 5;
            // 
            // lbldeposit
            // 
            this.lbldeposit.Location = new System.Drawing.Point(35, 184);
            this.lbldeposit.Name = "lbldeposit";
            this.lbldeposit.Size = new System.Drawing.Size(212, 23);
            this.lbldeposit.TabIndex = 6;
            this.lbldeposit.Text = "Would you like to make a deposit?";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(236, 210);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(38, 212);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(171, 20);
            this.txtDeposit.TabIndex = 8;
            // 
            // lblwithdraw
            // 
            this.lblwithdraw.Location = new System.Drawing.Point(35, 262);
            this.lblwithdraw.Name = "lblwithdraw";
            this.lblwithdraw.Size = new System.Drawing.Size(212, 23);
            this.lblwithdraw.TabIndex = 9;
            this.lblwithdraw.Text = "Would you like to make a withdrawal?";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(236, 257);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(103, 332);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(38, 288);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(171, 20);
            this.txtWithdraw.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 398);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblwithdraw);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lbldeposit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.pinnum);
            this.Controls.Add(this.accnum);
            this.Name = "Form1";
            this.Text = "Weyland Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accnum;
        private System.Windows.Forms.Label pinnum;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lbldeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblwithdraw;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtWithdraw;
    }
}

