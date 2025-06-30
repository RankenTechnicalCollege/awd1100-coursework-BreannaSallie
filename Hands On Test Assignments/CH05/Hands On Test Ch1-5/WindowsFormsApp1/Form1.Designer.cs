namespace WindowsFormsApp1
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblWkFee = new System.Windows.Forms.Label();
            this.lblSeasonL = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblAreaResult = new System.Windows.Forms.Label();
            this.lblWkFeeResult = new System.Windows.Forms.Label();
            this.lblSeasonLResult = new System.Windows.Forms.Label();
            this.lblTotalCostResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(106, 92);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(83, 20);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (ft)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(447, 92);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(74, 20);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (ft)";
            // 
            // txtLength
            // 
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(110, 125);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(119, 24);
            this.txtLength.TabIndex = 2;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(451, 125);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(122, 24);
            this.txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(292, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 27);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(110, 231);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 23);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area:";
            // 
            // lblWkFee
            // 
            this.lblWkFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWkFee.Location = new System.Drawing.Point(110, 254);
            this.lblWkFee.Name = "lblWkFee";
            this.lblWkFee.Size = new System.Drawing.Size(100, 23);
            this.lblWkFee.TabIndex = 6;
            this.lblWkFee.Text = "Weekly Fee:";
            // 
            // lblSeasonL
            // 
            this.lblSeasonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeasonL.Location = new System.Drawing.Point(110, 277);
            this.lblSeasonL.Name = "lblSeasonL";
            this.lblSeasonL.Size = new System.Drawing.Size(119, 23);
            this.lblSeasonL.TabIndex = 7;
            this.lblSeasonL.Text = "Season Length:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(110, 300);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(100, 23);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost: ";
            // 
            // lblAreaResult
            // 
            this.lblAreaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaResult.Location = new System.Drawing.Point(158, 231);
            this.lblAreaResult.Name = "lblAreaResult";
            this.lblAreaResult.Size = new System.Drawing.Size(140, 23);
            this.lblAreaResult.TabIndex = 9;
            // 
            // lblWkFeeResult
            // 
            this.lblWkFeeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWkFeeResult.Location = new System.Drawing.Point(198, 254);
            this.lblWkFeeResult.Name = "lblWkFeeResult";
            this.lblWkFeeResult.Size = new System.Drawing.Size(149, 23);
            this.lblWkFeeResult.TabIndex = 10;
            // 
            // lblSeasonLResult
            // 
            this.lblSeasonLResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeasonLResult.Location = new System.Drawing.Point(216, 277);
            this.lblSeasonLResult.Name = "lblSeasonLResult";
            this.lblSeasonLResult.Size = new System.Drawing.Size(148, 23);
            this.lblSeasonLResult.TabIndex = 11;
            // 
            // lblTotalCostResult
            // 
            this.lblTotalCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostResult.Location = new System.Drawing.Point(187, 299);
            this.lblTotalCostResult.Name = "lblTotalCostResult";
            this.lblTotalCostResult.Size = new System.Drawing.Size(160, 23);
            this.lblTotalCostResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCostResult);
            this.Controls.Add(this.lblSeasonLResult);
            this.Controls.Add(this.lblWkFeeResult);
            this.Controls.Add(this.lblAreaResult);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblSeasonL);
            this.Controls.Add(this.lblWkFee);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "Form1";
            this.Text = "Greg\'s Lawncare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblWkFee;
        private System.Windows.Forms.Label lblSeasonL;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblAreaResult;
        private System.Windows.Forms.Label lblWkFeeResult;
        private System.Windows.Forms.Label lblSeasonLResult;
        private System.Windows.Forms.Label lblTotalCostResult;
    }
}

