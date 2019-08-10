namespace StockGamePrototype1
{
    partial class NewsStories
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
            this.headlineListBox = new System.Windows.Forms.ListBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.symbolHeader = new System.Windows.Forms.Label();
            this.headlineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headlineListBox
            // 
            this.headlineListBox.FormattingEnabled = true;
            this.headlineListBox.ItemHeight = 16;
            this.headlineListBox.Location = new System.Drawing.Point(0, 0);
            this.headlineListBox.Name = "headlineListBox";
            this.headlineListBox.Size = new System.Drawing.Size(296, 532);
            this.headlineListBox.TabIndex = 0;
            this.headlineListBox.SelectedIndexChanged += new System.EventHandler(this.headlineListBox_SelectedIndexChanged);
            // 
            // storyLabel
            // 
            this.storyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storyLabel.Location = new System.Drawing.Point(327, 58);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(482, 261);
            this.storyLabel.TabIndex = 1;
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(327, 390);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(100, 22);
            this.symbolTextBox.TabIndex = 2;
            // 
            // symbolHeader
            // 
            this.symbolHeader.AutoSize = true;
            this.symbolHeader.Location = new System.Drawing.Point(324, 361);
            this.symbolHeader.Name = "symbolHeader";
            this.symbolHeader.Size = new System.Drawing.Size(54, 17);
            this.symbolHeader.TabIndex = 3;
            this.symbolHeader.Text = "Symbol";
            // 
            // headlineButton
            // 
            this.headlineButton.Location = new System.Drawing.Point(457, 457);
            this.headlineButton.Name = "headlineButton";
            this.headlineButton.Size = new System.Drawing.Size(124, 62);
            this.headlineButton.TabIndex = 4;
            this.headlineButton.Text = "Edit Headline and Story";
            this.headlineButton.UseVisualStyleBackColor = true;
            this.headlineButton.Click += new System.EventHandler(this.headlineButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on Headline to get Story";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(637, 457);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 51);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // NewsStories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 567);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headlineButton);
            this.Controls.Add(this.symbolHeader);
            this.Controls.Add(this.symbolTextBox);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.headlineListBox);
            this.Name = "NewsStories";
            this.Load += new System.EventHandler(this.NewsStories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox headlineListBox;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label symbolHeader;
        private System.Windows.Forms.Button headlineButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
    }
}