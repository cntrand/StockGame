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
            String password = getPassword(email);
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

        private String getPassword(string email)
        {
            String password = null;

            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Edward\Desktop\StockGamePrototype1\StockGamePrototype1\Database1.mdf;Integrated Security=True";
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            String sql = "Select * from Investor where Email=@email";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    password = reader[4].ToString();
                }
            }

            sqlConnection.Close();
            return password;
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
