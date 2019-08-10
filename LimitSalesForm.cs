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
    public partial class LimitSalesForm : Form
    {
        DBAccess dBAccess = new DBAccess();

        int id = 0;
        List<string> purchSymbols = new List<string>();
        List<string> saleSymbols = new List<string>();
        List<DateTime> priceDateTimes = new List<DateTime>();
        List<DateTime> purchDateTimes = new List<DateTime>();
        List<DateTime> saleDateTimes = new List<DateTime>();
        // int shares = 0;
        // decimal price = 0.0m;
        string listLine = "";
        decimal balance = 0.0m;
        decimal avgAcqPrice = 0.0m;
        decimal newAvgAcqPrice = 0.0m;
        int totShares = 0;
        int portfolioShares = 0;
      
        public LimitSalesForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Close the active limit sales
            // Display Main form "go back"
            LimitSalesForm.ActiveForm.Close();
        }

        private void LimitSalesForm_Load(object sender, EventArgs e)
        {
            id = SignInForm.idStatic;

            purchSymbols = dBAccess.getAllPurchLimitSymbols(id);
            foreach (string purchSymbol in purchSymbols)
            {
                purchDateTimes = dBAccess.getAllPurchLimitDateTimes(id, purchSymbol);
                foreach (DateTime purchDateTime in purchDateTimes)
                {
                    int purchShares = dBAccess.getPurchLimitShares(id, purchSymbol, purchDateTime);
                    decimal purchPrice = dBAccess.getPurchLimitPrice(id, purchSymbol, purchDateTime);
                    listLine = "";
                    listLine = "PURCHASE LIMIT ORDER";
                    limitOrdersListBox.Items.Add(listLine);
                    string strshares = purchShares.ToString();
                    string strprice = purchPrice.ToString();
                    string strPurchDateTime = purchDateTime.ToString();

                    listLine = "";
                    listLine = purchSymbol + " " + strshares + " " + strprice;
                    limitOrdersListBox.Items.Add(listLine);
                    listLine = "";
                    listLine = strPurchDateTime + " purchDateTime";
                    limitOrdersListBox.Items.Add(listLine);

                    List<decimal> priceList = dBAccess.getAllStockPrices(purchSymbol);
                    priceDateTimes = dBAccess.getStockPriceDateTimes(purchSymbol);
                    int index = -1;
                    bool exercise = false;
                    foreach (DateTime priceDateTime in priceDateTimes)
                    {
                        index = index + 1;
                        exercise = false;
                        if (priceDateTime > purchDateTime)
                        {
                            decimal stockPrice = priceList[index];

                            if (stockPrice <= purchPrice && exercise == false)
                            {
                                exercise = true;
                                // purchase limit order is exercised

                                portfolioShares = 0;
                                portfolioShares = dBAccess.getPortfolioShares(id, purchSymbol);
                                totShares = portfolioShares + purchShares;
                                if (totShares == purchShares)
                                {
                                    avgAcqPrice = purchPrice;
                                    dBAccess.addPortFolio(id, purchSymbol, totShares, avgAcqPrice);
                                    dBAccess.addStockPurchase
                                           (id, purchSymbol, purchDateTime, purchShares, purchPrice);
                                    dBAccess.deletePurchaseLimit(purchDateTime, id, purchSymbol);
                                }
                            else
                            {
                                avgAcqPrice = dBAccess.getPortfolioAvgAcqPrice(id, purchSymbol);
                                newAvgAcqPrice = ((avgAcqPrice * portfolioShares) +
                                        (purchPrice * purchShares)) / totShares;
                                avgAcqPrice = newAvgAcqPrice;
                                dBAccess.updatePortfolioAvgAcqPrice(id, purchSymbol, avgAcqPrice);
                                listLine = "";
                                listLine = "Purchase Limit Order Exercised";
                                limitOrdersListBox.Items.Add(listLine);
                                string strAvgAcqPrice = avgAcqPrice.ToString("c");
                                listLine = "";
                                listLine = "You have " + totShares + " of " +
                                        purchSymbol + " at avgAcqPrice of " + strAvgAcqPrice;
                                limitOrdersListBox.Items.Add(listLine);
                                dBAccess.addStockPurchase
                                        (id, purchSymbol, purchDateTime, purchShares, purchPrice);
                                dBAccess.deletePurchaseLimit(purchDateTime, id, purchSymbol);
                                dBAccess.updatePortfolioShares(id, purchSymbol, totShares);
                            }                               
                            }
                        }
                    }
                }
            }
            
        
            saleSymbols = dBAccess.getAllSaleLimitSymbols(id);
            foreach (string saleSymbol in saleSymbols)
            {
                saleDateTimes = dBAccess.getAllSaleLimitDateTimes(id, saleSymbol);
                foreach (DateTime saleDateTime in saleDateTimes)
                {
                    int saleShares = dBAccess.getSaleLimitShares(id, saleSymbol, saleDateTime);
                    decimal salePrice = dBAccess.getSaleLimitPrice(id, saleSymbol, saleDateTime);
                    listLine = "";
                    listLine = "SALE LIMIT ORDER";
                    limitOrdersListBox.Items.Add(listLine);
                    string strsshares = saleShares.ToString();
                    string strsprice = salePrice.ToString();
                    string strSaleDateTime = saleDateTime.ToString();
                    listLine = "";
                    listLine = saleSymbol + " " + strsshares + " " + strsprice;
                    limitOrdersListBox.Items.Add(listLine);
                    listLine = "";
                    listLine = strSaleDateTime + " saleDateTime";
                    limitOrdersListBox.Items.Add(listLine);

                    List<decimal> priceList = dBAccess.getAllStockPrices(saleSymbol);
                    priceDateTimes = dBAccess.getStockPriceDateTimes(saleSymbol);
                    int index = -1;
                    bool exercise = false;
                    foreach (DateTime priceDateTime in priceDateTimes)
                    {
                        index = index + 1;
                        if (priceDateTime > saleDateTime)
                        {
                            decimal stockPrice = priceList[index];
                            if (stockPrice >= salePrice && exercise == false)
                            {
                                exercise = true;
                                // exercise sale limit order

                                balance = dBAccess.getInvestorBalance(id);
                                balance = balance + (saleShares * salePrice);
                                dBAccess.updateInvestorBalance(id, balance);
                                dBAccess.addStockSale(id, saleSymbol, priceDateTime, saleShares, salePrice);
                                int shares = dBAccess.getPortfolioShares(id, saleSymbol);
                                decimal avgAcqPrice = dBAccess.getPortfolioAvgAcqPrice(id, saleSymbol);
                                listLine = "";
                                listLine = "Sale Limit Order Exercised";
                                limitOrdersListBox.Items.Add(listLine);
                                listLine = "";
                                listLine = "You now have " + shares + " of " + saleSymbol + " at avgAcqPrice of " + avgAcqPrice.ToString("c");
                                limitOrdersListBox.Items.Add(listLine);
                                dBAccess.deleteSaleLimit(saleDateTime, id, saleSymbol);
                            }
                        }
                    }
                }
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            DateTime purchDateTime = DateTime.Now;
            int id = SignInForm.idStatic;
            string symbol = symbolTextBox.Text;
            int purchShares = Int32.Parse(sharesTextBox.Text);
            decimal purchPrice = decimal.Parse(limitPriceTextBox.Text);

            balance = dBAccess.getInvestorBalance(id);
            balance = balance - (purchPrice * purchShares);
            if (balance < 0)
            {
                listLine = "";
                listLine = "Insufficient Balance, Purchase Limit Order Cancelled";
            }
            else
            {
                dBAccess.updateInvestorBalance(id, balance);
                dBAccess.addPurchaseLimit(purchDateTime, id, symbol, purchShares, purchPrice);
                string strprice = purchPrice.ToString();
                string strbalance = balance.ToString();
                listLine = "";
                listLine = "New Purchase Limit Order " + symbol + " " + purchShares.ToString()
                    + " @ price " + strprice + "New Balance = " + strbalance;
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            DateTime saleDateTime = DateTime.Now;
            int id = SignInForm.idStatic;
            string symbol = symbolTextBox.Text;
            int saleShares = Int32.Parse(sharesTextBox.Text);
            decimal price = decimal.Parse(limitPriceTextBox.Text);

            int portfolioShares = dBAccess.getPortfolioShares(id, symbol);
            portfolioShares = portfolioShares - saleShares;
            if (portfolioShares < 0)
            {
                listLine = "";
                listLine = "Insufficient Shares, Sale Limit Order Cancelled";

            }
            else
            {
                dBAccess.updatePortfolioShares(id, symbol, portfolioShares);
                dBAccess.addSaleLimit(saleDateTime, id, symbol, saleShares, price);
                listLine = "";
                listLine = "New Sale Limit Order " + symbol + " " + saleShares.ToString()
                    + " New Portfolio Shares = " + portfolioShares.ToString();

            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            int id = SignInForm.idStatic;
            string symbolEntered = symbolTextBox.Text;
            int sharesEntered = Int32.Parse(sharesTextBox.Text);
            purchSymbols = dBAccess.getAllPurchLimitSymbols(id);
            foreach (string purchSymbol in purchSymbols)
            {
                bool deleteFlag = false;
                purchDateTimes = dBAccess.getAllPurchLimitDateTimes(id, purchSymbol);
                foreach (DateTime purchDateTime in purchDateTimes)
                {
                    if (deleteFlag == false)
                    {
                        int purchShares = dBAccess.getPurchLimitShares(id, purchSymbol, purchDateTime);
                        decimal purchPrice = dBAccess.getPurchLimitPrice(id, purchSymbol, purchDateTime);

                        if (purchSymbol == symbolEntered && purchShares == sharesEntered)
                        {
                            balance = dBAccess.getInvestorBalance(id);
                            balance = balance + (purchPrice * purchShares);
                            dBAccess.updateInvestorBalance(id, balance);
                            dBAccess.deletePurchaseLimit(purchDateTime, id, purchSymbol);
                            listLine = "";
                            listLine = "Purchase Limit Order Deleted " + purchSymbol + " " + purchShares.ToString() + " shares";
                            deleteFlag = true;
                        }
                    }
                }
            }
            // delete sale limit order here
            saleSymbols = dBAccess.getAllSaleLimitSymbols(id);
            foreach (string saleSymbol in saleSymbols)
            {
                bool deleteFlag = false;
                saleDateTimes = dBAccess.getAllSaleLimitDateTimes(id, saleSymbol);
                foreach (DateTime saleDateTime in saleDateTimes)
                {
                    if (deleteFlag == false)
                    {
                        int saleShares = dBAccess.getSaleLimitShares(id, saleSymbol, saleDateTime);
                        decimal salePrice = dBAccess.getSaleLimitPrice(id, saleSymbol, saleDateTime);

                        if (saleSymbol == symbolEntered && saleShares == sharesEntered)
                        {
                            int portfolioShares = dBAccess.getPortfolioShares(id, saleSymbol);
                            portfolioShares = portfolioShares + saleShares;
                            dBAccess.updatePortfolioShares(id, saleSymbol, portfolioShares);
                            dBAccess.deleteSaleLimit(saleDateTime, id, saleSymbol);
                            listLine = "";
                            listLine = "Sale Limit Order Deleted " + saleSymbol + " " + saleShares.ToString() + " shares";
                            deleteFlag = true;
                        }
                    }
                }
            }
               
            // end deleteOrderButton here
        }
    }
}
    

