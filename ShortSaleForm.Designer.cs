namespace StockGamePrototype1
{
    partial class ShortSaleForm
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
            this.sharesTextBox = new System.Windows.Forms.TextBox();
            this.symbolHeading = new System.Windows.Forms.Label();
            this.sharesHeading = new System.Windows.Forms.Label();
            this.shortSaleListBox = new System.Windows.Forms.ListBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.shortSaleButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.closedShortSalesButton = new System.Windows.Forms.Button();
            this.limitOrderButton = new System.Windows.Forms.Button();
            this.lowPriceLabel = new System.Windows.Forms.Label();
            this.highPriceLabel = new System.Windows.Forms.Label();
            this.lowPriceTextBox = new System.Windows.Forms.TextBox();
            this.highPriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(160, 79);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(100, 22);
            this.symbolTextBox.TabIndex = 0;
            // 
            // sharesTextBox
            // 
            this.sharesTextBox.Location = new System.Drawing.Point(160, 136);
            this.sharesTextBox.Name = "sharesTextBox";
            this.sharesTextBox.Size = new System.Drawing.Size(100, 22);
            this.sharesTextBox.TabIndex = 1;
            // 
            // symbolHeading
            // 
            this.symbolHeading.AutoSize = true;
            this.symbolHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolHeading.Location = new System.Drawing.Point(69, 84);
            this.symbolHeading.Name = "symbolHeading";
            this.symbolHeading.Size = new System.Drawing.Size(60, 17);
            this.symbolHeading.TabIndex = 2;
            this.symbolHeading.Text = "Symbol";
            // 
            // sharesHeading
            // 
            this.sharesHeading.AutoSize = true;
            this.sharesHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharesHeading.Location = new System.Drawing.Point(69, 141);
            this.sharesHeading.Name = "sharesHeading";
            this.sharesHeading.Size = new System.Drawing.Size(59, 17);
            this.sharesHeading.TabIndex = 3;
            this.sharesHeading.Text = "Shares";
            // 
            // shortSaleListBox
            // 
            this.shortSaleListBox.FormattingEnabled = true;
            this.shortSaleListBox.ItemHeight = 16;
            this.shortSaleListBox.Location = new System.Drawing.Point(385, 79);
            this.shortSaleListBox.Name = "shortSaleListBox";
            this.shortSaleListBox.Size = new System.Drawing.Size(429, 324);
            this.shortSaleListBox.TabIndex = 4;
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(72, 215);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(75, 78);
            this.priceButton.TabIndex = 5;
            this.priceButton.Text = "Check Price";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // shortSaleButton
            // 
            this.shortSaleButton.Location = new System.Drawing.Point(185, 215);
            this.shortSaleButton.Name = "shortSaleButton";
            this.shortSaleButton.Size = new System.Drawing.Size(75, 78);
            this.shortSaleButton.TabIndex = 6;
            this.shortSaleButton.Text = "Add Short Sale";
            this.shortSaleButton.UseVisualStyleBackColor = true;
            this.shortSaleButton.Click += new System.EventHandler(this.shortSaleButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(185, 347);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 56);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "EXIT";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // closedShortSalesButton
            // 
            this.closedShortSalesButton.Location = new System.Drawing.Point(72, 323);
            this.closedShortSalesButton.Name = "closedShortSalesButton";
            this.closedShortSalesButton.Size = new System.Drawing.Size(75, 80);
            this.closedShortSalesButton.TabIndex = 8;
            this.closedShortSalesButton.Text = "Closed Short Sales";
            this.closedShortSalesButton.UseVisualStyleBackColor = true;
            this.closedShortSalesButton.Click += new System.EventHandler(this.closedShortSalesButton_Click);
            // 
            // limitOrderButton
            // 
            this.limitOrderButton.Location = new System.Drawing.Point(72, 432);
            this.limitOrderButton.Name = "limitOrderButton";
            this.limitOrderButton.Size = new System.Drawing.Size(108, 78);
            this.limitOrderButton.TabIndex = 9;
            this.limitOrderButton.Text = "SHORT SALE LIMIT ORDER";
            this.limitOrderButton.UseVisualStyleBackColor = true;
            this.limitOrderButton.Visible = false;
            this.limitOrderButton.Click += new System.EventHandler(this.limitOrderButton_Click);
            // 
            // lowPriceLabel
            // 
            this.lowPriceLabel.AutoSize = true;
            this.lowPriceLabel.Location = new System.Drawing.Point(249, 432);
            this.lowPriceLabel.Name = "lowPriceLabel";
            this.lowPriceLabel.Size = new System.Drawing.Size(177, 17);
            this.lowPriceLabel.TabIndex = 10;
            this.lowPriceLabel.Text = "Enter acceptablel low price";
            this.lowPriceLabel.Visible = false;
            // 
            // highPriceLabel
            // 
            this.highPriceLabel.AutoSize = true;
            this.highPriceLabel.Location = new System.Drawing.Point(249, 493);
            this.highPriceLabel.Name = "highPriceLabel";
            this.highPriceLabel.Size = new System.Drawing.Size(181, 17);
            this.highPriceLabel.TabIndex = 11;
            this.highPriceLabel.Text = "Enter acceptable high price";
            this.highPriceLabel.Visible = false;
            // 
            // lowPriceTextBox
            // 
            this.lowPriceTextBox.Location = new System.Drawing.Point(330, 460);
            this.lowPriceTextBox.Name = "lowPriceTextBox";
            this.lowPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowPriceTextBox.TabIndex = 12;
            this.lowPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lowPriceTextBox.Visible = false;
            // 
            // highPriceTextBox
            // 
            this.highPriceTextBox.Location = new System.Drawing.Point(330, 525);
            this.highPriceTextBox.Name = "highPriceTextBox";
            this.highPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.highPriceTextBox.TabIndex = 13;
            this.highPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.highPriceTextBox.Visible = false;
            // 
            // ShortSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.highPriceTextBox);
            this.Controls.Add(this.lowPriceTextBox);
            this.Controls.Add(this.highPriceLabel);
            this.Controls.Add(this.lowPriceLabel);
            this.Controls.Add(this.limitOrderButton);
            this.Controls.Add(this.closedShortSalesButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.shortSaleButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.shortSaleListBox);
            this.Controls.Add(this.sharesHeading);
            this.Controls.Add(this.symbolHeading);
            this.Controls.Add(this.sharesTextBox);
            this.Controls.Add(this.symbolTextBox);
            this.Name = "ShortSaleForm";
            this.Text = "ShortSaleForm";
            this.Load += new System.EventHandler(this.ShortSaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.TextBox sharesTextBox;
        private System.Windows.Forms.Label symbolHeading;
        private System.Windows.Forms.Label sharesHeading;
        private System.Windows.Forms.ListBox shortSaleListBox;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button shortSaleButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button closedShortSalesButton;
        private System.Windows.Forms.Button limitOrderButton;
        private System.Windows.Forms.Label lowPriceLabel;
        private System.Windows.Forms.Label highPriceLabel;
        private System.Windows.Forms.TextBox lowPriceTextBox;
        private System.Windows.Forms.TextBox highPriceTextBox;
    }
}