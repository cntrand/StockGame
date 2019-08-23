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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CreateAccountForm.ActiveForm.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int check = 0;

            check = addInvestor();

            if (check == 1)
            {
                CreateAccountForm.ActiveForm.Close();
            }
        }

        /*
         * addInvestor()
         * This method creates a new investor
         * and adds it to the database
        */
        private int addInvestor()
        {
            Random rand = new Random();
            int id = rand.Next(1000);
            String name = nameTextBox.Text;
            String email = emailTextBox.Text;
            int balance = 100000;
            String password = null;

            /*
            * This if-else statement checks the passwords entered in the
            * two boxes(enterPassword & reEnterPassword)
            */
            if (createPWTextBox.Text == reenterPWTextBox.Text)
            {
                password = createPWTextBox.Text;
            }
            else
            {
                MessageBox.Show("Passwords don't match, please re-enter your password");
                return 0;
            }

            string sql = "INSERT Investor(ID, Balance, Name, Email, Password) VALUES ";
            sql = sql + "(" + id + ", " + balance +", '" + name + "', '" + email + "', '" + password + "')";

            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Edward\Desktop\StockGamePrototype1\StockGamePrototype1\Database1.mdf;Integrated Security=True";
            //String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StockGame-master\StockGamePrototype1\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Account created " + name);

            return 1;
        }

    }
}
