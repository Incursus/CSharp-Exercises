namespace AndOr
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
            this.recommendButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.warrantyCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // recommendButton
            // 
            this.recommendButton.Location = new System.Drawing.Point(98, 43);
            this.recommendButton.Name = "recommendButton";
            this.recommendButton.Size = new System.Drawing.Size(75, 23);
            this.recommendButton.TabIndex = 0;
            this.recommendButton.Text = "Recommend";
            this.recommendButton.UseVisualStyleBackColor = true;
            this.recommendButton.Click += new System.EventHandler(this.recommendButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(8, 17);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(165, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // warrantyCheckBox
            // 
            this.warrantyCheckBox.AutoSize = true;
            this.warrantyCheckBox.Location = new System.Drawing.Point(12, 47);
            this.warrantyCheckBox.Name = "warrantyCheckBox";
            this.warrantyCheckBox.Size = new System.Drawing.Size(69, 17);
            this.warrantyCheckBox.TabIndex = 2;
            this.warrantyCheckBox.Text = "Warranty";
            this.warrantyCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 259);
            this.Controls.Add(this.warrantyCheckBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.recommendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recommendButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox warrantyCheckBox;
    }
}

