namespace Labs2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtChicken1 = new TextBox();
            txtChicken2 = new TextBox();
            txtChicken3 = new TextBox();
            txtChicken4 = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(203, 75);
            label1.Name = "label1";
            label1.Size = new Size(308, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter number of eggs laid by each chicken:";
            label1.Click += label1_Click;
            // 
            // txtChicken1
            // 
            txtChicken1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtChicken1.BackColor = Color.White;
            txtChicken1.BorderStyle = BorderStyle.FixedSingle;
            txtChicken1.Location = new Point(83, 140);
            txtChicken1.Name = "txtChicken1";
            txtChicken1.Size = new Size(100, 23);
            txtChicken1.TabIndex = 1;
            // 
            // txtChicken2
            // 
            txtChicken2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtChicken2.BackColor = Color.White;
            txtChicken2.BorderStyle = BorderStyle.FixedSingle;
            txtChicken2.Location = new Point(219, 140);
            txtChicken2.Name = "txtChicken2";
            txtChicken2.Size = new Size(100, 23);
            txtChicken2.TabIndex = 2;
            // 
            // txtChicken3
            // 
            txtChicken3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtChicken3.BackColor = Color.White;
            txtChicken3.BorderStyle = BorderStyle.FixedSingle;
            txtChicken3.Location = new Point(353, 140);
            txtChicken3.Name = "txtChicken3";
            txtChicken3.Size = new Size(100, 23);
            txtChicken3.TabIndex = 3;
            // 
            // txtChicken4
            // 
            txtChicken4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtChicken4.BackColor = Color.White;
            txtChicken4.BorderStyle = BorderStyle.FixedSingle;
            txtChicken4.Location = new Point(488, 140);
            txtChicken4.Name = "txtChicken4";
            txtChicken4.Size = new Size(100, 23);
            txtChicken4.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(285, 197);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(132, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(238, 258);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(258, 21);
            lblResult.TabIndex = 6;
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtChicken4);
            Controls.Add(txtChicken3);
            Controls.Add(txtChicken2);
            Controls.Add(txtChicken1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Chicken Farmer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtChicken1;
        private TextBox txtChicken2;
        private TextBox txtChicken3;
        private TextBox txtChicken4;
        private Button btnCalculate;
        private Label lblResult;
    }
}
