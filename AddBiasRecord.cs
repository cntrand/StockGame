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
    public partial class AddBiasRecord : Form
    {
        DBAccess dBAccess = new DBAccess();

        public AddBiasRecord()
        {
            InitializeComponent();
        }

        private void addBiasButton_Click(object sender, EventArgs e)
        {
            string symbol = symbolTextBox.Text;
            decimal highTarget = decimal.Parse(highTargetTextBox.Text);
            decimal lowTarget = decimal.Parse(lowTargetTextBox.Text);
            dBAccess.addBias(symbol, highTarget, lowTarget);

            MessageBox.Show("Bias Record Added");

            symbolTextBox.Text = "";
            highTargetTextBox.Text = "";
            lowTargetTextBox.Text = "";
            symbolTextBox.Focus();

        }

        private void highTargetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lowTargetTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
