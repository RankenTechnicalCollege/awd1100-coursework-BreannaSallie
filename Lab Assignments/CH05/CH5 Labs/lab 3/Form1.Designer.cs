namespace lab_3
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
            this.btnDanielle = new System.Windows.Forms.Button();
            this.lblPromptAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPromptWho = new System.Windows.Forms.Label();
            this.btnEdward = new System.Windows.Forms.Button();
            this.btnFrancis = new System.Windows.Forms.Button();
            this.lblDanielle = new System.Windows.Forms.Label();
            this.lblEdward = new System.Windows.Forms.Label();
            this.lblFrancis = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTopSales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDanielle
            // 
            this.btnDanielle.Location = new System.Drawing.Point(15, 135);
            this.btnDanielle.Margin = new System.Windows.Forms.Padding(6);
            this.btnDanielle.Name = "btnDanielle";
            this.btnDanielle.Size = new System.Drawing.Size(107, 34);
            this.btnDanielle.TabIndex = 0;
            this.btnDanielle.Text = "Danielle";
            this.btnDanielle.UseVisualStyleBackColor = true;
            this.btnDanielle.Click += new System.EventHandler(this.btnDanielle_Click);
            // 
            // lblPromptAmount
            // 
            this.lblPromptAmount.AutoSize = true;
            this.lblPromptAmount.Location = new System.Drawing.Point(15, 26);
            this.lblPromptAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPromptAmount.Name = "lblPromptAmount";
            this.lblPromptAmount.Size = new System.Drawing.Size(231, 25);
            this.lblPromptAmount.TabIndex = 1;
            this.lblPromptAmount.Text = "How much was this sale?";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(20, 57);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(226, 30);
            this.txtAmount.TabIndex = 2;
            // 
            // lblPromptWho
            // 
            this.lblPromptWho.AutoSize = true;
            this.lblPromptWho.Location = new System.Drawing.Point(17, 104);
            this.lblPromptWho.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPromptWho.Name = "lblPromptWho";
            this.lblPromptWho.Size = new System.Drawing.Size(192, 25);
            this.lblPromptWho.TabIndex = 3;
            this.lblPromptWho.Text = "Who made the sale?";
            // 
            // btnEdward
            // 
            this.btnEdward.Location = new System.Drawing.Point(134, 135);
            this.btnEdward.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdward.Name = "btnEdward";
            this.btnEdward.Size = new System.Drawing.Size(107, 34);
            this.btnEdward.TabIndex = 4;
            this.btnEdward.Text = "Edward";
            this.btnEdward.UseVisualStyleBackColor = true;
            this.btnEdward.Click += new System.EventHandler(this.btnEdward_Click);
            // 
            // btnFrancis
            // 
            this.btnFrancis.Location = new System.Drawing.Point(253, 135);
            this.btnFrancis.Margin = new System.Windows.Forms.Padding(6);
            this.btnFrancis.Name = "btnFrancis";
            this.btnFrancis.Size = new System.Drawing.Size(107, 34);
            this.btnFrancis.TabIndex = 5;
            this.btnFrancis.Text = "Francis";
            this.btnFrancis.UseVisualStyleBackColor = true;
            this.btnFrancis.Click += new System.EventHandler(this.btnFrancis_Click);
            // 
            // lblDanielle
            // 
            this.lblDanielle.AutoSize = true;
            this.lblDanielle.Location = new System.Drawing.Point(10, 227);
            this.lblDanielle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDanielle.Name = "lblDanielle";
            this.lblDanielle.Size = new System.Drawing.Size(143, 25);
            this.lblDanielle.TabIndex = 6;
            this.lblDanielle.Text = "Danielle Sales:";
            // 
            // lblEdward
            // 
            this.lblEdward.AutoSize = true;
            this.lblEdward.Location = new System.Drawing.Point(10, 261);
            this.lblEdward.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEdward.Name = "lblEdward";
            this.lblEdward.Size = new System.Drawing.Size(139, 25);
            this.lblEdward.TabIndex = 7;
            this.lblEdward.Text = "Edward Sales:";
            // 
            // lblFrancis
            // 
            this.lblFrancis.AutoSize = true;
            this.lblFrancis.Location = new System.Drawing.Point(10, 295);
            this.lblFrancis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrancis.Name = "lblFrancis";
            this.lblFrancis.Size = new System.Drawing.Size(137, 25);
            this.lblFrancis.TabIndex = 8;
            this.lblFrancis.Text = "Francis Sales:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(10, 329);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(121, 25);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // lblTopSales
            // 
            this.lblTopSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopSales.Location = new System.Drawing.Point(15, 381);
            this.lblTopSales.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTopSales.Name = "lblTopSales";
            this.lblTopSales.Size = new System.Drawing.Size(334, 25);
            this.lblTopSales.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 749);
            this.Controls.Add(this.lblTopSales);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblFrancis);
            this.Controls.Add(this.lblEdward);
            this.Controls.Add(this.lblDanielle);
            this.Controls.Add(this.btnFrancis);
            this.Controls.Add(this.btnEdward);
            this.Controls.Add(this.lblPromptWho);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblPromptAmount);
            this.Controls.Add(this.btnDanielle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Lab 3/4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDanielle;
        private System.Windows.Forms.Label lblPromptAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPromptWho;
        private System.Windows.Forms.Button btnEdward;
        private System.Windows.Forms.Button btnFrancis;
        private System.Windows.Forms.Label lblDanielle;
        private System.Windows.Forms.Label lblEdward;
        private System.Windows.Forms.Label lblFrancis;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTopSales;
    }
}

