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
    public partial class TestDB : Form
    {
        public TestDB()
        {
            InitializeComponent();
        }

        DBAccess dBAccess = new DBAccess();
        string listLine = "";
        List<string> symbols = new List<string>();
        List<DateTime> dateTimes = new List<DateTime>();

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 232;
                string symbol = "TRUS";
                dateTimes = dBAccess.getStockSaleDateTimes(id, symbol);
                foreach (DateTime dateTime in dateTimes)
                {
                    dBAccess.deleteStockSale(id, symbol, dateTime);
                }
                MessageBox.Show("TRUS 232 sales deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void testPriceButton_Click(object sender, EventArgs e)
        {
            string purchSymbol = "WWBM";
            List<decimal> priceList = dBAccess.getAllStockPrices(purchSymbol);
            List<DateTime> priceDateTimes = dBAccess.getStockPriceDateTimes(purchSymbol);
            int index = 0;
            foreach (DateTime priceDateTime in priceDateTimes)
            {
                //debug dateTimes
                /*int year = priceDateTime.Year;
                int month = priceDateTime.Month;
                int day = priceDateTime.Day;
                int hour = priceDateTime.Hour;
                int second = priceDateTime.Second;
                int millisecond = priceDateTime.Millisecond;
                string yr = year.ToString();
                string mo = month.ToString();
                string da = day.ToString();
                string hr = hour.ToString();
                string sc = second.ToString();
                string ms = millisecond.ToString();
                string listLine = "";
                listLine = yr + "/" + mo + "/" + da + " " + hr + ":" + sc + ":" + ms + " priceDateTime";*/
                string listLine = priceDateTime.ToString();
                limitOrdersListBox.Items.Add(listLine);
                //end debug dateTimes
                //decimal stockPrice = dBAccess.getStockPrice(priceDateTime);
                decimal stockPrice = priceList[index];
                listLine = "";
                listLine = "stockPrice = " + stockPrice.ToString("c");
                limitOrdersListBox.Items.Add(listLine);
                index = index + 1;
            }
        }

        private void testDupsButton_Click(object sender, EventArgs e)
        {
            int id = 232;
            symbols = dBAccess.getAllShortSaleSymbols(id);
            List<string> undupSymbols = new List<string>();
            string undupSymbol = "";
            int symbolCount = 0;
            foreach (string symbol in symbols)
            {
                bool dupSymbol = false;
                if (undupSymbol == symbol)
                {
                    dupSymbol = true;
                    symbolCount++;
                    MessageBox.Show("true " + symbolCount.ToString());
                }
                if (dupSymbol == false)
                {
                    if (symbolCount > 0)
                    {
                        MessageBox.Show("symbolCount = " + symbolCount.ToString());
                        if (symbolCount % 2 == 0)
                        {
                            listLine = undupSymbol + " short sale closed";
                            limitOrdersListBox.Items.Add(listLine);
                        }
                        else
                        {
                            listLine = undupSymbol + " short sale open";
                            limitOrdersListBox.Items.Add(listLine);
                        }
                    }
                    symbolCount = 0;
                    undupSymbol = symbol;
                    undupSymbols.Add(symbol);
                    symbolCount++;
                    MessageBox.Show("false " + symbolCount.ToString());
                    listLine = "undupSymbol = " + symbol;
                    limitOrdersListBox.Items.Add(listLine);         
                }
            }
            if (symbolCount > 0)
            {
                MessageBox.Show("symbolCount = " + symbolCount.ToString());
                if (symbolCount % 2 == 0)
                {
                    listLine = undupSymbol + " short sale closed";
                    limitOrdersListBox.Items.Add(listLine);
                }
                else
                {
                    listLine = undupSymbol + " short sale open";
                    limitOrdersListBox.Items.Add(listLine);
                }
            }
            foreach (string symbol in undupSymbols)
            {
                listLine = "symbol entry in undupSymbols is " + symbol;
                limitOrdersListBox.Items.Add(listLine);
            }
           
        }

        private void TestSQLnodupsButton_Click(object sender, EventArgs e)
        {
            int id = 232;
            List<string> testSymbols = dBAccess.getAllShortSaleSymbols(id);
            foreach (string testSymbol in testSymbols)
            {
                listLine = " undup symbol is " + testSymbol;
                limitOrdersListBox.Items.Add(listLine);
            }

            // SELECT DISTINCT does not work -- see AllShort... in pictures
        }
    }
}
