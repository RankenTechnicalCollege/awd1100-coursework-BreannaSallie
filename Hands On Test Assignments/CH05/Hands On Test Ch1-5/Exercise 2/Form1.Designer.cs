namespace Exercise_2
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
            this.lblNumGrade = new System.Windows.Forms.Label();
            this.txtNumGrade = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblGradeText = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumGrade
            // 
            this.lblNumGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGrade.Location = new System.Drawing.Point(30, 67);
            this.lblNumGrade.Name = "lblNumGrade";
            this.lblNumGrade.Size = new System.Drawing.Size(142, 23);
            this.lblNumGrade.TabIndex = 0;
            this.lblNumGrade.Text = "Numeric Grade";
            // 
            // txtNumGrade
            // 
            this.txtNumGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGrade.Location = new System.Drawing.Point(34, 106);
            this.txtNumGrade.Name = "txtNumGrade";
            this.txtNumGrade.Size = new System.Drawing.Size(263, 27);
            this.txtNumGrade.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(34, 157);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(263, 33);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Show Letter Grade";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblGradeText
            // 
            this.lblGradeText.AutoSize = true;
            this.lblGradeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeText.Location = new System.Drawing.Point(34, 224);
            this.lblGradeText.Name = "lblGradeText";
            this.lblGradeText.Size = new System.Drawing.Size(96, 20);
            this.lblGradeText.TabIndex = 3;
            this.lblGradeText.Text = "Your Grade:";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(136, 224);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(161, 23);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGradeText);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtNumGrade);
            this.Controls.Add(this.lblNumGrade);
            this.Name = "Form1";
            this.Text = "Letter Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumGrade;
        private System.Windows.Forms.TextBox txtNumGrade;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblGradeText;
        private System.Windows.Forms.Label lblResult;
    }
}

