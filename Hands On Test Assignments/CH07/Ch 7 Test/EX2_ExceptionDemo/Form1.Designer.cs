namespace Ch7Test
{
    partial class ExceptionsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnArithmetic = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnInvalidCast = new System.Windows.Forms.Button();
            this.btnNullRef = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNullRef, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInvalidCast, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnArithmetic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFormat, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnArithmetic
            // 
            this.btnArithmetic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArithmetic.Location = new System.Drawing.Point(3, 3);
            this.btnArithmetic.Name = "btnArithmetic";
            this.btnArithmetic.Size = new System.Drawing.Size(177, 117);
            this.btnArithmetic.TabIndex = 1;
            this.btnArithmetic.Text = "System.ArithmeticException";
            this.btnArithmetic.UseVisualStyleBackColor = true;
            this.btnArithmetic.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFormat.Location = new System.Drawing.Point(186, 3);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(178, 117);
            this.btnFormat.TabIndex = 2;
            this.btnFormat.Text = "System.FormatException";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnInvalidCast
            // 
            this.btnInvalidCast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvalidCast.Location = new System.Drawing.Point(3, 126);
            this.btnInvalidCast.Name = "btnInvalidCast";
            this.btnInvalidCast.Size = new System.Drawing.Size(177, 117);
            this.btnInvalidCast.TabIndex = 3;
            this.btnInvalidCast.Text = "System.InvalidCastException";
            this.btnInvalidCast.UseVisualStyleBackColor = true;
            this.btnInvalidCast.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnNullRef
            // 
            this.btnNullRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNullRef.Location = new System.Drawing.Point(186, 126);
            this.btnNullRef.Name = "btnNullRef";
            this.btnNullRef.Size = new System.Drawing.Size(178, 117);
            this.btnNullRef.TabIndex = 3;
            this.btnNullRef.Text = "System.NullReferenceException";
            this.btnNullRef.UseVisualStyleBackColor = true;
            this.btnNullRef.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // ExceptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExceptionsForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNullRef;
        private System.Windows.Forms.Button btnInvalidCast;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnArithmetic;
    }
}

