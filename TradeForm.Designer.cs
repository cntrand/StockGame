namespace StockGamePrototype1
{
    partial class TradeForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.idHeader = new System.Windows.Forms.Label();
            this.balanceHeader = new System.Windows.Forms.Label();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.sharesTextBox = new System.Windows.Forms.TextBox();
            this.symbolHeader = new System.Windows.Forms.Label();
            this.sharesHeader = new System.Windows.Forms.Label();
            this.symbolDetailListBox = new System.Windows.Forms.ListBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.startOverButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.getPriceButton = new System.Windows.Forms.Button();
            this.closeShortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLabel.Location = new System.Drawing.Point(68, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(122, 23);
            this.idLabel.TabIndex = 0;
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(68, 62);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(122, 23);
            this.balanceLabel.TabIndex = 1;
            // 
            // idHeader
            // 
            this.idHeader.AutoSize = true;
            this.idHeader.Location = new System.Drawing.Point(12, 26);
            this.idHeader.Name = "idHeader";
            this.idHeader.Size = new System.Drawing.Size(21, 17);
            this.idHeader.TabIndex = 2;
            this.idHeader.Text = "ID";
            // 
            // balanceHeader
            // 
            this.balanceHeader.AutoSize = true;
            this.balanceHeader.Location = new System.Drawing.Point(4, 62);
            this.balanceHeader.Name = "balanceHeader";
            this.balanceHeader.Size = new System.Drawing.Size(58, 17);
            this.balanceHeader.TabIndex = 3;
            this.balanceHeader.Text = "balance";
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(90, 115);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(100, 22);
            this.symbolTextBox.TabIndex = 4;
            // 
            // sharesTextBox
            // 
            this.sharesTextBox.Location = new System.Drawing.Point(90, 158);
            this.sharesTextBox.Name = "sharesTextBox";
            this.sharesTextBox.Size = new System.Drawing.Size(100, 22);
            this.sharesTextBox.TabIndex = 5;
            // 
            // symbolHeader
            // 
            this.symbolHeader.AutoSize = true;
            this.symbolHeader.Location = new System.Drawing.Point(16, 120);
            this.symbolHeader.Name = "symbolHeader";
            this.symbolHeader.Size = new System.Drawing.Size(54, 17);
            this.symbolHeader.TabIndex = 6;
            this.symbolHeader.Text = "Symbol";
            // 
            // sharesHeader
            // 
            this.sharesHeader.AutoSize = true;
            this.sharesHeader.Location = new System.Drawing.Point(16, 158);
            this.sharesHeader.Name = "sharesHeader";
            this.sharesHeader.Size = new System.Drawing.Size(53, 17);
            this.sharesHeader.TabIndex = 7;
            this.sharesHeader.Text = "Shares";
            // 
            // symbolDetailListBox
            // 
            this.symbolDetailListBox.FormattingEnabled = true;
            this.symbolDetailListBox.ItemHeight = 16;
            this.symbolDetailListBox.Location = new System.Drawing.Point(274, 25);
            this.symbolDetailListBox.Name = "symbolDetailListBox";
            this.symbolDetailListBox.Size = new System.Drawing.Size(478, 372);
            this.symbolDetailListBox.TabIndex = 8;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(19, 327);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 9;
            this.buyButton.Text = "BUY";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(139, 327);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 10;
            this.sellButton.Text = "SELL";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // startOverButton
            // 
            this.startOverButton.Location = new System.Drawing.Point(19, 263);
            this.startOverButton.Name = "startOverButton";
            this.startOverButton.Size = new System.Drawing.Size(75, 58);
            this.startOverButton.TabIndex = 11;
            this.startOverButton.Text = "Start Over";
            this.startOverButton.UseVisualStyleBackColor = true;
            this.startOverButton.Click += new System.EventHandler(this.startOverButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getPriceButton
            // 
            this.getPriceButton.Location = new System.Drawing.Point(90, 208);
            this.getPriceButton.Name = "getPriceButton";
            this.getPriceButton.Size = new System.Drawing.Size(100, 23);
            this.getPriceButton.TabIndex = 13;
            this.getPriceButton.Text = "Get Price";
            this.getPriceButton.UseVisualStyleBackColor = true;
            this.getPriceButton.Click += new System.EventHandler(this.getPriceButton_Click);
            // 
            // closeShortButton
            // 
            this.closeShortButton.Location = new System.Drawing.Point(90, 368);
            this.closeShortButton.Name = "closeShortButton";
            this.closeShortButton.Size = new System.Drawing.Size(75, 83);
            this.closeShortButton.TabIndex = 14;
            this.closeShortButton.Text = "CLOSE SHORT SALE";
            this.closeShortButton.UseVisualStyleBackColor = true;
            this.closeShortButton.Click += new System.EventHandler(this.closeShortButton_Click);
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.closeShortButton);
            this.Controls.Add(this.getPriceButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startOverButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.symbolDetailListBox);
            this.Controls.Add(this.sharesHeader);
            this.Controls.Add(this.symbolHeader);
            this.Controls.Add(this.sharesTextBox);
            this.Controls.Add(this.symbolTextBox);
            this.Controls.Add(this.balanceHeader);
            this.Controls.Add(this.idHeader);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "TradeForm";
            this.Text = "TradeForm";
            this.Load += new System.EventHandler(this.TradeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label idHeader;
        private System.Windows.Forms.Label balanceHeader;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.TextBox sharesTextBox;
        private System.Windows.Forms.Label symbolHeader;
        private System.Windows.Forms.Label sharesHeader;
        private System.Windows.Forms.ListBox symbolDetailListBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button startOverButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getPriceButton;
        private System.Windows.Forms.Button closeShortButton;
    }
}