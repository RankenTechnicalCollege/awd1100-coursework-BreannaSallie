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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblPlayerScoreText = new System.Windows.Forms.Label();
            this.lblComputerScoreText = new System.Windows.Forms.Label();
            this.lblFinalResult = new System.Windows.Forms.Label();
            this.lblPlayerScoreResult = new System.Windows.Forms.Label();
            this.lblComputerScoreResult = new System.Windows.Forms.Label();
            this.lblPlayerChoiceResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(79, 134);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(104, 38);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(365, 134);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(100, 38);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(624, 134);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnScissors.Size = new System.Drawing.Size(100, 38);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.BackColor = System.Drawing.SystemColors.Control;
            this.lblComputerChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerChoice.Location = new System.Drawing.Point(76, 208);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(266, 23);
            this.lblComputerChoice.TabIndex = 3;
            // 
            // lblPlayerScoreText
            // 
            this.lblPlayerScoreText.AutoSize = true;
            this.lblPlayerScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScoreText.Location = new System.Drawing.Point(72, 262);
            this.lblPlayerScoreText.Name = "lblPlayerScoreText";
            this.lblPlayerScoreText.Size = new System.Drawing.Size(102, 20);
            this.lblPlayerScoreText.TabIndex = 4;
            this.lblPlayerScoreText.Text = "Player Score:";
            // 
            // lblComputerScoreText
            // 
            this.lblComputerScoreText.AutoSize = true;
            this.lblComputerScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScoreText.Location = new System.Drawing.Point(361, 262);
            this.lblComputerScoreText.Name = "lblComputerScoreText";
            this.lblComputerScoreText.Size = new System.Drawing.Size(129, 20);
            this.lblComputerScoreText.TabIndex = 5;
            this.lblComputerScoreText.Text = "Computer Score:";
            // 
            // lblFinalResult
            // 
            this.lblFinalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalResult.Location = new System.Drawing.Point(73, 326);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(269, 23);
            this.lblFinalResult.TabIndex = 6;
            // 
            // lblPlayerScoreResult
            // 
            this.lblPlayerScoreResult.AutoSize = true;
            this.lblPlayerScoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScoreResult.Location = new System.Drawing.Point(180, 267);
            this.lblPlayerScoreResult.Name = "lblPlayerScoreResult";
            this.lblPlayerScoreResult.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerScoreResult.TabIndex = 7;
            // 
            // lblComputerScoreResult
            // 
            this.lblComputerScoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScoreResult.Location = new System.Drawing.Point(510, 259);
            this.lblComputerScoreResult.Name = "lblComputerScoreResult";
            this.lblComputerScoreResult.Size = new System.Drawing.Size(100, 23);
            this.lblComputerScoreResult.TabIndex = 8;
            // 
            // lblPlayerChoiceResults
            // 
            this.lblPlayerChoiceResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoiceResults.Location = new System.Drawing.Point(186, 262);
            this.lblPlayerChoiceResults.Name = "lblPlayerChoiceResults";
            this.lblPlayerChoiceResults.Size = new System.Drawing.Size(100, 26);
            this.lblPlayerChoiceResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayerChoiceResults);
            this.Controls.Add(this.lblComputerScoreResult);
            this.Controls.Add(this.lblPlayerScoreResult);
            this.Controls.Add(this.lblFinalResult);
            this.Controls.Add(this.lblComputerScoreText);
            this.Controls.Add(this.lblPlayerScoreText);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblPlayerScoreText;
        private System.Windows.Forms.Label lblComputerScoreText;
        private System.Windows.Forms.Label lblFinalResult;
        private System.Windows.Forms.Label lblPlayerScoreResult;
        private System.Windows.Forms.Label lblComputerScoreResult;
        private System.Windows.Forms.TextBox lblPlayerChoiceResults;
    }
}

