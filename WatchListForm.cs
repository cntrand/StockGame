using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockGamePrototype1
{
    public partial class WatchListForm : Form
    {
        List<decimal> priceList = new List<decimal>();
        DBAccess dBAccess = new DBAccess();
        List<string> headlines = new List<string>();
        List<string> stories = new List<string>();

        int id = 0;
        string symbol = "";

        string listLine = "";
        decimal dividend = 0.0m;
        decimal earnings = 0.0m;
        decimal revenue = 0.0m;
        decimal priceToEarns = 0.0m;
        decimal divToEarns = 0.0m;
        decimal earnsToRev = 0.0m;

        public WatchListForm()
        {
            InitializeComponent();
        }

        private void WatchListForm_Load(object sender, EventArgs e)
        {
            List<string> symbolList = new List<string>();
            symbolList = dBAccess.getAllStockSymbols();
            foreach (string symbl in symbolList)
            {
                symbolListBox.Items.Add(symbl);
            }

            id = SignInForm.idStatic;

            // END LOAD
        }
        private void symbolListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbol = symbolListBox.SelectedItem.ToString();
            priceList = dBAccess.getAllStockPrices(symbol);
            loadChart();
            watchListBox.Items.Clear();
            headlinesListBox.Items.Clear();
            storyLabel.Text = "";
            stockNameLabel.Text = "";
            sectorLabel.Text = "";
            descriptionLabel.Text = "";
            string description = "";
            description = dBAccess.getStockDescription(symbol);
            descriptionLabel.Text = description;
            string sector = "";
            sector = dBAccess.getStockSector(symbol);
            sectorLabel.Text = sector;
            string stockName = "";
            stockName = dBAccess.getStockName(symbol);
            stockNameLabel.Text = stockName;
            symbolLabel.Text = symbol;

            dividend = dBAccess.getDividendPerShare(symbol);
            string strDividend = dividend.ToString("c");
            earnings = dBAccess.getEarningsPerShare(symbol);
            string strEarnings = earnings.ToString("c");
            revenue = dBAccess.getRevenuePerShare(symbol);
            string strRevenue = revenue.ToString("c");
            divToEarns = dividend / earnings;
            string strDivToEarns = divToEarns.ToString("p");
            earnsToRev = earnings / revenue;
            string strEarnsToRev = earnsToRev.ToString("p");
            DateTime dividendDate = dBAccess.getDividendDateTime(symbol);
            string strDivDate = dividendDate.ToString("d");
            decimal price = priceList[priceList.Count - 1];
            priceToEarns = price / earnings;
            string strPrice = price.ToString("c");
            listLine = strPrice + " current price";
            watchListBox.Items.Add(listLine);
            listLine = strDividend + " dividend paid " + strDivDate;
            watchListBox.Items.Add(listLine);
            listLine = strEarnings + "earnings";
            watchListBox.Items.Add(listLine);
            listLine = strRevenue + "revenue";
            watchListBox.Items.Add(listLine);
            listLine = strDivToEarns + " dividend to earnings";
            watchListBox.Items.Add(listLine);
            listLine = strEarnsToRev + " earnings to revenue";
            watchListBox.Items.Add(listLine);

            headlines = dBAccess.getNewsHeadLines(symbol);
            foreach (string headline in headlines)
            {
                headlinesListBox.Items.Add(headline);
            }
            stories = dBAccess.getNewsStories(symbol);
        }

        private void loadChart()
        {
            priceChart.Series[0].Points.Clear();
            foreach (decimal price in priceList)
            {
                priceChart.Series[0].Points.AddY(price);
            }
        }

        private void sectorLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headlinesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            storyLabel.Text = stories[headlinesListBox.SelectedIndex];
        }
    }
}
