namespace StockGamePrototype1
{
    partial class TestDB
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.testPriceButton = new System.Windows.Forms.Button();
            this.limitOrdersListBox = new System.Windows.Forms.ListBox();
            this.testDupsButton = new System.Windows.Forms.Button();
            this.TestSQLnodupsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(38, 61);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(158, 22);
            this.userNameTextBox.TabIndex = 0;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(96, 126);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testPriceButton
            // 
            this.testPriceButton.Location = new System.Drawing.Point(96, 176);
            this.testPriceButton.Name = "testPriceButton";
            this.testPriceButton.Size = new System.Drawing.Size(75, 65);
            this.testPriceButton.TabIndex = 2;
            this.testPriceButton.Text = "Test PriceList";
            this.testPriceButton.UseVisualStyleBackColor = true;
            this.testPriceButton.Click += new System.EventHandler(this.testPriceButton_Click);
            // 
            // limitOrdersListBox
            // 
            this.limitOrdersListBox.FormattingEnabled = true;
            this.limitOrdersListBox.ItemHeight = 16;
            this.limitOrdersListBox.Location = new System.Drawing.Point(241, 10);
            this.limitOrdersListBox.Name = "limitOrdersListBox";
            this.limitOrdersListBox.Size = new System.Drawing.Size(519, 580);
            this.limitOrdersListBox.TabIndex = 3;
            // 
            // testDupsButton
            // 
            this.testDupsButton.Location = new System.Drawing.Point(96, 298);
            this.testDupsButton.Name = "testDupsButton";
            this.testDupsButton.Size = new System.Drawing.Size(75, 65);
            this.testDupsButton.TabIndex = 4;
            this.testDupsButton.Text = "Remove Dups";
            this.testDupsButton.UseVisualStyleBackColor = true;
            this.testDupsButton.Click += new System.EventHandler(this.testDupsButton_Click);
            // 
            // TestSQLnodupsButton
            // 
            this.TestSQLnodupsButton.Location = new System.Drawing.Point(96, 401);
            this.TestSQLnodupsButton.Name = "TestSQLnodupsButton";
            this.TestSQLnodupsButton.Size = new System.Drawing.Size(75, 72);
            this.TestSQLnodupsButton.TabIndex = 5;
            this.TestSQLnodupsButton.Text = "test SQL no dups";
            this.TestSQLnodupsButton.UseVisualStyleBackColor = true;
            this.TestSQLnodupsButton.Click += new System.EventHandler(this.TestSQLnodupsButton_Click);
            // 
            // TestDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 752);
            this.Controls.Add(this.TestSQLnodupsButton);
            this.Controls.Add(this.testDupsButton);
            this.Controls.Add(this.limitOrdersListBox);
            this.Controls.Add(this.testPriceButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "TestDB";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button testPriceButton;
        private System.Windows.Forms.ListBox limitOrdersListBox;
        private System.Windows.Forms.Button testDupsButton;
        private System.Windows.Forms.Button TestSQLnodupsButton;
    }
}