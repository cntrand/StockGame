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
    public partial class NewStockForm : Form
    {
        DBAccess dBAccess = new DBAccess();

        string symbol = "";
        string sector = "";
        string name = "";
        string description = "";
        decimal price = 0.0m;
        decimal high = 0.0m;
        decimal low = 0.0m;

        public NewStockForm()
        {
            InitializeComponent();
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            try
            {

                symbol = symbolTextBox.Text;
                name = null;
                name = dBAccess.getStockName(symbol);
                if (name == null)
                {
                    sector = sectorTextBox.Text;
                    name = nameTextBox.Text;
                    description = descriptionTextBox.Text;

                    dBAccess.addStock(symbol, name, description, sector);

                    price = decimal.Parse(priceTextBox.Text);
                    low = decimal.Parse(lowTextBox.Text);
                    high = decimal.Parse(highTextBox.Text);
                    DateTime priceTime = DateTime.Now;
                    dBAccess.addStockPrice(priceTime, price, symbol);
                    dBAccess.addBias(symbol, high, low);
                    ClearTextBoxes();
                }
                else
                {
                    nameTextBox.Text = name;
                    sector = dBAccess.getStockSector(symbol);
                    sectorTextBox.Text = sector;
                    description = dBAccess.getStockDescription(symbol);
                    descriptionTextBox.Text = description;
                    List<decimal> priceList = dBAccess.getAllStockPrices(symbol);
                    price = priceList[priceList.Count - 1];
                    priceTextBox.Text = price.ToString();
                    high = dBAccess.getBiasHighTarget(symbol);
                    highTextBox.Text = high.ToString();
                    low = dBAccess.getBiasLowTarget(symbol);
                    lowTextBox.Text = low.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void deleteStockButton_Click(object sender, EventArgs e)
        {
            // This routine is incomplete until price records and bias record
            // associated with this symbol are deleted.

            string symbol = symbolTextBox.Text;

            dBAccess.deleteStock(symbol);
        }

        private void ClearTextBoxes()
        {
            symbolTextBox.Text = "";
            sectorTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            priceTextBox.Text = "";
            highTextBox.Text = "";
            lowTextBox.Text = "";
            symbolTextBox.Focus();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            sector = sectorTextBox.Text;
            description = descriptionTextBox.Text;
            dBAccess.updateStockName(symbol, name);
            dBAccess.updateStockSector(symbol, sector);
            dBAccess.updateStockDescription(symbol, description);
        }
    }
}
