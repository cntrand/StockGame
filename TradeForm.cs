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
    public partial class TradeForm : Form
    {
        DBAccess dBAccess = new DBAccess();

        DateTime dateTime = new DateTime();

        int shares = 0;
        int id = 0;
        int newShares = 0;
        int totshares = 0;
        decimal balance = 0.0m;
        string symbol = "";
        decimal price = 0.0m;
        string listLine = "";
        decimal purchaseAmount = 0.0m;
        decimal newBalance = 0.0m;
        decimal avgAcqPrice = 0.0m;
        decimal newAvgAcqPrice = 0.0m;
        int sellShares = 0;
        decimal sellAmount = 0.0m;
        int shortShares = 0;
        int totShortShares = 0;
        decimal shortPrice = 0.0m;
        decimal shortTotal = 0.0m;
        decimal closeShortTotal = 0.0m;
        decimal closeAmtRequired = 0.0m;
        decimal cashRemaining = 0.0m;
        int closeShares = 0;

        public TradeForm()
        {
            InitializeComponent();
        }

        private void TradeForm_Load(object sender, EventArgs e)
        {
            idLabel.Text = SignInForm.idStatic.ToString();
            id = SignInForm.idStatic;
            balance = dBAccess.getInvestorBalance(id);
            balanceLabel.Text = balance.ToString("c2");
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try
            { 
                    newShares = int.Parse(sharesTextBox.Text);
                    purchaseAmount = newShares * price;
                    if (purchaseAmount > balance)
                    {
                        MessageBox.Show("Insufficient Balance");
                        symbolTextBox.Text = "";
                        sharesTextBox.Text = "";
                        symbolTextBox.Focus();
                    }
                    else
                    {
                        shares = dBAccess.getPortfolioShares(id, symbol);
                        newBalance = balance - purchaseAmount;
                        dBAccess.updateInvestorBalance(id, newBalance);
                        balance = newBalance;
                        balanceLabel.Text = balance.ToString("c");
                        totshares = shares + newShares;
                        if (totshares == newShares)
                        {
                            avgAcqPrice = price;
                            dBAccess.addPortFolio(id, symbol, totshares, avgAcqPrice);
                        }
                        else
                        {
                            avgAcqPrice = dBAccess.getPortfolioAvgAcqPrice(id, symbol);
                            newAvgAcqPrice = ((avgAcqPrice * shares) + (price * newShares)) / totshares;
                            avgAcqPrice = newAvgAcqPrice;
                            dBAccess.updatePortfolioAvgAcqPrice(id, symbol, avgAcqPrice);
                            dBAccess.updatePortfolioShares(id, symbol, totshares);
                        }
                        listLine = "";
                        listLine = "You have " + totshares + " of " + symbol + " at avgAcqPrice of " + avgAcqPrice.ToString("c");
                        symbolDetailListBox.Items.Add(listLine);
                        dateTime = DateTime.Now;
                        dBAccess.addStockPurchase(id, symbol, dateTime, newShares, price);
                        symbolTextBox.Text = "";
                        sharesTextBox.Text = "";
                        symbolTextBox.Focus();
                    }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                symbolTextBox.Text = "";
                sharesTextBox.Text = "";
                symbolTextBox.Focus();
            }  
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            try
            {
                    sellShares = int.Parse(sharesTextBox.Text);
                    sellAmount = sellShares * price;
                    shares = dBAccess.getPortfolioShares(id, symbol);
                    if (sellShares > shares)
                    {
                        MessageBox.Show("Insufficient Shares Owned");
                        symbolTextBox.Text = "";
                        sharesTextBox.Text = "";
                        symbolTextBox.Focus();
                    }
                    else
                    {
                        newBalance = balance + sellAmount;
                        dBAccess.updateInvestorBalance(id, newBalance);
                        balance = newBalance;
                        balanceLabel.Text = balance.ToString("c2");
                        totshares = shares - sellShares;
                        avgAcqPrice = dBAccess.getPortfolioAvgAcqPrice(id, symbol);
                        if (totshares == 0)
                        {
                            dBAccess.deletePortfolio(id, symbol);
                        }
                        else
                        {
                            newAvgAcqPrice = ((avgAcqPrice * shares) - (avgAcqPrice * sellShares)) / totshares;
                            avgAcqPrice = newAvgAcqPrice;
                            dBAccess.updatePortfolioAvgAcqPrice(id, symbol, avgAcqPrice);
                            dBAccess.updatePortfolioShares(id, symbol, totshares);
                        }
                        listLine = "";
                        listLine = "You now have " + totshares + " of " + symbol + " at avgAcqPrice of " + avgAcqPrice.ToString("c");
                        symbolDetailListBox.Items.Add(listLine);
                        dateTime = DateTime.Now;
                        dBAccess.addStockSale(id, symbol, dateTime, sellShares, price);
                        symbolTextBox.Text = "";
                        sharesTextBox.Text = "";
                        symbolTextBox.Focus();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                symbolTextBox.Text = "";
                sharesTextBox.Text = "";
                symbolTextBox.Focus();
            }
        }

        private void getPriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = symbolTextBox.Text;
                price = 0.0m;
                List<decimal> priceList = dBAccess.getAllStockPrices(symbol);

                if (priceList.Count > 0)
                {
                    price = priceList[priceList.Count - 1];
                }

                if (price == 0.0m)
                {
                    MessageBox.Show("invalid symbol");
                }
                else
                {
                    listLine = "";
                    listLine = "Current price for " + symbol + " is " + price.ToString("c");
                    symbolDetailListBox.Items.Add(listLine);

                    List<string> symbols = dBAccess.getAllShortSaleSymbols(id);
                    shortShares = 0;
                    totShortShares = 0;
                    shortPrice = 0.0m;
                    shortTotal = 0.0m;
                    foreach (string oldSymbol in symbols)
                    {
                        if (symbol == oldSymbol)
                        {
                            List<DateTime> dateTimes = dBAccess.getAllShortSaleDateTimes(id, oldSymbol);
                            foreach (DateTime dateTime in dateTimes)
                            {
                                shortShares = dBAccess.getShortSaleShares(dateTime, id, symbol);
                                totShortShares = totShortShares + shortShares;
                                shortPrice = dBAccess.getShortSalePrice(dateTime, id, symbol);
                                shortTotal = shortShares * shortPrice;
                            }
                        }
                    }
                    if (totShortShares != 0)
                    {
                        listLine = "";
                        listLine = "Open Short Sale is:";
                        symbolDetailListBox.Items.Add(listLine);
                        listLine = "";
                        listLine = shortShares.ToString() + " " + symbol + " @ " + shortPrice.ToString("c")
                            + " for total short sale of " + shortTotal.ToString("c");
                        symbolDetailListBox.Items.Add(listLine);
                        listLine = "";
                        listLine = "To close this short sale select CLOSE SHORT SALE";
                        symbolDetailListBox.Items.Add(listLine);
                    }
                    else
                    {
                        listLine = "Select BUY, SELL, Start Over, or Exit";
                        symbolDetailListBox.Items.Add(listLine);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                symbolTextBox.Text = "";
                sharesTextBox.Text = "";
                symbolTextBox.Focus();
            }
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            symbolTextBox.Text = "";
            sharesTextBox.Text = "";
            symbolTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeShortButton_Click(object sender, EventArgs e)
        {
            closeShortTotal = balance + shortTotal;
            closeAmtRequired = shortShares * price;
            if (closeShortTotal < closeAmtRequired)
            {
                listLine = "";
                listLine = "Insufficient cash to close short sale";
            }
            else
            {
                cashRemaining = shortTotal - closeAmtRequired;
                balance = balance + cashRemaining;
                dBAccess.updateInvestorBalance(id, balance);
                balanceLabel.Text = balance.ToString("c2");
                closeShares = shortShares * -1;
                dateTime = DateTime.Now;
                dBAccess.addShortSale(dateTime, id, symbol, closeShares, price);
                List<DateTime> shortLimitDateTimes =
                    dBAccess.getShortSaleLimitOrderDateTimes(id, symbol);
                foreach (DateTime shortLimitDateTime in shortLimitDateTimes)
                {
                    dBAccess.deleteShortSaleLimitOrder(shortLimitDateTime, id, symbol);
                }
                shortTotal = closeShares * price;
                listLine = "";
                listLine = "Short Sale Closed";
                listLine = "";
                listLine = shortShares.ToString() + " " + symbol + " @ " + price.ToString("c") +
                    " for total short sale of " + shortTotal.ToString("c");
                symbolDetailListBox.Items.Add(listLine);
            }
        }
    }
}
