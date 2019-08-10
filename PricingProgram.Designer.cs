namespace StockGamePrototype1
{
    partial class PricingProgram
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
            this.pricingProgramButton = new System.Windows.Forms.Button();
            this.newPriceListBox = new System.Windows.Forms.ListBox();
            this.newPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pricingProgramButton
            // 
            this.pricingProgramButton.Location = new System.Drawing.Point(80, 58);
            this.pricingProgramButton.Name = "pricingProgramButton";
            this.pricingProgramButton.Size = new System.Drawing.Size(106, 69);
            this.pricingProgramButton.TabIndex = 0;
            this.pricingProgramButton.Text = "Pricing Program";
            this.pricingProgramButton.UseVisualStyleBackColor = true;
            this.pricingProgramButton.Click += new System.EventHandler(this.pricingProgramButton_Click);
            // 
            // newPriceListBox
            // 
            this.newPriceListBox.FormattingEnabled = true;
            this.newPriceListBox.ItemHeight = 16;
            this.newPriceListBox.Location = new System.Drawing.Point(273, 32);
            this.newPriceListBox.Name = "newPriceListBox";
            this.newPriceListBox.Size = new System.Drawing.Size(704, 532);
            this.newPriceListBox.TabIndex = 1;
            // 
            // newPriceLabel
            // 
            this.newPriceLabel.AutoSize = true;
            this.newPriceLabel.Location = new System.Drawing.Point(294, 9);
            this.newPriceLabel.Name = "newPriceLabel";
            this.newPriceLabel.Size = new System.Drawing.Size(273, 17);
            this.newPriceLabel.TabIndex = 2;
            this.newPriceLabel.Text = "Price - High - Low - New Price - Gain/Loss\r\n";
            // 
            // PricingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 579);
            this.Controls.Add(this.newPriceLabel);
            this.Controls.Add(this.newPriceListBox);
            this.Controls.Add(this.pricingProgramButton);
            this.Name = "PricingProgram";
            this.Text = "PricingProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pricingProgramButton;
        private System.Windows.Forms.ListBox newPriceListBox;
        private System.Windows.Forms.Label newPriceLabel;
    }
}