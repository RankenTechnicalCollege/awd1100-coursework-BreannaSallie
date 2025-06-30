namespace Hands_On_Test_Ch1_5
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
            this.txtDistanceInInches = new System.Windows.Forms.Label();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDistanceInInches
            // 
            this.txtDistanceInInches.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceInInches.Location = new System.Drawing.Point(32, 36);
            this.txtDistanceInInches.Name = "txtDistanceInInches";
            this.txtDistanceInInches.Size = new System.Drawing.Size(156, 23);
            this.txtDistanceInInches.TabIndex = 0;
            this.txtDistanceInInches.Text = "Distance in inches";
            // 
            // txtInches
            // 
            this.txtInches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInches.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInches.Location = new System.Drawing.Point(36, 78);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(152, 27);
            this.txtInches.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(36, 120);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(154, 32);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to cm";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(36, 170);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(214, 26);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.txtDistanceInInches);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDistanceInInches;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
    }
}

