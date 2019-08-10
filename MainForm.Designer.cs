namespace StockGamePrototype1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.signOutButton = new System.Windows.Forms.Button();
            this.tradeButton = new System.Windows.Forms.Button();
            this.watchListButton = new System.Windows.Forms.Button();
            this.shortSalesButton = new System.Windows.Forms.Button();
            this.limitOrdersButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new StockGamePrototype1.Database1DataSet();
            this.portfolioTextBox = new System.Windows.Forms.TextBox();
            this.watchListTextBox = new System.Windows.Forms.TextBox();
            this.tickerTextBox = new System.Windows.Forms.TextBox();
            this.stockTableAdapter = new StockGamePrototype1.Database1DataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new StockGamePrototype1.Database1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.portfolioListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(60, 55);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(140, 55);
            this.signOutButton.TabIndex = 0;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // tradeButton
            // 
            this.tradeButton.Location = new System.Drawing.Point(60, 156);
            this.tradeButton.Margin = new System.Windows.Forms.Padding(4);
            this.tradeButton.Name = "tradeButton";
            this.tradeButton.Size = new System.Drawing.Size(140, 55);
            this.tradeButton.TabIndex = 1;
            this.tradeButton.Text = "Trade";
            this.tradeButton.UseVisualStyleBackColor = true;
            this.tradeButton.Click += new System.EventHandler(this.tradeButton_Click);
            // 
            // watchListButton
            // 
            this.watchListButton.Location = new System.Drawing.Point(60, 277);
            this.watchListButton.Margin = new System.Windows.Forms.Padding(4);
            this.watchListButton.Name = "watchListButton";
            this.watchListButton.Size = new System.Drawing.Size(140, 55);
            this.watchListButton.TabIndex = 2;
            this.watchListButton.Text = "Watch List";
            this.watchListButton.UseVisualStyleBackColor = true;
            this.watchListButton.Click += new System.EventHandler(this.watchListButton_Click);
            // 
            // shortSalesButton
            // 
            this.shortSalesButton.Location = new System.Drawing.Point(60, 388);
            this.shortSalesButton.Margin = new System.Windows.Forms.Padding(4);
            this.shortSalesButton.Name = "shortSalesButton";
            this.shortSalesButton.Size = new System.Drawing.Size(140, 55);
            this.shortSalesButton.TabIndex = 3;
            this.shortSalesButton.Text = "Short Sales";
            this.shortSalesButton.UseVisualStyleBackColor = true;
            this.shortSalesButton.Click += new System.EventHandler(this.shortSalesButton_Click);
            // 
            // limitOrdersButton
            // 
            this.limitOrdersButton.Location = new System.Drawing.Point(60, 498);
            this.limitOrdersButton.Margin = new System.Windows.Forms.Padding(4);
            this.limitOrdersButton.Name = "limitOrdersButton";
            this.limitOrdersButton.Size = new System.Drawing.Size(140, 55);
            this.limitOrdersButton.TabIndex = 4;
            this.limitOrdersButton.Text = "Limit Orders";
            this.limitOrdersButton.UseVisualStyleBackColor = true;
            this.limitOrdersButton.Click += new System.EventHandler(this.limitOrdersButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(60, 609);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(140, 55);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // portfolioTextBox
            // 
            this.portfolioTextBox.Location = new System.Drawing.Point(260, 687);
            this.portfolioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.portfolioTextBox.Name = "portfolioTextBox";
            this.portfolioTextBox.Size = new System.Drawing.Size(1312, 22);
            this.portfolioTextBox.TabIndex = 8;
            // 
            // watchListTextBox
            // 
            this.watchListTextBox.Location = new System.Drawing.Point(260, 730);
            this.watchListTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.watchListTextBox.Name = "watchListTextBox";
            this.watchListTextBox.Size = new System.Drawing.Size(1312, 22);
            this.watchListTextBox.TabIndex = 9;
            // 
            // tickerTextBox
            // 
            this.tickerTextBox.Location = new System.Drawing.Point(260, 774);
            this.tickerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tickerTextBox.Name = "tickerTextBox";
            this.tickerTextBox.Size = new System.Drawing.Size(1312, 22);
            this.tickerTextBox.TabIndex = 10;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BiasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DividendTableAdapter = null;
            this.tableAdapterManager.EarningsTableAdapter = null;
            this.tableAdapterManager.InvestorDividendTableAdapter = null;
            this.tableAdapterManager.InvestorTableAdapter = null;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.PortfolioTableAdapter = null;
            this.tableAdapterManager.PurchaseLimitTableAdapter = null;
            this.tableAdapterManager.RevenueTableAdapter = null;
            this.tableAdapterManager.SaleLimitTableAdapter = null;
            this.tableAdapterManager.SectorTableAdapter = null;
            this.tableAdapterManager.ShortSaleTableAdapter = null;
            this.tableAdapterManager.StockPriceTableAdapter = null;
            this.tableAdapterManager.StockPurchaseTableAdapter = null;
            this.tableAdapterManager.StockSaleTableAdapter = null;
            this.tableAdapterManager.StockSoldTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StockGamePrototype1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WatchListTableAdapter = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // portfolioListBox
            // 
            this.portfolioListBox.FormattingEnabled = true;
            this.portfolioListBox.ItemHeight = 16;
            this.portfolioListBox.Location = new System.Drawing.Point(349, 55);
            this.portfolioListBox.Name = "portfolioListBox";
            this.portfolioListBox.Size = new System.Drawing.Size(597, 596);
            this.portfolioListBox.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1604, 814);
            this.Controls.Add(this.portfolioListBox);
            this.Controls.Add(this.tickerTextBox);
            this.Controls.Add(this.watchListTextBox);
            this.Controls.Add(this.portfolioTextBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.limitOrdersButton);
            this.Controls.Add(this.shortSalesButton);
            this.Controls.Add(this.watchListButton);
            this.Controls.Add(this.tradeButton);
            this.Controls.Add(this.signOutButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button tradeButton;
        private System.Windows.Forms.Button watchListButton;
        private System.Windows.Forms.Button shortSalesButton;
        private System.Windows.Forms.Button limitOrdersButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TextBox portfolioTextBox;
        private System.Windows.Forms.TextBox watchListTextBox;
        private System.Windows.Forms.TextBox tickerTextBox;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database1DataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox portfolioListBox;
    }
}