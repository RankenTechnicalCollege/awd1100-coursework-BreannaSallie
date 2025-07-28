namespace Lab3
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
            this.lblPhrase = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblVowCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhrase
            // 
            this.lblPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.Location = new System.Drawing.Point(30, 56);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(186, 23);
            this.lblPhrase.TabIndex = 0;
            this.lblPhrase.Text = "Please enter a phrase";
            // 
            // txtPhrase
            // 
            this.txtPhrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhrase.Location = new System.Drawing.Point(33, 82);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(317, 24);
            this.txtPhrase.TabIndex = 1;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(370, 83);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Enter";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblVowCount
            // 
            this.lblVowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVowCount.Location = new System.Drawing.Point(30, 136);
            this.lblVowCount.Name = "lblVowCount";
            this.lblVowCount.Size = new System.Drawing.Size(320, 23);
            this.lblVowCount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.lblVowCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblPhrase);
            this.Name = "Form1";
            this.Text = "Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblVowCount;
    }
}

