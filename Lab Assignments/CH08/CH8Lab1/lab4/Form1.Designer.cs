namespace lab4
{
    partial class MovieDatabase
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNameText = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDirectorText = new System.Windows.Forms.Button();
            this.lblDescText = new System.Windows.Forms.Button();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(43, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(526, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(575, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNameText
            // 
            this.lblNameText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.Location = new System.Drawing.Point(43, 171);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(109, 35);
            this.lblNameText.TabIndex = 7;
            this.lblNameText.Text = "Name:";
            this.lblNameText.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(203, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(344, 29);
            this.lblName.TabIndex = 8;
            // 
            // lblDirectorText
            // 
            this.lblDirectorText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDirectorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorText.Location = new System.Drawing.Point(43, 212);
            this.lblDirectorText.Name = "lblDirectorText";
            this.lblDirectorText.Size = new System.Drawing.Size(109, 35);
            this.lblDirectorText.TabIndex = 9;
            this.lblDirectorText.Text = "Director:";
            this.lblDirectorText.UseVisualStyleBackColor = false;
            // 
            // lblDescText
            // 
            this.lblDescText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescText.Location = new System.Drawing.Point(43, 253);
            this.lblDescText.Name = "lblDescText";
            this.lblDescText.Size = new System.Drawing.Size(109, 35);
            this.lblDescText.TabIndex = 10;
            this.lblDescText.Text = "Descritption: ";
            this.lblDescText.UseVisualStyleBackColor = false;
            // 
            // lblDirector
            // 
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(203, 212);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(344, 29);
            this.lblDirector.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(203, 253);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(344, 91);
            this.lblDescription.TabIndex = 12;
            // 
            // MovieDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblDescText);
            this.Controls.Add(this.lblDirectorText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "MovieDatabase";
            this.Text = "MovieDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button lblNameText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button lblDirectorText;
        private System.Windows.Forms.Button lblDescText;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDescription;
    }
}

