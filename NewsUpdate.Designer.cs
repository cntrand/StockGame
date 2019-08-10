namespace StockGamePrototype1
{
    partial class NewsUpdate
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
            this.symbolLabel = new System.Windows.Forms.Label();
            this.headlineTextBox = new System.Windows.Forms.TextBox();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.storyTextBox = new System.Windows.Forms.TextBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // symbolLabel
            // 
            this.symbolLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolLabel.Location = new System.Drawing.Point(41, 33);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(100, 23);
            this.symbolLabel.TabIndex = 0;
            // 
            // headlineTextBox
            // 
            this.headlineTextBox.Location = new System.Drawing.Point(41, 117);
            this.headlineTextBox.Name = "headlineTextBox";
            this.headlineTextBox.Size = new System.Drawing.Size(730, 22);
            this.headlineTextBox.TabIndex = 1;
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Location = new System.Drawing.Point(38, 86);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(64, 17);
            this.headlineLabel.TabIndex = 2;
            this.headlineLabel.Text = "Headline";
            // 
            // storyTextBox
            // 
            this.storyTextBox.Location = new System.Drawing.Point(41, 191);
            this.storyTextBox.Multiline = true;
            this.storyTextBox.Name = "storyTextBox";
            this.storyTextBox.Size = new System.Drawing.Size(730, 343);
            this.storyTextBox.TabIndex = 3;
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Location = new System.Drawing.Point(38, 160);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(41, 17);
            this.storyLabel.TabIndex = 4;
            this.storyLabel.Text = "Story";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(205, 22);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(124, 59);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update Headline and Story";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(390, 22);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // NewsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 571);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.storyTextBox);
            this.Controls.Add(this.headlineLabel);
            this.Controls.Add(this.headlineTextBox);
            this.Controls.Add(this.symbolLabel);
            this.Name = "NewsUpdate";
            this.Text = "NewsUpdate";
            this.Load += new System.EventHandler(this.NewsUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.TextBox headlineTextBox;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.TextBox storyTextBox;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button exitButton;
    }
}