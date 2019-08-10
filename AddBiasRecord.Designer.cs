namespace StockGamePrototype1
{
    partial class AddBiasRecord
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
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.highTargetTextBox = new System.Windows.Forms.TextBox();
            this.lowTargetTextBox = new System.Windows.Forms.TextBox();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.highTargetLabel = new System.Windows.Forms.Label();
            this.lowTargetLabel = new System.Windows.Forms.Label();
            this.addBiasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(130, 45);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(100, 22);
            this.symbolTextBox.TabIndex = 0;
            // 
            // highTargetTextBox
            // 
            this.highTargetTextBox.Location = new System.Drawing.Point(130, 85);
            this.highTargetTextBox.Name = "highTargetTextBox";
            this.highTargetTextBox.Size = new System.Drawing.Size(100, 22);
            this.highTargetTextBox.TabIndex = 1;
            this.highTargetTextBox.TextChanged += new System.EventHandler(this.lowTargetTextBox_TextChanged);
            // 
            // lowTargetTextBox
            // 
            this.lowTargetTextBox.Location = new System.Drawing.Point(130, 128);
            this.lowTargetTextBox.Name = "lowTargetTextBox";
            this.lowTargetTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowTargetTextBox.TabIndex = 2;
            this.lowTargetTextBox.TextChanged += new System.EventHandler(this.highTargetTextBox_TextChanged);
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Location = new System.Drawing.Point(32, 45);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(54, 17);
            this.symbolLabel.TabIndex = 3;
            this.symbolLabel.Text = "Symbol";
            // 
            // highTargetLabel
            // 
            this.highTargetLabel.AutoSize = true;
            this.highTargetLabel.Location = new System.Drawing.Point(32, 90);
            this.highTargetLabel.Name = "highTargetLabel";
            this.highTargetLabel.Size = new System.Drawing.Size(83, 17);
            this.highTargetLabel.TabIndex = 4;
            this.highTargetLabel.Text = "High Target";
            // 
            // lowTargetLabel
            // 
            this.lowTargetLabel.AutoSize = true;
            this.lowTargetLabel.Location = new System.Drawing.Point(32, 133);
            this.lowTargetLabel.Name = "lowTargetLabel";
            this.lowTargetLabel.Size = new System.Drawing.Size(79, 17);
            this.lowTargetLabel.TabIndex = 5;
            this.lowTargetLabel.Text = "Low Target";
            // 
            // addBiasButton
            // 
            this.addBiasButton.Location = new System.Drawing.Point(83, 188);
            this.addBiasButton.Name = "addBiasButton";
            this.addBiasButton.Size = new System.Drawing.Size(103, 53);
            this.addBiasButton.TabIndex = 6;
            this.addBiasButton.Text = "Add Bias";
            this.addBiasButton.UseVisualStyleBackColor = true;
            this.addBiasButton.Click += new System.EventHandler(this.addBiasButton_Click);
            // 
            // AddBiasRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.addBiasButton);
            this.Controls.Add(this.lowTargetLabel);
            this.Controls.Add(this.highTargetLabel);
            this.Controls.Add(this.symbolLabel);
            this.Controls.Add(this.lowTargetTextBox);
            this.Controls.Add(this.highTargetTextBox);
            this.Controls.Add(this.symbolTextBox);
            this.Name = "AddBiasRecord";
            this.Text = "AddBiasRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.TextBox highTargetTextBox;
        private System.Windows.Forms.TextBox lowTargetTextBox;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.Label highTargetLabel;
        private System.Windows.Forms.Label lowTargetLabel;
        private System.Windows.Forms.Button addBiasButton;
    }
}