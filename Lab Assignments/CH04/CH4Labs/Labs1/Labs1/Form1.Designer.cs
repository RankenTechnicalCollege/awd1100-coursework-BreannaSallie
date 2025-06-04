namespace Labs1
{
    partial class Convert
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDistanceMiles = new Label();
            txtMiles = new TextBox();
            lblDistanceKilo = new Label();
            txtKilo = new TextBox();
            btntokm = new Button();
            btntomiles = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblDistanceMiles
            // 
            lblDistanceMiles.Location = new Point(114, 76);
            lblDistanceMiles.Name = "lblDistanceMiles";
            lblDistanceMiles.Size = new Size(150, 20);
            lblDistanceMiles.TabIndex = 0;
            lblDistanceMiles.Text = "Distance in miles";
            lblDistanceMiles.Click += label1_Click;
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(114, 113);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(150, 23);
            txtMiles.TabIndex = 1;
            // 
            // lblDistanceKilo
            // 
            lblDistanceKilo.Location = new Point(364, 76);
            lblDistanceKilo.Name = "lblDistanceKilo";
            lblDistanceKilo.Size = new Size(150, 20);
            lblDistanceKilo.TabIndex = 2;
            lblDistanceKilo.Text = "Distance in kilometers";
            lblDistanceKilo.Click += lblDistanceKilo_Click;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(364, 113);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(150, 23);
            txtKilo.TabIndex = 3;
            // 
            // btntokm
            // 
            btntokm.Location = new Point(114, 158);
            btntokm.Name = "btntokm";
            btntokm.Size = new Size(150, 23);
            btntokm.TabIndex = 4;
            btntokm.Text = "convert to km";
            btntokm.UseVisualStyleBackColor = true;
            btntokm.Click += btntokm_Click;
            // 
            // btntomiles
            // 
            btntomiles.Location = new Point(364, 158);
            btntomiles.Name = "btntomiles";
            btntomiles.Size = new Size(150, 23);
            btntomiles.TabIndex = 5;
            btntomiles.Text = "convert to miles";
            btntomiles.UseVisualStyleBackColor = true;
            btntomiles.Click += btntomiles_Click;
            // 
            // lblResult
            // 
            lblResult.ForeColor = SystemColors.ButtonShadow;
            lblResult.Location = new Point(114, 214);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(226, 23);
            lblResult.TabIndex = 6;
            // 
            // Convert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 302);
            Controls.Add(lblResult);
            Controls.Add(btntomiles);
            Controls.Add(btntokm);
            Controls.Add(txtKilo);
            Controls.Add(lblDistanceKilo);
            Controls.Add(txtMiles);
            Controls.Add(lblDistanceMiles);
            Name = "Convert";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistanceMiles;
        private TextBox txtMiles;
        private Label lblDistanceKilo;
        private TextBox txtKilo;
        private Button btntokm;
        private Button btntomiles;
        private Label lblResult;
    }
}
