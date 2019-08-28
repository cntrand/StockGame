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
        DBAccess dBAccess = new DBAccess();

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

            dBAccess.createInvestor(id, name, email, balance, password);

            return 1;
        }

    }
}
