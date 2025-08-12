namespace Lab_4
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(44, 41);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(175, 20);
            this.txtValue.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(244, 41);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(41, 91);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(178, 23);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Numbers Entered:";
            // 
            // lblLowest
            // 
            this.lblLowest.Location = new System.Drawing.Point(41, 114);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(178, 23);
            this.lblLowest.TabIndex = 3;
            this.lblLowest.Text = "Lowest:";
            // 
            // lblHighest
            // 
            this.lblHighest.Location = new System.Drawing.Point(41, 137);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(178, 23);
            this.lblHighest.TabIndex = 4;
            this.lblHighest.Text = "Highest:";
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(41, 160);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(178, 23);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Sum:";
            // 
            // lblAvg
            // 
            this.lblAvg.Location = new System.Drawing.Point(41, 183);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(178, 23);
            this.lblAvg.TabIndex = 6;
            this.lblAvg.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 258);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtValue);
            this.Name = "Form1";
            this.Text = "Integer Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAvg;
    }
}

