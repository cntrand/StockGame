namespace StockGamePrototype1
{
    partial class NewsForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.newsTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.priceHeading = new System.Windows.Forms.Label();
            this.highHeading = new System.Windows.Forms.Label();
            this.lowHeading = new System.Windows.Forms.Label();
            this.newHighHeading = new System.Windows.Forms.Label();
            this.newLowHeading = new System.Windows.Forms.Label();
            this.saveBias = new System.Windows.Forms.Button();
            this.storyLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionHeader = new System.Windows.Forms.Label();
            this.headlineTextBox = new System.Windows.Forms.TextBox();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.sectorHeader = new System.Windows.Forms.Label();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.storiesButton = new System.Windows.Forms.Button();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dividendHeading = new System.Windows.Forms.Label();
            this.dividendTextBox = new System.Windows.Forms.TextBox();
            this.earningsTextBox = new System.Windows.Forms.TextBox();
            this.revenueTextBox = new System.Windows.Forms.TextBox();
            this.dividendLabel = new System.Windows.Forms.Label();
            this.earningsLabel = new System.Windows.Forms.Label();
            this.revenueLabel = new System.Windows.Forms.Label();
            this.dividendToEarnings = new System.Windows.Forms.Label();
            this.earningsToRevenue = new System.Windows.Forms.Label();
            this.dividendToEarningsLabel = new System.Windows.Forms.Label();
            this.earningsToRevenueLabel = new System.Windows.Forms.Label();
            this.dividendSymbol = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.reEnterButton = new System.Windows.Forms.Button();
            this.postDividendButton = new System.Windows.Forms.Button();
            this.dividendDateHeading = new System.Windows.Forms.Label();
            this.dividendDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(31, 41);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(100, 22);
            this.symbolTextBox.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Location = new System.Drawing.Point(155, 319);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 1;
            // 
            // highLabel
            // 
            this.highLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highLabel.Location = new System.Drawing.Point(155, 358);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(100, 23);
            this.highLabel.TabIndex = 2;
            // 
            // lowLabel
            // 
            this.lowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowLabel.Location = new System.Drawing.Point(155, 400);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(100, 23);
            this.lowLabel.TabIndex = 3;
            // 
            // newsTextBox
            // 
            this.newsTextBox.Location = new System.Drawing.Point(318, 104);
            this.newsTextBox.Multiline = true;
            this.newsTextBox.Name = "newsTextBox";
            this.newsTextBox.Size = new System.Drawing.Size(597, 196);
            this.newsTextBox.TabIndex = 4;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(31, 75);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(266, 144);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter Symbol\r\n then CLICK HERE to get stock information AND\r\nChange Target Prices" +
    " to reflect Story Tone AND/OR\r\nEnter Headline and Story OR\r\nGet Stories History " +
    "OR enter dividend\r\n\r\n\r\n\r\n\r\n";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(155, 225);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(142, 75);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Headline and Story and Exit";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(155, 441);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 22);
            this.highTextBox.TabIndex = 7;
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(155, 480);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowTextBox.TabIndex = 8;
            // 
            // priceHeading
            // 
            this.priceHeading.AutoSize = true;
            this.priceHeading.Location = new System.Drawing.Point(35, 325);
            this.priceHeading.Name = "priceHeading";
            this.priceHeading.Size = new System.Drawing.Size(91, 17);
            this.priceHeading.TabIndex = 9;
            this.priceHeading.Text = "Current Price";
            // 
            // highHeading
            // 
            this.highHeading.AutoSize = true;
            this.highHeading.Location = new System.Drawing.Point(35, 364);
            this.highHeading.Name = "highHeading";
            this.highHeading.Size = new System.Drawing.Size(83, 17);
            this.highHeading.TabIndex = 10;
            this.highHeading.Text = "High Target";
            // 
            // lowHeading
            // 
            this.lowHeading.AutoSize = true;
            this.lowHeading.Location = new System.Drawing.Point(35, 406);
            this.lowHeading.Name = "lowHeading";
            this.lowHeading.Size = new System.Drawing.Size(79, 17);
            this.lowHeading.TabIndex = 11;
            this.lowHeading.Text = "Low Target";
            // 
            // newHighHeading
            // 
            this.newHighHeading.AutoSize = true;
            this.newHighHeading.Location = new System.Drawing.Point(35, 446);
            this.newHighHeading.Name = "newHighHeading";
            this.newHighHeading.Size = new System.Drawing.Size(114, 17);
            this.newHighHeading.TabIndex = 12;
            this.newHighHeading.Text = "New High Target";
            // 
            // newLowHeading
            // 
            this.newLowHeading.AutoSize = true;
            this.newLowHeading.Location = new System.Drawing.Point(32, 483);
            this.newLowHeading.Name = "newLowHeading";
            this.newLowHeading.Size = new System.Drawing.Size(110, 17);
            this.newLowHeading.TabIndex = 13;
            this.newLowHeading.Text = "New Low Target";
            // 
            // saveBias
            // 
            this.saveBias.Location = new System.Drawing.Point(147, 526);
            this.saveBias.Name = "saveBias";
            this.saveBias.Size = new System.Drawing.Size(108, 72);
            this.saveBias.TabIndex = 14;
            this.saveBias.Text = "Save Target Price Changes";
            this.saveBias.UseVisualStyleBackColor = true;
            this.saveBias.Click += new System.EventHandler(this.saveBias_Click);
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Location = new System.Drawing.Point(315, 75);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(41, 17);
            this.storyLabel.TabIndex = 15;
            this.storyLabel.Text = "Story";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.descriptionLabel.Location = new System.Drawing.Point(318, 400);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(597, 198);
            this.descriptionLabel.TabIndex = 16;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.AutoSize = true;
            this.descriptionHeader.Location = new System.Drawing.Point(315, 374);
            this.descriptionHeader.Name = "descriptionHeader";
            this.descriptionHeader.Size = new System.Drawing.Size(79, 17);
            this.descriptionHeader.TabIndex = 17;
            this.descriptionHeader.Text = "Description";
            // 
            // headlineTextBox
            // 
            this.headlineTextBox.Location = new System.Drawing.Point(318, 41);
            this.headlineTextBox.Name = "headlineTextBox";
            this.headlineTextBox.Size = new System.Drawing.Size(597, 22);
            this.headlineTextBox.TabIndex = 18;
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Location = new System.Drawing.Point(315, 18);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(64, 17);
            this.headlineLabel.TabIndex = 19;
            this.headlineLabel.Text = "Headline";
            // 
            // sectorHeader
            // 
            this.sectorHeader.AutoSize = true;
            this.sectorHeader.Location = new System.Drawing.Point(315, 319);
            this.sectorHeader.Name = "sectorHeader";
            this.sectorHeader.Size = new System.Drawing.Size(47, 17);
            this.sectorHeader.TabIndex = 20;
            this.sectorHeader.Text = "sector";
            // 
            // sectorLabel
            // 
            this.sectorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectorLabel.Location = new System.Drawing.Point(316, 344);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(599, 23);
            this.sectorLabel.TabIndex = 21;
            // 
            // storiesButton
            // 
            this.storiesButton.Location = new System.Drawing.Point(31, 225);
            this.storiesButton.Name = "storiesButton";
            this.storiesButton.Size = new System.Drawing.Size(102, 62);
            this.storiesButton.TabIndex = 22;
            this.storiesButton.Text = "Get Stories History";
            this.storiesButton.UseVisualStyleBackColor = true;
            this.storiesButton.Click += new System.EventHandler(this.storiesButton_Click);
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Location = new System.Drawing.Point(28, 18);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(92, 17);
            this.symbolLabel.TabIndex = 23;
            this.symbolLabel.Text = "Enter Symbol";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(31, 570);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(31, 526);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 28);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dividendHeading
            // 
            this.dividendHeading.Location = new System.Drawing.Point(980, 9);
            this.dividendHeading.Name = "dividendHeading";
            this.dividendHeading.Size = new System.Drawing.Size(241, 37);
            this.dividendHeading.TabIndex = 26;
            this.dividendHeading.Text = "Enter symbol, then enter dividend, earnings, and revenue";
            // 
            // dividendTextBox
            // 
            this.dividendTextBox.Location = new System.Drawing.Point(1079, 167);
            this.dividendTextBox.Name = "dividendTextBox";
            this.dividendTextBox.Size = new System.Drawing.Size(100, 22);
            this.dividendTextBox.TabIndex = 27;
            // 
            // earningsTextBox
            // 
            this.earningsTextBox.Location = new System.Drawing.Point(1079, 197);
            this.earningsTextBox.Name = "earningsTextBox";
            this.earningsTextBox.Size = new System.Drawing.Size(100, 22);
            this.earningsTextBox.TabIndex = 28;
            // 
            // revenueTextBox
            // 
            this.revenueTextBox.Location = new System.Drawing.Point(1079, 235);
            this.revenueTextBox.Name = "revenueTextBox";
            this.revenueTextBox.Size = new System.Drawing.Size(100, 22);
            this.revenueTextBox.TabIndex = 29;
            // 
            // dividendLabel
            // 
            this.dividendLabel.AutoSize = true;
            this.dividendLabel.Location = new System.Drawing.Point(980, 170);
            this.dividendLabel.Name = "dividendLabel";
            this.dividendLabel.Size = new System.Drawing.Size(63, 17);
            this.dividendLabel.TabIndex = 30;
            this.dividendLabel.Text = "Dividend";
            // 
            // earningsLabel
            // 
            this.earningsLabel.AutoSize = true;
            this.earningsLabel.Location = new System.Drawing.Point(979, 202);
            this.earningsLabel.Name = "earningsLabel";
            this.earningsLabel.Size = new System.Drawing.Size(64, 17);
            this.earningsLabel.TabIndex = 31;
            this.earningsLabel.Text = "Earnings";
            // 
            // revenueLabel
            // 
            this.revenueLabel.AutoSize = true;
            this.revenueLabel.Location = new System.Drawing.Point(978, 238);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(65, 17);
            this.revenueLabel.TabIndex = 32;
            this.revenueLabel.Text = "Revenue";
            // 
            // dividendToEarnings
            // 
            this.dividendToEarnings.Location = new System.Drawing.Point(978, 277);
            this.dividendToEarnings.Name = "dividendToEarnings";
            this.dividendToEarnings.Size = new System.Drawing.Size(142, 23);
            this.dividendToEarnings.TabIndex = 33;
            this.dividendToEarnings.Text = "Dividend to Earnings";
            // 
            // earningsToRevenue
            // 
            this.earningsToRevenue.AutoSize = true;
            this.earningsToRevenue.Location = new System.Drawing.Point(979, 345);
            this.earningsToRevenue.Name = "earningsToRevenue";
            this.earningsToRevenue.Size = new System.Drawing.Size(141, 17);
            this.earningsToRevenue.TabIndex = 34;
            this.earningsToRevenue.Text = "Earnings to Revenue";
            // 
            // dividendToEarningsLabel
            // 
            this.dividendToEarningsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dividendToEarningsLabel.Location = new System.Drawing.Point(1076, 309);
            this.dividendToEarningsLabel.Name = "dividendToEarningsLabel";
            this.dividendToEarningsLabel.Size = new System.Drawing.Size(100, 23);
            this.dividendToEarningsLabel.TabIndex = 35;
            // 
            // earningsToRevenueLabel
            // 
            this.earningsToRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.earningsToRevenueLabel.Location = new System.Drawing.Point(1076, 386);
            this.earningsToRevenueLabel.Name = "earningsToRevenueLabel";
            this.earningsToRevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.earningsToRevenueLabel.TabIndex = 36;
            // 
            // dividendSymbol
            // 
            this.dividendSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dividendSymbol.Location = new System.Drawing.Point(981, 56);
            this.dividendSymbol.Name = "dividendSymbol";
            this.dividendSymbol.Size = new System.Drawing.Size(100, 23);
            this.dividendSymbol.TabIndex = 37;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(983, 441);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 23);
            this.calculateButton.TabIndex = 38;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // reEnterButton
            // 
            this.reEnterButton.Location = new System.Drawing.Point(983, 477);
            this.reEnterButton.Name = "reEnterButton";
            this.reEnterButton.Size = new System.Drawing.Size(211, 23);
            this.reEnterButton.TabIndex = 39;
            this.reEnterButton.Text = "ReEnter Dividend Information";
            this.reEnterButton.UseVisualStyleBackColor = true;
            // 
            // postDividendButton
            // 
            this.postDividendButton.Location = new System.Drawing.Point(983, 526);
            this.postDividendButton.Name = "postDividendButton";
            this.postDividendButton.Size = new System.Drawing.Size(155, 57);
            this.postDividendButton.TabIndex = 40;
            this.postDividendButton.Text = "Post Dividend to Investor Balances";
            this.postDividendButton.UseVisualStyleBackColor = true;
            this.postDividendButton.Click += new System.EventHandler(this.postDividendButton_Click);
            // 
            // dividendDateHeading
            // 
            this.dividendDateHeading.AutoSize = true;
            this.dividendDateHeading.Location = new System.Drawing.Point(980, 90);
            this.dividendDateHeading.Name = "dividendDateHeading";
            this.dividendDateHeading.Size = new System.Drawing.Size(160, 17);
            this.dividendDateHeading.TabIndex = 41;
            this.dividendDateHeading.Text = "Last Dividend Paid Date";
            // 
            // dividendDateLabel
            // 
            this.dividendDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dividendDateLabel.Location = new System.Drawing.Point(980, 121);
            this.dividendDateLabel.Name = "dividendDateLabel";
            this.dividendDateLabel.Size = new System.Drawing.Size(199, 23);
            this.dividendDateLabel.TabIndex = 42;
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 627);
            this.Controls.Add(this.dividendDateLabel);
            this.Controls.Add(this.dividendDateHeading);
            this.Controls.Add(this.postDividendButton);
            this.Controls.Add(this.reEnterButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dividendSymbol);
            this.Controls.Add(this.earningsToRevenueLabel);
            this.Controls.Add(this.dividendToEarningsLabel);
            this.Controls.Add(this.earningsToRevenue);
            this.Controls.Add(this.dividendToEarnings);
            this.Controls.Add(this.revenueLabel);
            this.Controls.Add(this.earningsLabel);
            this.Controls.Add(this.dividendLabel);
            this.Controls.Add(this.revenueTextBox);
            this.Controls.Add(this.earningsTextBox);
            this.Controls.Add(this.dividendTextBox);
            this.Controls.Add(this.dividendHeading);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.symbolLabel);
            this.Controls.Add(this.storiesButton);
            this.Controls.Add(this.sectorLabel);
            this.Controls.Add(this.sectorHeader);
            this.Controls.Add(this.headlineLabel);
            this.Controls.Add(this.headlineTextBox);
            this.Controls.Add(this.descriptionHeader);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.saveBias);
            this.Controls.Add(this.newLowHeading);
            this.Controls.Add(this.newHighHeading);
            this.Controls.Add(this.lowHeading);
            this.Controls.Add(this.highHeading);
            this.Controls.Add(this.priceHeading);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.newsTextBox);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.symbolTextBox);
            this.Name = "NewsForm";
            this.Text = "News Form";
            this.Load += new System.EventHandler(this.NewsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.TextBox newsTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.Label priceHeading;
        private System.Windows.Forms.Label highHeading;
        private System.Windows.Forms.Label lowHeading;
        private System.Windows.Forms.Label newHighHeading;
        private System.Windows.Forms.Label newLowHeading;
        private System.Windows.Forms.Button saveBias;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptionHeader;
        private System.Windows.Forms.TextBox headlineTextBox;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label sectorHeader;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.Button storiesButton;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label dividendHeading;
        private System.Windows.Forms.TextBox dividendTextBox;
        private System.Windows.Forms.TextBox earningsTextBox;
        private System.Windows.Forms.TextBox revenueTextBox;
        private System.Windows.Forms.Label dividendLabel;
        private System.Windows.Forms.Label earningsLabel;
        private System.Windows.Forms.Label revenueLabel;
        private System.Windows.Forms.Label dividendToEarnings;
        private System.Windows.Forms.Label earningsToRevenue;
        private System.Windows.Forms.Label dividendToEarningsLabel;
        private System.Windows.Forms.Label earningsToRevenueLabel;
        private System.Windows.Forms.Label dividendSymbol;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button reEnterButton;
        private System.Windows.Forms.Button postDividendButton;
        private System.Windows.Forms.Label dividendDateHeading;
        private System.Windows.Forms.Label dividendDateLabel;
    }
}