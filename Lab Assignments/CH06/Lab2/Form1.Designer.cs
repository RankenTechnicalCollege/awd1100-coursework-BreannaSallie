namespace Lab2
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
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblTestScore = new System.Windows.Forms.Label();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtTestScore = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGPA
            // 
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(41, 54);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(205, 39);
            this.lblGPA.TabIndex = 2;
            this.lblGPA.Text = "GPA";
            // 
            // lblTestScore
            // 
            this.lblTestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestScore.Location = new System.Drawing.Point(431, 54);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(228, 39);
            this.lblTestScore.TabIndex = 3;
            this.lblTestScore.Text = "Admission Test Score";
            // 
            // btnAdmit
            // 
            this.btnAdmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmit.Location = new System.Drawing.Point(41, 199);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(105, 28);
            this.btnAdmit.TabIndex = 4;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // txtGPA
            // 
            this.txtGPA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(41, 98);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(205, 26);
            this.txtGPA.TabIndex = 6;
            // 
            // txtTestScore
            // 
            this.txtTestScore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTestScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestScore.Location = new System.Drawing.Point(435, 98);
            this.txtTestScore.Name = "txtTestScore";
            this.txtTestScore.Size = new System.Drawing.Size(218, 26);
            this.txtTestScore.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(173, 199);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 28);
            this.lblResult.TabIndex = 8;
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(185, 204);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(112, 23);
            this.lblResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtTestScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.lblTestScore);
            this.Controls.Add(this.lblGPA);
            this.Name = "Form1";
            this.Text = "College Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblTestScore;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtTestScore;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResults;
    }
}

