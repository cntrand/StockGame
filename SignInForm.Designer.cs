namespace StockGamePrototype1
{
    partial class SignInForm
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.addStock = new System.Windows.Forms.Button();
            this.loadStockButton = new System.Windows.Forms.Button();
            this.addBiasButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.enterStoryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(88, 262);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(512, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(88, 155);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(512, 22);
            this.usernameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your username";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(501, 359);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 28);
            this.enterButton.TabIndex = 8;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(100, 359);
            this.newAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(251, 28);
            this.newAccountButton.TabIndex = 9;
            this.newAccountButton.Text = "Create a new account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // addStock
            // 
            this.addStock.Location = new System.Drawing.Point(658, 291);
            this.addStock.Margin = new System.Windows.Forms.Padding(4);
            this.addStock.Name = "addStock";
            this.addStock.Size = new System.Drawing.Size(100, 28);
            this.addStock.TabIndex = 10;
            this.addStock.Text = "Add Stock";
            this.addStock.UseVisualStyleBackColor = true;
            this.addStock.Click += new System.EventHandler(this.addStock_Click);
            // 
            // loadStockButton
            // 
            this.loadStockButton.Location = new System.Drawing.Point(658, 326);
            this.loadStockButton.Name = "loadStockButton";
            this.loadStockButton.Size = new System.Drawing.Size(75, 61);
            this.loadStockButton.TabIndex = 11;
            this.loadStockButton.Text = "Load Stock";
            this.loadStockButton.UseVisualStyleBackColor = true;
            this.loadStockButton.Click += new System.EventHandler(this.loadStockButton_Click);
            // 
            // addBiasButton
            // 
            this.addBiasButton.Location = new System.Drawing.Point(658, 391);
            this.addBiasButton.Name = "addBiasButton";
            this.addBiasButton.Size = new System.Drawing.Size(75, 61);
            this.addBiasButton.TabIndex = 12;
            this.addBiasButton.Text = "Add Bias Record";
            this.addBiasButton.UseVisualStyleBackColor = true;
            this.addBiasButton.Click += new System.EventHandler(this.addBiasButton_Click);
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(658, 188);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(75, 28);
            this.priceButton.TabIndex = 13;
            this.priceButton.Text = "Price Button";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(658, 226);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(65, 58);
            this.testButton.TabIndex = 14;
            this.testButton.Text = "Run Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // enterStoryButton
            // 
            this.enterStoryButton.Location = new System.Drawing.Point(658, 116);
            this.enterStoryButton.Name = "enterStoryButton";
            this.enterStoryButton.Size = new System.Drawing.Size(75, 61);
            this.enterStoryButton.TabIndex = 15;
            this.enterStoryButton.Text = "Enter Story";
            this.enterStoryButton.UseVisualStyleBackColor = true;
            this.enterStoryButton.Click += new System.EventHandler(this.enterStoryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(88, 34);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 535);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterStoryButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.addBiasButton);
            this.Controls.Add(this.loadStockButton);
            this.Controls.Add(this.addStock);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button addStock;
        private System.Windows.Forms.Button loadStockButton;
        private System.Windows.Forms.Button addBiasButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button enterStoryButton;
        private System.Windows.Forms.Button exitButton;
    }
}