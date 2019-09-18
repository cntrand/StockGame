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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DBAccess dBAccess = new DBAccess();
        int id = -1;
        string ticker_str = null;

        private void signOutButton_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();

        }

        private void tradeButton_Click(object sender, EventArgs e)
        {
            TradeForm trade = new TradeForm();

            //MainForm.ActiveForm.Hide();

            trade.ShowDialog();
        }

        private void watchListButton_Click(object sender, EventArgs e)
        {
            WatchListForm watchList = new WatchListForm();

            watchList.ShowDialog();
        }

        private void shortSalesButton_Click(object sender, EventArgs e)
        {
            ShortSaleForm shortSale = new ShortSaleForm();

            shortSale.ShowDialog();
        }

        private void limitOrdersButton_Click(object sender, EventArgs e)
        {
            LimitSalesForm limitSales = new LimitSalesForm();

            limitSales.ShowDialog();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();

            help.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //SignInForm signIn = new SignInForm();
            //signIn.ShowDialog();

            if (SignInForm.emailStatic != null)
            {
                id = dBAccess.getInvestorID(SignInForm.emailStatic);
            }

            if(id != -1)
            {
                fillTicker();
                fillPortfolioTB();
            }

            displayPortfolio();

            // check open limit orders
            bool limitFlag = false;
            List<string> purchSymbols = dBAccess.getAllPurchLimitSymbols(id);
            if (purchSymbols.Count > 0)
            {
                limitFlag = true;
            }
            List<string> saleSymbols = dBAccess.getAllSaleLimitSymbols(id);
            if (saleSymbols.Count > 0)
            {
                limitFlag = true;
            }
            if (limitFlag == true)
            {
                LimitSalesForm limitSales = new LimitSalesForm();
                limitSales.ShowDialog();
            }
            // end check open limit orders
        }

        private void fillPortfolioTB()
        {
            string portfolio = null;
            List<string> symbols = new List<string>();
            
            symbols = dBAccess.getAllPortfolioSymbols(id);

            foreach(string symbol in symbols)
            {
                portfolio += (symbol + " ");
            }

            portfolioTextBox.Text = portfolio;
        }

        private void rotateTicker()
        {
            if(ticker_str != null)
            {
                char[] temp_ticker = ticker_str.ToArray();
            
                ticker_str = null;

                for(int i=1; i < temp_ticker.Length; i++)
                {
                    ticker_str += temp_ticker[i];
                }
                ticker_str += temp_ticker[0];
                tickerTextBox.Text = ticker_str;
            }
        }

        private void fillTicker()
        {
            List<decimal> priceList = new List<decimal>();
            List<string> symbols = new List<string>();

            symbols = dBAccess.getAllStockSymbols();

            foreach (string symbol in symbols)
            {

                int predex = 0;
                decimal diff = 0.0m;
                priceList = dBAccess.getAllStockPrices(symbol);
                int ndex = priceList.Count;
                int curdex = ndex - 1;
                if (ndex > 1)
                {
                    predex = ndex - 2;
                    diff = priceList[curdex] - priceList[predex];
                }
                string strdiff = diff.ToString("n");
                
                ticker_str = ticker_str + symbol + " " + priceList[priceList.Count - 1].ToString("n")
                       + " chg " + strdiff + " ** ";

            }

            tickerTextBox.Text = ticker_str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotateTicker();
        }

        private void displayPortfolio()
        {
            List<decimal> priceList = new List<decimal>();

            int shares = 0;
            int id = 0;
            decimal balance = 0.0m;
            string symbol = "";
            decimal price = 0.0m;
            decimal curval = 0.0m;
            decimal acqVal = 0.0m;
            decimal totval = 0.0m;
            decimal totacq = 0.0m;
            decimal netGain = 0.0m;
            decimal avgAcqPrice = 0.0m;
            string listLine = "";
            string purchLine = "";
            decimal salePrice = 0.0m;
            int saleShares = 0;
            decimal saleAmount = 0.0m;
            decimal totalSaleAmount = 0.0m;
            int totalSaleShares = 0;
            decimal purchasePrice = 0.0m;
            decimal purchaseAmount = 0.0m;
            int purchaseShares = 0;
            decimal totalPurchaseAmount = 0.0m;
            int totalPurchaseShares = 0;
            decimal totalGain = 0.0m;

                id = SignInForm.idStatic;
                string name = dBAccess.getInvestorName(id);
                listLine = name + " " + id.ToString();
                portfolioListBox.Items.Add(listLine);
                listLine = "";
                portfolioListBox.Items.Add(listLine);
                balance = dBAccess.getInvestorBalance(id);
                listLine = balance.ToString("c2") + " CASH BALANCE";
                portfolioListBox.Items.Add(listLine);
                totval = 0.0m;
                totacq = 0.0m;
                netGain = 0.0m;
                listLine = "";
                portfolioListBox.Items.Add(listLine);
                listLine = "     PORTFOLIO";
                portfolioListBox.Items.Add(listLine);
                listLine = "";
                portfolioListBox.Items.Add(listLine);
                List<string> stockSymbols = dBAccess.getAllPortfolioSymbols(id);
                foreach (string stockSymbol in stockSymbols)
                {
                    List<decimal> stockPriceList = dBAccess.getAllStockPrices(stockSymbol);
                    price = stockPriceList[stockPriceList.Count - 1];
                    shares = dBAccess.getPortfolioShares(id, stockSymbol);
                    avgAcqPrice = dBAccess.getPortfolioAvgAcqPrice(id, stockSymbol);
                    curval = shares * price;
                    acqVal = shares * avgAcqPrice;
                    netGain = curval - acqVal;
                    listLine = stockSymbol + " " + shares.ToString() + " CurPrice=" + price.ToString("c2") +
                        " AcqPrice=" + avgAcqPrice.ToString("c2");
                    portfolioListBox.Items.Add(listLine);
                    listLine = "Value=" + curval.ToString("c2") + " Cost " + acqVal.ToString("c2")
                        + " Gain " + netGain.ToString("c2");
                portfolioListBox.Items.Add(listLine);
                    listLine = "";
                    portfolioListBox.Items.Add(listLine);
                    totval = totval + curval;
                    totacq = totacq + acqVal;
                }
                decimal totGain = totval - totacq;
                listLine = "Total Value = " + totval.ToString("c2") + " Total Cost =  "
                    + totacq.ToString("c2") + " Total Gain = " + totGain.ToString("c2");
                portfolioListBox.Items.Add(listLine);

                //end portfolio display and begin purchase and sale displays

                listLine = "";
                portfolioListBox.Items.Add(listLine);
                listLine = "     PORTFOLIO SALES";
                portfolioListBox.Items.Add(listLine);
                listLine = "";
                portfolioListBox.Items.Add(listLine);
                List<string> holdList = new List<string>();
                List<string> purchaseSymbols = new List<string>();
                purchaseSymbols = dBAccess.getAllStockPurchaseSymbols(id);
                string saveSymbol = "";
                foreach (string purchaseSymbol in purchaseSymbols)
                {
                    List<string> purchList = new List<string>();

                    if (saveSymbol != purchaseSymbol)
                    {
                        saveSymbol = purchaseSymbol;
                        List<DateTime> purchaseDateTimes = new List<DateTime>();
                        purchaseDateTimes = dBAccess.getStockPurchaseDateTimes(id, purchaseSymbol);
                        totalPurchaseAmount = 0.0m;
                        totalPurchaseShares = 0;
                        foreach (DateTime purchaseDateTime in purchaseDateTimes)
                        {
                            purchasePrice = dBAccess.getStockPurchasePrice(id, purchaseSymbol, purchaseDateTime);
                            purchaseShares = dBAccess.getStockPurchaseShares(id, purchaseSymbol, purchaseDateTime);
                            purchaseAmount = purchasePrice * purchaseShares;
                            totalPurchaseAmount += purchaseAmount;
                            totalPurchaseShares += purchaseShares;
                            purchLine = purchaseShares.ToString() + " shares " + purchaseSymbol + " bought " +
                                    purchaseDateTime.ToString() + " @ " + purchasePrice.ToString("c2");
                            purchList.Add(purchLine);
                        }
                        if (totalPurchaseAmount != purchaseAmount)
                        {
                            purchLine = totalPurchaseShares.ToString() + " shares " + purchaseSymbol +
                                " bought for " + totalPurchaseAmount.ToString();
                            purchList.Add(purchLine);
                        }
                        List<DateTime> saleDateTimes = new List<DateTime>();
                        saleDateTimes = dBAccess.getStockSaleDateTimes(id, purchaseSymbol);
                        totalSaleAmount = 0.0m;
                        totalSaleShares = 0;
                        if (saleDateTimes.Count > 0)
                        {
                            foreach (string purchListLine in purchList)
                            {
                                portfolioListBox.Items.Add(purchListLine);
                            }
                            foreach (DateTime saleDateTime in saleDateTimes)
                            {
                                salePrice = dBAccess.getStockSalePrice(id, purchaseSymbol, saleDateTime);
                                saleShares = dBAccess.getStockSaleShares(id, purchaseSymbol, saleDateTime);
                                saleAmount = salePrice * saleShares;
                                totalSaleAmount += saleAmount;
                                totalSaleShares += saleShares;
                                listLine = saleShares.ToString() + " shares " + purchaseSymbol + " sold " +
                                        saleDateTime.ToString() + " @ " + salePrice.ToString("c2");
                                portfolioListBox.Items.Add(listLine);
                            }
                            if (totalSaleAmount != saleAmount)
                            {
                                listLine = totalSaleShares.ToString() + " shares " + purchaseSymbol +
                                    " bought for " + totalSaleAmount.ToString("c2");
                                portfolioListBox.Items.Add(listLine);
                            }
                            listLine = "";
                            portfolioListBox.Items.Add(listLine);
                            totalGain = totalSaleAmount - totalPurchaseAmount;
                            listLine = "Total Symbol Gain = " + totalGain.ToString("c2");
                            portfolioListBox.Items.Add(listLine);
                            listLine = "";
                            portfolioListBox.Items.Add(listLine);
                        }
                        else
                        {
                            foreach (string purchListLine in purchList)
                            {
                                holdList.Add(purchListLine);
                            }
                        }
                    }

                }
                listLine = "     PORTFOLIO PURCHASES";
                portfolioListBox.Items.Add(listLine);
                listLine = "";
                portfolioListBox.Items.Add(listLine);
                foreach (string holdListLine in holdList)
                {
                    portfolioListBox.Items.Add(holdListLine);
                }
        }
    }
}
