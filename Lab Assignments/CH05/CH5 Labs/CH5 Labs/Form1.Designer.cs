namespace CH5_Labs
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumScores = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 124);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(97, 33);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 89);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(321, 29);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter a test score";
            // 
            // lblNumScores
            // 
            this.lblNumScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumScores.Location = new System.Drawing.Point(8, 176);
            this.lblNumScores.Name = "lblNumScores";
            this.lblNumScores.Size = new System.Drawing.Size(321, 44);
            this.lblNumScores.TabIndex = 3;
            this.lblNumScores.Text = "Nmber of scores:";
            // 
            // lblSum
            // 
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(8, 220);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(321, 44);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Sum of test scores:";
            // 
            // lblAverage
            // 
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(8, 264);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(321, 44);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average test scores:";
            // 
            // lblLowest
            // 
            this.lblLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowest.Location = new System.Drawing.Point(8, 310);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(321, 44);
            this.lblLowest.TabIndex = 6;
            this.lblLowest.Text = "Lowest test scores:";
            // 
            // lblHighest
            // 
            this.lblHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighest.Location = new System.Drawing.Point(8, 354);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(321, 44);
            this.lblHighest.TabIndex = 7;
            this.lblHighest.Text = "Highest test scores:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblNumScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumScores;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
    }
}

