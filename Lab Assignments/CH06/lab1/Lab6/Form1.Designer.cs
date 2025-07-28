namespace Lab6
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtWood = new System.Windows.Forms.TextBox();
            this.txtDrawers = new System.Windows.Forms.TextBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.lblCostofwood = new System.Windows.Forms.Label();
            this.lblTypeofwood = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblWoodCost = new System.Windows.Forms.Label();
            this.lblDrawerCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Wood";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Drawers";
            // 
            // txtWood
            // 
            this.txtWood.Location = new System.Drawing.Point(55, 96);
            this.txtWood.Name = "txtWood";
            this.txtWood.Size = new System.Drawing.Size(136, 20);
            this.txtWood.TabIndex = 2;
            // 
            // txtDrawers
            // 
            this.txtDrawers.Location = new System.Drawing.Point(317, 96);
            this.txtDrawers.Name = "txtDrawers";
            this.txtDrawers.Size = new System.Drawing.Size(136, 20);
            this.txtDrawers.TabIndex = 3;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(55, 150);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(75, 23);
            this.btnEstimate.TabIndex = 4;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // lblCostofwood
            // 
            this.lblCostofwood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostofwood.Location = new System.Drawing.Point(52, 253);
            this.lblCostofwood.Name = "lblCostofwood";
            this.lblCostofwood.Size = new System.Drawing.Size(125, 23);
            this.lblCostofwood.TabIndex = 5;
            this.lblCostofwood.Text = "Cost of Wood";
            // 
            // lblTypeofwood
            // 
            this.lblTypeofwood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeofwood.Location = new System.Drawing.Point(275, 253);
            this.lblTypeofwood.Name = "lblTypeofwood";
            this.lblTypeofwood.Size = new System.Drawing.Size(125, 23);
            this.lblTypeofwood.TabIndex = 6;
            this.lblTypeofwood.Text = "Cost of Drawers";
            
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(519, 253);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 23);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Cost";
            // 
            // lblWoodCost
            // 
            this.lblWoodCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWoodCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoodCost.Location = new System.Drawing.Point(55, 294);
            this.lblWoodCost.Name = "lblWoodCost";
            this.lblWoodCost.Size = new System.Drawing.Size(125, 23);
            this.lblWoodCost.TabIndex = 8;
            // 
            // lblDrawerCost
            // 
            this.lblDrawerCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDrawerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawerCost.Location = new System.Drawing.Point(278, 294);
            this.lblDrawerCost.Name = "lblDrawerCost";
            this.lblDrawerCost.Size = new System.Drawing.Size(125, 23);
            this.lblDrawerCost.TabIndex = 9;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(522, 294);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(125, 23);
            this.lblTotalCost.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblDrawerCost);
            this.Controls.Add(this.lblWoodCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTypeofwood);
            this.Controls.Add(this.lblCostofwood);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.txtDrawers);
            this.Controls.Add(this.txtWood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Custom Desk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWood;
        private System.Windows.Forms.TextBox txtDrawers;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Label lblCostofwood;
        private System.Windows.Forms.Label lblTypeofwood;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblWoodCost;
        private System.Windows.Forms.Label lblDrawerCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

