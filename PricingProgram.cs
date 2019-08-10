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
    public partial class PricingProgram : Form
    {
        public PricingProgram()
        {
            InitializeComponent();
        }

        DBAccess dBAccess = new DBAccess();

        Random rand = new Random();

        private void pricingProgramButton_Click(object sender, EventArgs e)
        {
            List<string> symbols = new List<string>();

            symbols = dBAccess.getAllStockSymbols();
            foreach (string symbol in symbols)
            {
                
                List<decimal> priceList = dBAccess.getAllStockPrices(symbol);
                decimal price = priceList[priceList.Count - 1];

                // MessageBox.Show(price.ToString("c"), symbol);

                double dprice = (double)price;
                decimal highTarget = dBAccess.getBiasHighTarget(symbol);
                double dhigh = (double)highTarget;
                decimal lowTarget = dBAccess.getBiasLowTarget(symbol);
                double dlow = (double)lowTarget;
                double dnum = rand.NextDouble();
                double newdprice = dlow + (dnum * (dhigh - dlow));
               
                price = (decimal)newdprice;
                DateTime priceTime = DateTime.Now;
                dBAccess.addStockPrice(priceTime, price, symbol);

                double diff = newdprice - dprice;
                string strdprice = dprice.ToString("c");
                string strdhigh = dhigh.ToString("c");
                string strdlow = dlow.ToString("c");
                string strnewdprice = newdprice.ToString("c");
                string strdiff = diff.ToString("c");
                
                newPriceListBox.Items.Add(symbol+" "+strdprice+" "+strdhigh+"" +
                    " "+strdlow+" "+strnewdprice+" "+strdiff);
                // MessageBox.Show("New Price Calculated and Saved");
            }
        }
    }
}
