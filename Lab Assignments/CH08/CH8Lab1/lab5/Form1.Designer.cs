namespace lab5
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
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.btnMask = new System.Windows.Forms.Button();
            this.lblMasked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCardNum
            // 
            this.txtCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNum.Location = new System.Drawing.Point(24, 80);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(408, 27);
            this.txtCardNum.TabIndex = 0;
            // 
            // btnMask
            // 
            this.btnMask.Location = new System.Drawing.Point(438, 83);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(75, 23);
            this.btnMask.TabIndex = 1;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMasked
            // 
            this.lblMasked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasked.Location = new System.Drawing.Point(24, 134);
            this.lblMasked.Name = "lblMasked";
            this.lblMasked.Size = new System.Drawing.Size(408, 23);
            this.lblMasked.TabIndex = 2;
            this.lblMasked.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 207);
            this.Controls.Add(this.lblMasked);
            this.Controls.Add(this.btnMask);
            this.Controls.Add(this.txtCardNum);
            this.Name = "Form1";
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Button btnMask;
        private System.Windows.Forms.Label lblMasked;
    }
}

