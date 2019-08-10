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
    public partial class NewsStories : Form
    {
        DBAccess dBAccess = new DBAccess();
        DateTime dateTime = new DateTime();
        string symbol = "";
        List<string> headlines = new List<string>();
        List<string> stories = new List<string>();
        public static int newsIndexStatic = 0;

        public NewsStories()
        {
            InitializeComponent();
        }

        private void headlineButton_Click(object sender, EventArgs e)
        {
            NewsUpdate newsUpdate = new NewsUpdate();
            newsUpdate.ShowDialog();
        }

        private void headlineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stories = dBAccess.getNewsStories(symbol);
            storyLabel.Text = stories[headlineListBox.SelectedIndex];
            newsIndexStatic = headlineListBox.SelectedIndex;

        }

        private void NewsStories_Load(object sender, EventArgs e)
        {
            symbol = NewsForm.symbolStatic;
            symbolTextBox.Text = symbol;
            headlines = dBAccess.getNewsHeadLines(symbol);
            foreach (string headline in headlines)
            {
                headlineListBox.Items.Add(headline);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
