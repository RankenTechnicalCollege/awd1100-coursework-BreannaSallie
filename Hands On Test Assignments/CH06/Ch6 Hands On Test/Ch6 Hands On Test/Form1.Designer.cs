namespace Ch6_Hands_On_Test
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.btnISBN = new System.Windows.Forms.Button();
            this.btnKeyword = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblDescribeResult = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblAuthorResult = new System.Windows.Forms.Label();
            this.lblISBNResult = new System.Windows.Forms.Label();
            this.lblISBNNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(21, 25);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(21, 54);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 20);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(9, 82);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(69, 20);
            this.lblKeyword.TabIndex = 2;
            this.lblKeyword.Text = "Keyword";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(84, 27);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(276, 24);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(84, 54);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(276, 24);
            this.txtISBN.TabIndex = 4;
            // 
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(84, 82);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(276, 24);
            this.txtKeyword.TabIndex = 5;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchAuthor.Location = new System.Drawing.Point(366, 28);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(91, 23);
            this.btnSearchAuthor.TabIndex = 6;
            this.btnSearchAuthor.Text = "Search";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // btnISBN
            // 
            this.btnISBN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnISBN.Location = new System.Drawing.Point(366, 57);
            this.btnISBN.Name = "btnISBN";
            this.btnISBN.Size = new System.Drawing.Size(91, 23);
            this.btnISBN.TabIndex = 7;
            this.btnISBN.Text = "Search";
            this.btnISBN.UseVisualStyleBackColor = true;
            // 
            // btnKeyword
            // 
            this.btnKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKeyword.Location = new System.Drawing.Point(366, 86);
            this.btnKeyword.Name = "btnKeyword";
            this.btnKeyword.Size = new System.Drawing.Size(91, 23);
            this.btnKeyword.TabIndex = 8;
            this.btnKeyword.Text = "Search";
            this.btnKeyword.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 177);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblNameResult
            // 
            this.lblNameResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameResult.Location = new System.Drawing.Point(12, 197);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(393, 42);
            this.lblNameResult.TabIndex = 10;
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(8, 258);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(89, 20);
            this.lblDescribe.TabIndex = 11;
            this.lblDescribe.Text = "Description";
            // 
            // lblDescribeResult
            // 
            this.lblDescribeResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescribeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribeResult.Location = new System.Drawing.Point(12, 278);
            this.lblDescribeResult.Name = "lblDescribeResult";
            this.lblDescribeResult.Size = new System.Drawing.Size(393, 76);
            this.lblDescribeResult.TabIndex = 12;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(12, 368);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(57, 20);
            this.lblAuthorName.TabIndex = 13;
            this.lblAuthorName.Text = "Author";
            // 
            // lblAuthorResult
            // 
            this.lblAuthorResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuthorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorResult.Location = new System.Drawing.Point(13, 388);
            this.lblAuthorResult.Name = "lblAuthorResult";
            this.lblAuthorResult.Size = new System.Drawing.Size(393, 42);
            this.lblAuthorResult.TabIndex = 14;
            // 
            // lblISBNResult
            // 
            this.lblISBNResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblISBNResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBNResult.Location = new System.Drawing.Point(12, 473);
            this.lblISBNResult.Name = "lblISBNResult";
            this.lblISBNResult.Size = new System.Drawing.Size(393, 42);
            this.lblISBNResult.TabIndex = 15;
            // 
            // lblISBNNumber
            // 
            this.lblISBNNumber.AutoSize = true;
            this.lblISBNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBNNumber.Location = new System.Drawing.Point(9, 453);
            this.lblISBNNumber.Name = "lblISBNNumber";
            this.lblISBNNumber.Size = new System.Drawing.Size(70, 20);
            this.lblISBNNumber.TabIndex = 16;
            this.lblISBNNumber.Text = "ISBN-13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 542);
            this.Controls.Add(this.lblISBNNumber);
            this.Controls.Add(this.lblISBNResult);
            this.Controls.Add(this.lblAuthorResult);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblDescribeResult);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblNameResult);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnKeyword);
            this.Controls.Add(this.btnISBN);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Name = "Form1";
            this.Text = "Books and Antiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button btnISBN;
        private System.Windows.Forms.Button btnKeyword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblDescribeResult;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblAuthorResult;
        private System.Windows.Forms.Label lblISBNResult;
        private System.Windows.Forms.Label lblISBNNumber;
    }
}

