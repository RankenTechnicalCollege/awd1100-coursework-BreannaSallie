namespace lab2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.lblNightlyText = new System.Windows.Forms.Label();
            this.lblNightlyCost = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(234, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(79, 128);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(149, 40);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Nights Stayed";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNights
            // 
            this.txtNights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(84, 171);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(144, 35);
            this.txtNights.TabIndex = 2;
            // 
            // lblNightlyText
            // 
            this.lblNightlyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightlyText.Location = new System.Drawing.Point(378, 128);
            this.lblNightlyText.Name = "lblNightlyText";
            this.lblNightlyText.Size = new System.Drawing.Size(149, 40);
            this.lblNightlyText.TabIndex = 3;
            this.lblNightlyText.Text = "Nightly Cost";
            this.lblNightlyText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNightlyCost
            // 
            this.lblNightlyCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNightlyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNightlyCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightlyCost.Location = new System.Drawing.Point(378, 168);
            this.lblNightlyCost.Name = "lblNightlyCost";
            this.lblNightlyCost.Size = new System.Drawing.Size(149, 40);
            this.lblNightlyCost.TabIndex = 4;
            this.lblNightlyCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalText
            // 
            this.lblTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Location = new System.Drawing.Point(564, 128);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(162, 40);
            this.lblTotalText.TabIndex = 5;
            this.lblTotalText.Text = "Total cost of stay";
            this.lblTotalText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(569, 168);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(149, 40);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblNightlyCost);
            this.Controls.Add(this.lblNightlyText);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label lblNightlyText;
        private System.Windows.Forms.Label lblNightlyCost;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

