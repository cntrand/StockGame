namespace StockGamePrototype1
{
    partial class LoadStockForm
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
            this.loadStockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadStockButton
            // 
            this.loadStockButton.Location = new System.Drawing.Point(88, 74);
            this.loadStockButton.Name = "loadStockButton";
            this.loadStockButton.Size = new System.Drawing.Size(86, 72);
            this.loadStockButton.TabIndex = 0;
            this.loadStockButton.Text = "Load Stock";
            this.loadStockButton.UseVisualStyleBackColor = true;
            this.loadStockButton.Click += new System.EventHandler(this.loadStockButton_Click);
            // 
            // LoadStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.loadStockButton);
            this.Name = "LoadStockForm";
            this.Text = "LoadStockForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadStockButton;
    }
}