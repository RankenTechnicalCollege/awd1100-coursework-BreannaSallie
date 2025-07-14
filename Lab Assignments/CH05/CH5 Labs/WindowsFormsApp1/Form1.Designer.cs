namespace WindowsFormsApp1
{
    partial class Vowels
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.btnCountVowels = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(12, 53);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(231, 30);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Please enter a phrase";
            this.lblPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhrase
            // 
            this.txtPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhrase.Location = new System.Drawing.Point(12, 86);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(362, 29);
            this.txtPhrase.TabIndex = 1;
            // 
            // btnCountVowels
            // 
            this.btnCountVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountVowels.Location = new System.Drawing.Point(393, 84);
            this.btnCountVowels.Name = "btnCountVowels";
            this.btnCountVowels.Size = new System.Drawing.Size(77, 31);
            this.btnCountVowels.TabIndex = 2;
            this.btnCountVowels.Text = "enter";
            this.btnCountVowels.UseVisualStyleBackColor = true;
            this.btnCountVowels.Click += new System.EventHandler(this.btnCountVowels_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(17, 157);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(453, 30);
            this.lblResult.TabIndex = 3;
            // 
            // Vowels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 272);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCountVowels);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblPrompt);
            this.Name = "Vowels";
            this.Text = "Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.Button btnCountVowels;
        private System.Windows.Forms.Label lblResult;
    }
}

