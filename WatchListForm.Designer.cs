namespace StockGamePrototype1
{
    partial class WatchListForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.priceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.symbolListBox = new System.Windows.Forms.ListBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.watchListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.headlinesListBox = new System.Windows.Forms.ListBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.sectorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // priceChart
            // 
            chartArea1.Name = "ChartArea1";
            this.priceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.priceChart.Legends.Add(legend1);
            this.priceChart.Location = new System.Drawing.Point(131, 64);
            this.priceChart.Name = "priceChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Price";
            this.priceChart.Series.Add(series1);
            this.priceChart.Size = new System.Drawing.Size(369, 276);
            this.priceChart.TabIndex = 0;
            this.priceChart.Text = "chart1";
            // 
            // symbolListBox
            // 
            this.symbolListBox.FormattingEnabled = true;
            this.symbolListBox.ItemHeight = 16;
            this.symbolListBox.Location = new System.Drawing.Point(26, 76);
            this.symbolListBox.Name = "symbolListBox";
            this.symbolListBox.Size = new System.Drawing.Size(99, 660);
            this.symbolListBox.TabIndex = 1;
            this.symbolListBox.SelectedIndexChanged += new System.EventHandler(this.symbolListBox_SelectedIndexChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(528, 87);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(297, 661);
            this.descriptionLabel.TabIndex = 2;
            // 
            // symbolLabel
            // 
            this.symbolLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolLabel.Location = new System.Drawing.Point(219, 12);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(100, 23);
            this.symbolLabel.TabIndex = 8;
            // 
            // watchListBox
            // 
            this.watchListBox.FormattingEnabled = true;
            this.watchListBox.ItemHeight = 16;
            this.watchListBox.Location = new System.Drawing.Point(131, 349);
            this.watchListBox.Name = "watchListBox";
            this.watchListBox.Size = new System.Drawing.Size(369, 388);
            this.watchListBox.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(26, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 41);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headlinesListBox
            // 
            this.headlinesListBox.FormattingEnabled = true;
            this.headlinesListBox.ItemHeight = 16;
            this.headlinesListBox.Location = new System.Drawing.Point(867, 30);
            this.headlinesListBox.Name = "headlinesListBox";
            this.headlinesListBox.Size = new System.Drawing.Size(416, 196);
            this.headlinesListBox.TabIndex = 11;
            this.headlinesListBox.SelectedIndexChanged += new System.EventHandler(this.headlinesListBox_SelectedIndexChanged);
            // 
            // storyLabel
            // 
            this.storyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storyLabel.Location = new System.Drawing.Point(864, 263);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(419, 474);
            this.storyLabel.TabIndex = 12;
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockNameLabel.Location = new System.Drawing.Point(528, 12);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(297, 23);
            this.stockNameLabel.TabIndex = 13;
            // 
            // sectorLabel
            // 
            this.sectorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectorLabel.Location = new System.Drawing.Point(528, 47);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(297, 25);
            this.sectorLabel.TabIndex = 14;
            // 
            // WatchListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 875);
            this.Controls.Add(this.sectorLabel);
            this.Controls.Add(this.stockNameLabel);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.headlinesListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.watchListBox);
            this.Controls.Add(this.symbolLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.symbolListBox);
            this.Controls.Add(this.priceChart);
            this.Name = "WatchListForm";
            this.Text = "WatchListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WatchListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart priceChart;
        private System.Windows.Forms.ListBox symbolListBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.ListBox watchListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox headlinesListBox;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Label stockNameLabel;
        private System.Windows.Forms.Label sectorLabel;
    }
}