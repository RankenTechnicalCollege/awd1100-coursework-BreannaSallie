namespace Lab_4
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
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.lblEncodeError = new System.Windows.Forms.Label();
            this.lblDecodeError = new System.Windows.Forms.Label();
            this.lblShiftError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(31, 55);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(334, 20);
            this.txtEncode.TabIndex = 0;
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(31, 109);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(334, 20);
            this.txtDecode.TabIndex = 1;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(391, 52);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(391, 109);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shift";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(532, 73);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(58, 20);
            this.txtShift.TabIndex = 5;
            // 
            // lblEncodeError
            // 
            this.lblEncodeError.ForeColor = System.Drawing.Color.Red;
            this.lblEncodeError.Location = new System.Drawing.Point(28, 76);
            this.lblEncodeError.Name = "lblEncodeError";
            this.lblEncodeError.Size = new System.Drawing.Size(268, 13);
            this.lblEncodeError.TabIndex = 6;
            // 
            // lblDecodeError
            // 
            this.lblDecodeError.ForeColor = System.Drawing.Color.Red;
            this.lblDecodeError.Location = new System.Drawing.Point(28, 132);
            this.lblDecodeError.Name = "lblDecodeError";
            this.lblDecodeError.Size = new System.Drawing.Size(268, 13);
            this.lblDecodeError.TabIndex = 7;
            // 
            // lblShiftError
            // 
            this.lblShiftError.ForeColor = System.Drawing.Color.Red;
            this.lblShiftError.Location = new System.Drawing.Point(529, 96);
            this.lblShiftError.Name = "lblShiftError";
            this.lblShiftError.Size = new System.Drawing.Size(75, 13);
            this.lblShiftError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShiftError);
            this.Controls.Add(this.lblDecodeError);
            this.Controls.Add(this.lblEncodeError);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.txtEncode);
            this.Name = "Form1";
            this.Text = "Decoder Ring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label lblEncodeError;
        private System.Windows.Forms.Label lblDecodeError;
        private System.Windows.Forms.Label lblShiftError;
    }
}

