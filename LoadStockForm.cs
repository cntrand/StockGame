using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StockGamePrototype1
{
    public partial class LoadStockForm : Form
    {
        DBAccess dBAccess = new DBAccess();

        public LoadStockForm()
        {
            InitializeComponent();
        }

        private void loadStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText(@"c:\users\edward\desktop\Company.txt");
                while (!inputFile.EndOfStream)
                {
                    string symbol = inputFile.ReadLine();
                    string name = inputFile.ReadLine();
                    string description = inputFile.ReadLine();
                    string sectorName = inputFile.ReadLine();
                    dBAccess.addStock(symbol, name, description, sectorName);
                    DateTime dateTime = DateTime.Now;
                    string stringPrice = inputFile.ReadLine();
                    decimal price = decimal.Parse(stringPrice);
                    dBAccess.addStockPrice(dateTime, price, symbol);
                    string signal = inputFile.ReadLine();
                }
                inputFile.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
