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
    public partial class ShortSaleForm : Form
    {
        DBAccess dBAccess = new DBAccess();
        List<decimal> pricelist = new List<decimal>();
        DateTime dateTime = new DateTime();

        int id = 0;
        string shortSymbol = "";
        string listLine = "";
        decimal shortPrice = 0.0m;
        int shortShares = 0;
        int shortSaleShares = 0;
        decimal shortTotal = 0.0m;
        decimal shortSymbolTotal = 0.0m;
        decimal shortGrandTotal = 0.0m;
        DateTime openDateTime;
        decimal lowPrice = 0.0m;
        decimal highPrice = 0.0m;
        decimal balance = 0.0m;
        decimal closeShortTotal = 0.0m;
        decimal closePrice = 0.0m;

        int totShortShares = 0;

        public ShortSaleForm()
        {
            InitializeComponent();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            id = SignInForm.idStatic;
            totShortShares = 0;
            shortSymbol = symbolTextBox.Text;
            shortShares = int.Parse(sharesTextBox.Text);
            List<decimal> priceList = dBAccess.getAllStockPrices(shortSymbol);
            shortPrice = priceList[priceList.Count - 1];
            shortTotal = shortShares * shortPrice;
            List<string> shortSymbols = dBAccess.getAllShortSaleSymbols(id);
            foreach (string oldShortSymbol in shortSymbols)
            {
                if (shortSymbol == oldShortSymbol)
                {
                    List<DateTime> dateTimes = dBAccess.getAllShortSaleDateTimes(id, oldShortSymbol);
                    foreach (DateTime dateTime in dateTimes)
                    {
                        shortSaleShares = dBAccess.getShortSaleShares(dateTime, id, shortSymbol);
                        totShortShares = totShortShares + shortSaleShares;
                    }
                }
            }
            if (totShortShares == 0)
            {
                listLine = "";
                listLine = "Proposed Short Sale is:";
                shortSaleListBox.Items.Add(listLine);
                listLine = "";
                listLine = shortShares.ToString() + " " + shortSymbol + " @ " + shortPrice.ToString("c") +
                    " for total short sale of " + shortTotal.ToString("c");
                shortSaleListBox.Items.Add(listLine);
            }
            else
            {
                listLine = "You have an open short sale for " + shortSymbol;
                shortSaleListBox.Items.Add(listLine);
                List<string> shortLimitSymbols = dBAccess.getAllShortSaleLimitOrderSymbols(id);
                bool openLimit = false;
                foreach (string oldShortLimitSymbol in shortLimitSymbols)
                {
                    if (oldShortLimitSymbol == shortSymbol)
                    {
                        openLimit = true;
                        listLine = "You have a short sale limit order for " + shortSymbol;
                        shortSaleListBox.Items.Add(listLine);
                    }
                }
                if (openLimit == false)
                {
                    listLine = "If you want to place a short sale limit order";
                    shortSaleListBox.Items.Add(listLine);
                    listLine = "for this short sale,";
                    shortSaleListBox.Items.Add(listLine);
                    listLine = "enter low and high price below";
                    shortSaleListBox.Items.Add(listLine);
                    listLine = "then click SHORT SALE LIMIT ORDER";
                    shortSaleListBox.Items.Add(listLine);
                    limitOrderButton.Visible = true;
                    lowPriceLabel.Visible = true;
                    lowPriceTextBox.Visible = true;
                    highPriceLabel.Visible = true;
                    highPriceTextBox.Visible = true;
                }
            }        
            
        }

        private void shortSaleButton_Click(object sender, EventArgs e)
        {
            if (totShortShares == 0)
            {
                id = SignInForm.idStatic;
                dateTime = DateTime.Now;
                dBAccess.addShortSale(dateTime, id, shortSymbol, shortShares, shortPrice);
                listLine = "";
                listLine = "Short Sale Added";
                shortSaleListBox.Items.Add(listLine);
            }
            else
            {
                listLine = "";
                listLine = "Only one open short sale is allowed for one symbol";
                shortSaleListBox.Items.Add(listLine);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShortSaleForm_Load(object sender, EventArgs e)
        {
            id = SignInForm.idStatic;
            shortShares = 0;
            shortGrandTotal = 0.0m;
            List<string> symbols = dBAccess.getAllShortSaleSymbols(id);
            string saveSymbol = "";
            int shortCount = 0;
            int openShortShares = 0;
            decimal openShortPrice = 0.0m;
            decimal openShortTotal = 0.0m;
            foreach (string shortSymbol in symbols)
            {
                if (saveSymbol != shortSymbol)
                {
                    saveSymbol = shortSymbol;
                    List<DateTime> dateTimes = dBAccess.getAllShortSaleDateTimes(id, shortSymbol);
                    shortCount = dateTimes.Count;
                    if (shortCount % 2 == 1)
                    {
                        openDateTime = dateTimes[dateTimes.Count - 1];
                        openShortShares = dBAccess.getShortSaleShares(openDateTime, id, shortSymbol);
                        openShortPrice = dBAccess.getShortSalePrice(openDateTime, id, shortSymbol);
                        openShortTotal = openShortShares * openShortPrice;
                        listLine = "Open Short Sale";
                        shortSaleListBox.Items.Add(listLine);
                        listLine = openShortShares.ToString() + " " + shortSymbol + " @ "
                                  + openShortPrice.ToString("c2")
                                  + " for total short sale of " + openShortTotal.ToString("c2");
                        shortSaleListBox.Items.Add(listLine);
                        List<decimal> priceList = dBAccess.getAllStockPrices(shortSymbol);
                        decimal curPrice = priceList[priceList.Count - 1];
                        listLine = shortSymbol + " current price is " + curPrice.ToString("c");
                        shortSaleListBox.Items.Add(listLine);
                        // CLOSE SHORT SALE HERE
                        List<string> shortLimitSymbols = dBAccess.getAllShortSaleLimitOrderSymbols(id);
                        foreach (string shortLimitSymbol in shortLimitSymbols)
                        {
                            if (shortLimitSymbol == shortSymbol)
                            {
                                List<DateTime> shortLimitDateTimes =
                                    dBAccess.getShortSaleLimitOrderDateTimes(id, shortLimitSymbol);
                                foreach (DateTime shortLimitDateTime in shortLimitDateTimes)
                                {
                                    lowPrice = dBAccess.getShortSaleLimitOrderLowPrice
                                              (shortLimitDateTime, id, shortLimitSymbol);
                                    highPrice = dBAccess.getShortSaleLimitOrderHighPrice
                                              (shortLimitDateTime, id, shortLimitSymbol);
                                    List<DateTime> priceDateTimes =
                                              dBAccess.getStockPriceDateTimes(shortLimitSymbol);
                                    int priceIndex = -1;
                                    foreach (DateTime priceDateTime in priceDateTimes)
                                    {
                                        priceIndex += 1;
                                        if (priceDateTime > shortLimitDateTime)
                                        {
                                            string strPrice = priceList[priceIndex].ToString("c4");
                                            string strLow = lowPrice.ToString("c2");
                                            string strHigh = highPrice.ToString("c2");
                                            MessageBox.Show(strPrice + " " + strLow + " " + strHigh);
                                            if (priceList[priceIndex] < lowPrice)
                                            {
                                                closeShortTotal = lowPrice * openShortShares;
                                                closePrice = lowPrice;
                                            }
                                            else if (priceList[priceIndex] > highPrice)
                                            {
                                                closeShortTotal = highPrice * openShortShares;
                                                closePrice = highPrice;
                                            }
                                            else
                                            {
                                                closePrice = 0.0m;
                                                closeShortTotal = 0.0m;
                                            }
                                            if (closePrice != 0.0m)
                                            {
                                                // CLOSE SHORT SALE HERE
                                                MessageBox.Show(closePrice.ToString("c2"));
                                                balance = dBAccess.getInvestorBalance(id);
                                                decimal closeAmtRequired = openShortShares * closePrice;
                                                decimal cashRemaining = openShortTotal - closeAmtRequired;
                                                balance = balance + cashRemaining;
                                                dBAccess.updateInvestorBalance(id, balance);
                                                int closeShares = openShortShares * -1;
                                                dateTime = DateTime.Now;
                                                dBAccess.addShortSale(dateTime, id, shortSymbol, closeShares,
                                                    closePrice);
                                                dBAccess.deleteShortSaleLimitOrder
                                                    (shortLimitDateTime, id, shortSymbol);
                                                closeShortTotal = closeShares * closePrice;
                                                listLine = "SHORT SALE CLOSED";
                                                listLine = closeShares.ToString() + " " + shortSymbol + "@" +
                                                           closePrice.ToString("c2")
                                                           + "for total short sale of "
                                                           + closeShortTotal.ToString();
                                                shortSaleListBox.Items.Add(listLine);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void closedShortSalesButton_Click(object sender, EventArgs e)
        {
            List<string> symbols = dBAccess.getAllShortSaleSymbols(id);
            string saveSymbol = "";
            int shortCount = 0;
            int shortShares = 0;
            decimal shortPrice = 0.0m;
            decimal shortTotal = 0.0m;
            decimal shortGrandTotal = 0.0m;
            foreach (string shortSymbol in symbols)
            {
                if (saveSymbol != shortSymbol)
                {
                    saveSymbol = shortSymbol;
                    List<DateTime> dateTimes = dBAccess.getAllShortSaleDateTimes(id, shortSymbol);
                    shortCount = dateTimes.Count;
                    if (shortCount % 2 == 1)
                    {
                        openDateTime = dateTimes[dateTimes.Count - 1];
                    }
                    else
                    {
                        DateTime openDateTime = new DateTime(1999, 12, 31);
                    }
                    totShortShares = 0;
                    shortSymbolTotal = 0;
                    foreach (DateTime dateTime in dateTimes)
                    {
                        if (dateTime != openDateTime)
                        {
                            shortShares = dBAccess.getShortSaleShares(dateTime, id, shortSymbol);
                            shortPrice = dBAccess.getShortSalePrice(dateTime, id, shortSymbol);
                            totShortShares = totShortShares + shortShares;
                            shortTotal = shortShares * shortPrice;
                            shortSymbolTotal = shortSymbolTotal + shortTotal;
                            listLine = shortShares.ToString() + " " + shortSymbol + " @ "
                                + shortPrice.ToString("c2") + " for total short sale of "
                                + shortTotal.ToString("c2");
                            shortSaleListBox.Items.Add(listLine);
                        }
                    }
                    listLine = totShortShares.ToString() + " " + shortSymbol + " " 
                        + shortSymbolTotal.ToString("c2") + " Symbol Gain";
                    shortSaleListBox.Items.Add(listLine);
                    listLine = "";
                    shortSaleListBox.Items.Add(listLine);
                    shortGrandTotal = shortGrandTotal + shortSymbolTotal;
                    shortSymbolTotal = 0.0m;
                }
            }
            listLine = "Total Short Sale Gain = " + shortGrandTotal.ToString("c2");
            shortSaleListBox.Items.Add(listLine);
        }

        private void limitOrderButton_Click(object sender, EventArgs e)
        {
            lowPrice = decimal.Parse(lowPriceTextBox.Text);
            highPrice = decimal.Parse(highPriceTextBox.Text);
            dateTime = DateTime.Now;
            
            listLine = "NEW SHORT SALE LIMIT ORDER";
            shortSaleListBox.Items.Add(listLine);
            listLine = id.ToString() + " " + shortSymbol + " " + lowPrice.ToString("c2") + " " +
                highPrice.ToString("c2") + " " + dateTime.ToString();
            shortSaleListBox.Items.Add(listLine);
            dBAccess.addShortSaleLimitOrder(dateTime, id, shortSymbol, lowPrice, highPrice);

           

        }
    }
}
