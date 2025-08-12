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
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSorted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPhrase
            // 
            this.txtPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhrase.Location = new System.Drawing.Point(46, 50);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(420, 24);
            this.txtPhrase.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(46, 97);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(43, 226);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(256, 23);
            this.lblStatus.TabIndex = 2;
            // 
            // txtSorted
            // 
            this.txtSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorted.Location = new System.Drawing.Point(46, 143);
            this.txtSorted.Multiline = true;
            this.txtSorted.Name = "txtSorted";
            this.txtSorted.ReadOnly = true;
            this.txtSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSorted.Size = new System.Drawing.Size(420, 80);
            this.txtSorted.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.txtSorted);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtPhrase);
            this.Name = "Form1";
            this.Text = "Sorted Phrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSorted;
    }
}

