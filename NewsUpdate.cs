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
    public partial class NewsUpdate : Form
    {
        DBAccess dBAccess = new DBAccess();
        List<string> headlines = new List<string>();
        List<string> stories = new List<string>();
        string symbol = null;

        public NewsUpdate()
        {
            InitializeComponent();
        }

        private void NewsUpdate_Load(object sender, EventArgs e)
        {
            symbol = NewsForm.symbolStatic;
            symbolLabel.Text = symbol;
            headlines = dBAccess.getNewsHeadLines(symbol);
            headlineTextBox.Text = headlines[NewsStories.newsIndexStatic];
            stories = dBAccess.getNewsStories(symbol);
            storyTextBox.Text = stories[NewsStories.newsIndexStatic];

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            List<DateTime> dateTimes = dBAccess.getNewsDateTimes(symbol);
            DateTime dateTime = dateTimes[NewsStories.newsIndexStatic];
            string headline = headlineTextBox.Text;
            string story = storyTextBox.Text;
            dBAccess.updateNewsHeadline(symbol, dateTime, headline);
            dBAccess.updateNewsStory(symbol, dateTime, story);

            /*int i = 0;
            for (i = 0; i < Application.OpenForms.Count; ++i)
            {
                if (Application.OpenForms[i] != this)
                {
                    Application.OpenForms[i].Close();
                }
            }*/

            int i = Application.OpenForms.Count - 1;
            Application.OpenForms[i].Close();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
