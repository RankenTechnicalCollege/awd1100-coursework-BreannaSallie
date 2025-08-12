namespace Lab_2
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
            this.lblItemNum = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblEstimated = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtEstimatedDays = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemNum
            // 
            this.lblItemNum.Location = new System.Drawing.Point(51, 50);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(127, 23);
            this.lblItemNum.TabIndex = 0;
            this.lblItemNum.Text = "Item Number [100,999]";
            // 
            // lblQuant
            // 
            this.lblQuant.Location = new System.Drawing.Point(51, 74);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(127, 23);
            this.lblQuant.TabIndex = 1;
            this.lblQuant.Text = "Quantity [1,12]";
            // 
            // lblEstimated
            // 
            this.lblEstimated.Location = new System.Drawing.Point(51, 103);
            this.lblEstimated.Name = "lblEstimated";
            this.lblEstimated.Size = new System.Drawing.Size(161, 23);
            this.lblEstimated.TabIndex = 2;
            this.lblEstimated.Text = "Estimated Delivery Days [1,30]";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNumber.Location = new System.Drawing.Point(245, 48);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(166, 20);
            this.txtItemNumber.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(245, 77);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(166, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtEstimatedDays
            // 
            this.txtEstimatedDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstimatedDays.Location = new System.Drawing.Point(245, 103);
            this.txtEstimatedDays.Name = "txtEstimatedDays";
            this.txtEstimatedDays.Size = new System.Drawing.Size(166, 20);
            this.txtEstimatedDays.TabIndex = 5;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(290, 148);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(181, 227);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(269, 23);
            this.lblStatus.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtEstimatedDays);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblEstimated);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblItemNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblEstimated;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtEstimatedDays;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblStatus;
    }
}

