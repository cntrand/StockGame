namespace StockGamePrototype1
{
    partial class NewStockForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameHeader = new System.Windows.Forms.Label();
            this.addStockButton = new System.Windows.Forms.Button();
            this.symbolHeader = new System.Windows.Forms.Label();
            this.descriptionHeader = new System.Windows.Forms.Label();
            this.deleteStockButton = new System.Windows.Forms.Button();
            this.sectorHeader = new System.Windows.Forms.Label();
            this.sectorTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.priceHeader = new System.Windows.Forms.Label();
            this.lowHeader = new System.Windows.Forms.Label();
            this.highHeader = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(122, 60);
            this.symbolTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(132, 22);
            this.symbolTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(589, 63);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(551, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(589, 129);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(551, 485);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // nameHeader
            // 
            this.nameHeader.AutoSize = true;
            this.nameHeader.Location = new System.Drawing.Point(424, 63);
            this.nameHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(45, 17);
            this.nameHeader.TabIndex = 6;
            this.nameHeader.Text = "Name";
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(69, 393);
            this.addStockButton.Margin = new System.Windows.Forms.Padding(4);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(139, 36);
            this.addStockButton.TabIndex = 7;
            this.addStockButton.Text = "Add Stock";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // symbolHeader
            // 
            this.symbolHeader.AutoSize = true;
            this.symbolHeader.Location = new System.Drawing.Point(35, 63);
            this.symbolHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.symbolHeader.Name = "symbolHeader";
            this.symbolHeader.Size = new System.Drawing.Size(54, 17);
            this.symbolHeader.TabIndex = 8;
            this.symbolHeader.Text = "Symbol";
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.AutoSize = true;
            this.descriptionHeader.Location = new System.Drawing.Point(424, 133);
            this.descriptionHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionHeader.Name = "descriptionHeader";
            this.descriptionHeader.Size = new System.Drawing.Size(79, 17);
            this.descriptionHeader.TabIndex = 9;
            this.descriptionHeader.Text = "Description";
            // 
            // deleteStockButton
            // 
            this.deleteStockButton.Location = new System.Drawing.Point(416, 393);
            this.deleteStockButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStockButton.Name = "deleteStockButton";
            this.deleteStockButton.Size = new System.Drawing.Size(133, 36);
            this.deleteStockButton.TabIndex = 14;
            this.deleteStockButton.Text = "Delete Stock";
            this.deleteStockButton.UseVisualStyleBackColor = true;
            this.deleteStockButton.Click += new System.EventHandler(this.deleteStockButton_Click);
            // 
            // sectorHeader
            // 
            this.sectorHeader.AutoSize = true;
            this.sectorHeader.Location = new System.Drawing.Point(35, 102);
            this.sectorHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorHeader.Name = "sectorHeader";
            this.sectorHeader.Size = new System.Drawing.Size(49, 17);
            this.sectorHeader.TabIndex = 15;
            this.sectorHeader.Text = "Sector";
            // 
            // sectorTextBox
            // 
            this.sectorTextBox.Location = new System.Drawing.Point(122, 102);
            this.sectorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sectorTextBox.Name = "sectorTextBox";
            this.sectorTextBox.Size = new System.Drawing.Size(132, 22);
            this.sectorTextBox.TabIndex = 16;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(122, 191);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(132, 22);
            this.priceTextBox.TabIndex = 17;
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(122, 242);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(132, 22);
            this.lowTextBox.TabIndex = 18;
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(122, 291);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(132, 22);
            this.highTextBox.TabIndex = 19;
            // 
            // priceHeader
            // 
            this.priceHeader.Location = new System.Drawing.Point(35, 190);
            this.priceHeader.Name = "priceHeader";
            this.priceHeader.Size = new System.Drawing.Size(81, 23);
            this.priceHeader.TabIndex = 20;
            this.priceHeader.Text = "Price";
            // 
            // lowHeader
            // 
            this.lowHeader.Location = new System.Drawing.Point(35, 242);
            this.lowHeader.Name = "lowHeader";
            this.lowHeader.Size = new System.Drawing.Size(81, 23);
            this.lowHeader.TabIndex = 21;
            this.lowHeader.Text = "Low";
            // 
            // highHeader
            // 
            this.highHeader.Location = new System.Drawing.Point(35, 291);
            this.highHeader.Name = "highHeader";
            this.highHeader.Size = new System.Drawing.Size(81, 23);
            this.highHeader.TabIndex = 22;
            this.highHeader.Text = "High";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(247, 393);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(145, 36);
            this.changeButton.TabIndex = 23;
            this.changeButton.Text = "Update Changes";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // NewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 663);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.highHeader);
            this.Controls.Add(this.lowHeader);
            this.Controls.Add(this.priceHeader);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.sectorTextBox);
            this.Controls.Add(this.sectorHeader);
            this.Controls.Add(this.deleteStockButton);
            this.Controls.Add(this.descriptionHeader);
            this.Controls.Add(this.symbolHeader);
            this.Controls.Add(this.addStockButton);
            this.Controls.Add(this.nameHeader);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.symbolTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewStockForm";
            this.Text = "AddStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label nameHeader;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.Label symbolHeader;
        private System.Windows.Forms.Label descriptionHeader;
        private System.Windows.Forms.Button deleteStockButton;
        private System.Windows.Forms.Label sectorHeader;
        private System.Windows.Forms.TextBox sectorTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.Label priceHeader;
        private System.Windows.Forms.Label lowHeader;
        private System.Windows.Forms.Label highHeader;
        private System.Windows.Forms.Button changeButton;
    }
}