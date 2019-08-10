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
    public partial class NewsForm : Form
    {
        public static string symbolStatic = null;
        string symbol;
        decimal highPrice = 0.0m;
        decimal lowPrice = 0.0m;
        DBAccess dBAccess = new DBAccess();
        DateTime dateTime = new DateTime();
        decimal dividend = 0.0m;
        decimal earnings = 0.0m;
        decimal revenue = 0.0m;
        decimal divToEarns = 0.0m;
        decimal earnsToRev = 0.0m;
        decimal zero = 0.0m;
        decimal balance = 0.0m;
        int shares = 0;
        decimal investorDividend = 0.0m;

        public NewsForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            symbol = symbolTextBox.Text;
            dividendSymbol.Text = symbol;
            dividend = dBAccess.getDividendPerShare(symbol);
            string strDividend = dividend.ToString();
            earnings = dBAccess.getEarningsPerShare(symbol);
            string strEarnings = earnings.ToString();
            revenue = dBAccess.getRevenuePerShare(symbol);
            string strRevenue = revenue.ToString();
            dividendTextBox.Text = strDividend;
            earningsTextBox.Text = strEarnings;
            revenueTextBox.Text = strRevenue;
            divToEarns = dividend / earnings;
            earnsToRev = earnings / revenue;
            dividendToEarningsLabel.Text = divToEarns.ToString("p");
            earningsToRevenueLabel.Text = earnsToRev.ToString("p");
            DateTime dividendDate = dBAccess.getDividendDateTime(symbol);
            dividendDateLabel.Text = dividendDate.ToString("d");
            symbolStatic = symbol;
            List<decimal> priceList = dBAccess.getAllStockPrices(symbol);
            decimal price = priceList[priceList.Count - 1];
            priceLabel.Text = price.ToString("c");
            highPrice = dBAccess.getBiasHighTarget(symbol);
            highLabel.Text = highPrice.ToString("c");
            lowPrice = dBAccess.getBiasLowTarget(symbol);
            lowLabel.Text = lowPrice.ToString("c");
            string sector = dBAccess.getStockSector(symbol);
            sectorLabel.Text = sector;
            string description = dBAccess.getStockDescription(symbol);
            descriptionLabel.Text = description;
            headlineTextBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string headline = "";
            headline = headlineTextBox.Text;
            string story = "";
            story = newsTextBox.Text;
            dateTime = DateTime.Now;
            dBAccess.addNews(symbol, dateTime, headline, story);
            this.Close();
        }

        private void saveBias_Click(object sender, EventArgs e)
        {
            decimal high = highPrice;
            decimal low = lowPrice;

            if (decimal.TryParse(highTextBox.Text, out high))
            {
                highLabel.Text = high.ToString("c");
            }
            if (decimal.TryParse(lowTextBox.Text, out low))
            {
                lowLabel.Text = low.ToString("c");
            }
            dBAccess.deleteBias(symbol);
            dBAccess.addBias(symbol, high, low);
        }

        private void storiesButton_Click(object sender, EventArgs e)
        {
            NewsStories newsStories = new NewsStories();
            newsStories.ShowDialog();
        }

        private void NewsForm_Load(object sender, EventArgs e)
        {
            symbolTextBox.Text = "";
            priceLabel.Text = "";
            highLabel.Text = "";
            lowLabel.Text = "";
            highTextBox.Text = "";
            lowTextBox.Text = "";
            headlineTextBox.Text = "";
            newsTextBox.Text = "";
            sectorLabel.Text = "";
            descriptionLabel.Text = "";
            symbolTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            symbolTextBox.Text = "";
            priceLabel.Text = "";
            highLabel.Text = "";
            lowLabel.Text = "";
            highTextBox.Text = "";
            lowTextBox.Text = "";
            headlineTextBox.Text = "";
            newsTextBox.Text = "";
            sectorLabel.Text = "";
            descriptionLabel.Text = "";
            symbolTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                dividend = decimal.Parse(dividendTextBox.Text);
                earnings = decimal.Parse(earningsTextBox.Text);
                revenue = decimal.Parse(revenueTextBox.Text);
                divToEarns = dividend / earnings;
                earnsToRev = earnings / revenue;
                dividendToEarningsLabel.Text = divToEarns.ToString("p");
                earningsToRevenueLabel.Text = earnsToRev.ToString("p");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void postDividendButton_Click(object sender, EventArgs e)
        {
            try
            {
                dBAccess.deleteDividend(symbol);
                dateTime = DateTime.Now;
                dBAccess.addDividend(symbol, dateTime, dividend, earnings, revenue);
                List<int> ids = dBAccess.getAllPortfolioIds(symbol);
                foreach (int id in ids)
                {
                    List<string> dividendSymbols = dBAccess.getAllPortfolioSymbols(id);
                    foreach (string dividendSymbol in dividendSymbols)
                    {
                        if (dividendSymbol == symbol)
                        {
                            balance = dBAccess.getInvestorBalance(id);
                            shares = dBAccess.getPortfolioShares(id, symbol);
                            investorDividend = shares * dividend;
                            dBAccess.deleteInvestorDividend(id, symbol);
                            dBAccess.addInvestorDividend(id, symbol, dateTime, investorDividend);
                            balance = balance + investorDividend;
                            dBAccess.updateInvestorBalance(id, balance);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
