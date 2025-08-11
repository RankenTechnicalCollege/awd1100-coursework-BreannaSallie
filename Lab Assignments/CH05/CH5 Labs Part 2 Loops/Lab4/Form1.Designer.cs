namespace lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaleAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDanielle = new System.Windows.Forms.Button();
            this.btnEdward = new System.Windows.Forms.Button();
            this.btnFrancis = new System.Windows.Forms.Button();
            this.lblDanielle = new System.Windows.Forms.Label();
            this.lblEdward = new System.Windows.Forms.Label();
            this.lblFrancis = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTopSeller = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much was this sale?";
            // 
            // txtSaleAmount
            // 
            this.txtSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaleAmount.Location = new System.Drawing.Point(12, 59);
            this.txtSaleAmount.Name = "txtSaleAmount";
            this.txtSaleAmount.Size = new System.Drawing.Size(180, 24);
            this.txtSaleAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Who made this sale?";
            // 
            // btnDanielle
            // 
            this.btnDanielle.Location = new System.Drawing.Point(16, 136);
            this.btnDanielle.Name = "btnDanielle";
            this.btnDanielle.Size = new System.Drawing.Size(75, 33);
            this.btnDanielle.TabIndex = 3;
            this.btnDanielle.Text = "Danielle";
            this.btnDanielle.UseVisualStyleBackColor = true;
            this.btnDanielle.Click += new System.EventHandler(this.btnDanielle_Click);
            // 
            // btnEdward
            // 
            this.btnEdward.Location = new System.Drawing.Point(97, 136);
            this.btnEdward.Name = "btnEdward";
            this.btnEdward.Size = new System.Drawing.Size(75, 33);
            this.btnEdward.TabIndex = 4;
            this.btnEdward.Text = "Edward";
            this.btnEdward.UseVisualStyleBackColor = true;
            this.btnEdward.Click += new System.EventHandler(this.btnEdward_Click);
            // 
            // btnFrancis
            // 
            this.btnFrancis.Location = new System.Drawing.Point(178, 136);
            this.btnFrancis.Name = "btnFrancis";
            this.btnFrancis.Size = new System.Drawing.Size(75, 33);
            this.btnFrancis.TabIndex = 5;
            this.btnFrancis.Text = "Francis";
            this.btnFrancis.UseVisualStyleBackColor = true;
            this.btnFrancis.Click += new System.EventHandler(this.btnFrancis_Click);
            // 
            // lblDanielle
            // 
            this.lblDanielle.Location = new System.Drawing.Point(13, 196);
            this.lblDanielle.Name = "lblDanielle";
            this.lblDanielle.Size = new System.Drawing.Size(159, 22);
            this.lblDanielle.TabIndex = 6;
            this.lblDanielle.Text = "Danielle Sales: $0.00";
            // 
            // lblEdward
            // 
            this.lblEdward.Location = new System.Drawing.Point(13, 218);
            this.lblEdward.Name = "lblEdward";
            this.lblEdward.Size = new System.Drawing.Size(159, 22);
            this.lblEdward.TabIndex = 7;
            this.lblEdward.Text = "Edward Sales: $0.00";
            // 
            // lblFrancis
            // 
            this.lblFrancis.Location = new System.Drawing.Point(13, 240);
            this.lblFrancis.Name = "lblFrancis";
            this.lblFrancis.Size = new System.Drawing.Size(159, 22);
            this.lblFrancis.TabIndex = 8;
            this.lblFrancis.Text = "Francis Sales: $0.00";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Location = new System.Drawing.Point(12, 262);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(159, 22);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "Grand Total: $0.00";
            // 
            // lblTopSeller
            // 
            this.lblTopSeller.Location = new System.Drawing.Point(13, 322);
            this.lblTopSeller.Name = "lblTopSeller";
            this.lblTopSeller.Size = new System.Drawing.Size(159, 22);
            this.lblTopSeller.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.lblTopSeller);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblFrancis);
            this.Controls.Add(this.lblEdward);
            this.Controls.Add(this.lblDanielle);
            this.Controls.Add(this.btnFrancis);
            this.Controls.Add(this.btnEdward);
            this.Controls.Add(this.btnDanielle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaleAmount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaleAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDanielle;
        private System.Windows.Forms.Button btnEdward;
        private System.Windows.Forms.Button btnFrancis;
        private System.Windows.Forms.Label lblDanielle;
        private System.Windows.Forms.Label lblEdward;
        private System.Windows.Forms.Label lblFrancis;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTopSeller;
    }
}

