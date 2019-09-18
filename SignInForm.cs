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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        public static string emailStatic = null;
        public static int idStatic = -1;
        DBAccess dBAccess = new DBAccess();

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();

            createAccount.ShowDialog();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (checkCred())
            {
                MessageBox.Show("Logged in successfully");
                //SignInForm.ActiveForm.Close();
                clearTextBoxes();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect credentials");
            }
        }

        private void clearTextBoxes()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private bool checkCred()
        {
            String email = usernameTextBox.Text;
            String password = dBAccess.getInvestorPassword(email);
            String pw = null;

            if (password != null)
            {
                for (int i = 0; i < passwordTextBox.Text.Length; i++)
                {
                    pw += password.ToCharArray()[i].ToString();
                }

                if (pw == passwordTextBox.Text)
                {
                    emailStatic = email;
                    idStatic = dBAccess.getInvestorID(email);
                    return true;
                }
            }
            
            return false;
            
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            NewStockForm newStockForm = new NewStockForm();

            newStockForm.ShowDialog();
        }

        private void loadStockButton_Click(object sender, EventArgs e)
        {
            LoadStockForm loadStockForm = new LoadStockForm();
            loadStockForm.ShowDialog();
        }

        private void addBiasButton_Click(object sender, EventArgs e)
        {
            AddBiasRecord addBiasRecord = new AddBiasRecord();
            addBiasRecord.ShowDialog();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            PricingProgram pricingProgram = new PricingProgram();
            pricingProgram.ShowDialog();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            TestDB testDB = new TestDB();
            testDB.ShowDialog();
        }

        private void enterStoryButton_Click(object sender, EventArgs e)
        {
            NewsForm newsForm = new NewsForm();
            newsForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
