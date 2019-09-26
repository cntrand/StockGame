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
    class DBAccess
    {
        //String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Edward\Desktop\StockGamePrototype1\StockGamePrototype1\Database1.mdf;Integrated Security=True";
        String connectionString = @"Server=tcp:mysqlserver5701.database.windows.net,1433;Initial Catalog=stockDatabase;Persist Security Info=False;User ID=vgutierrez542;Password=BlueMan48;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private string cutString(String fullString)
        {
            char c;
            string temp = null;

            for(int i=0; i<fullString.Length; i++)
            {
                c = fullString.ToCharArray()[i];
                if (c != ' ')
                {
                    temp += c.ToString();
                }
                else
                {
                    return temp;
                }
            }

            return temp;
        }

        /********************** STOCK DATABASE ACCESS *************************/
        public string getStockName(string symbol)
        {
            string stockName = null;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Stock where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    stockName = reader[1].ToString();
                }
            }
            sqlConnection.Close();

            return stockName;
        }

        public string getStockDescription(string symbol)
        {
            string stockDescription = null;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Stock where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    stockDescription = reader[2].ToString();
                }
            }
            sqlConnection.Close();

            // return cutString(compDesc);
            return stockDescription;
        }

        public string getStockSector(string symbol)
        {
            string sector = null;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Stock where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    sector = reader[3].ToString();
                }
            }
            sqlConnection.Close();

            //return cutString(sector);
            return sector;
        }

        public void updateStockName(string symbol, string name)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE Stock SET name=@name WHERE Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock Name updated");
        }

        public void updateStockDescription(string symbol, string description)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE Stock SET description=@description WHERE Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock Description updated");
        }

        public void updateStockSector(string symbol, string sector)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE Stock SET sector=@sector WHERE symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@sector", sector);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock Sector updated");
        }

        public List<string> getAllStockSymbols()
        {
            List<string> stockSyms = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Stock";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            //cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    stockSyms.Add(cutString(reader[0].ToString()));
                }
            }
            sqlConnection.Close();

            return stockSyms;
        }

        public void addStock(string symbol, string name, string description, string sector)
        {
            string sql = "INSERT Stock(Symbol, Name, Description, Sector) VALUES ";
            sql += "(@symbol, @name, @description, @sector)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@sector", sector);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock created");
        }

        public void deleteStock(string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM Stock WHERE Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock "+ symbol +" deleted");
        }

        /******************* INVESTOR DATABASE ACCESS ************************/
        public int getInvestorID(string email)
        {
            int id = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select ID from Investor where Email=@email";

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
                    id = (int)reader[0];
                }
            }
            sqlConnection.Close();

            return id;
        }

        public string getInvestorPassword(string email)
        {
            string password = null;

             System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select Password from Investor where Email=@email";

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
                    password = reader[0].ToString();
                }
            }

            sqlConnection.Close();
            return password;
        }

        public decimal getInvestorBalance(int id)
        {
            decimal balance = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Investor where ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    balance = (decimal)reader[1];
                }
            }
            sqlConnection.Close();

            return balance;
        }

        public void updateInvestorBalance(int id, decimal newBalance)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE Investor SET Balance=@balance WHERE ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@balance", newBalance);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Balance updated");
        }

        public string getInvestorName(int id)
        {
            string name = null;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Investor where ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    name = reader[2].ToString();
                }
            }
            sqlConnection.Close();

            return name;
        }
         
        public void deleteInvestor(int id)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM Investor WHERE ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Investor with id " + id + " deleted");
        }

        public void createInvestor(int id, string name, string email, int balance, string password){
            string sql = "INSERT Investor(ID, Balance, Name, Email, Password) VALUES ";
            sql = sql + "(" + id + ", " + balance +", '" + name + "', '" + email + "', '" + password + "')";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql; 
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Account created " + name);
        }

        /****************** PORTFOLIO DATABASE ACCESS ************************/
        public List<string> getAllPortfolioSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Portfolio where ID=@id order by Symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[1].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }

        public List<int> getAllPortfolioIds(string symbol)
        {
            List<int> ids = new List<int>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Portfolio where Symbol = @symbol  order by ID";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ids.Add((int)reader[0]);
                }
            }
            sqlConnection.Close();

            return ids;
        }

        public int getPortfolioShares(int id, string symbol)
        {
            int shares = 0;
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Portfolio where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    shares = (int)reader[2];
                }
            }
            sqlConnection.Close();
            return shares;
        }

        public void updatePortfolioShares(int id, string symbol, int shares)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE Portfolio SET shares=@shares ";
            sql += "WHERE Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@shares", shares);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Shares updated " + shares.ToString());
        }

        public decimal getPortfolioAvgAcqPrice(int id, string symbol)
        {

            decimal avgAcqPrice = 0.0m;
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Portfolio where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    avgAcqPrice= (decimal)reader[3];
                }
            }
            sqlConnection.Close();

            return avgAcqPrice;
        }

        public void updatePortfolioAvgAcqPrice(int id, string symbol, decimal avgAcqPrice)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE Portfolio SET AvgAcqPrice=@avgAcqPrice ";
            sql += "WHERE Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@avgAcqPrice", avgAcqPrice);
            
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("avgAcqPrice updated " + avgAcqPrice.ToString("c4"));
        }

        public void addPortFolio(int id, string symbol, int shares, decimal avgAcqPrice)
        {
            string sql = "INSERT Portfolio(ID, Symbol, Shares, AvgAcqPrice) VALUES ";
            sql += "(@id, @symbol, @shares, @avgAcqPrice)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@shares", shares);
            cmd.Parameters.AddWithValue("@avgAcqPrice", avgAcqPrice);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Portfolio created");
        }

        public void deletePortfolio(int id, string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM Portfolio WHERE ID=@id AND Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Portfolio deleted");
        }

        /**********************NEWS DATABASE ACCESS**************************/
        public List<string> getNewsStories(string Symbol)
        {
            List<string> newsStories = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from News where Symbol = @symbol order by DateTime";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol",Symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    newsStories.Add((string)reader[3]);
                }
            }
            sqlConnection.Close();

            return newsStories;
        }

        public List<string> getNewsHeadLines(string Symbol)
        {
            List<string> newsHeadLines = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from News where Symbol = @symbol order by DateTime";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", Symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    newsHeadLines.Add((string)reader[2]);
                }
            }
            sqlConnection.Close();

            return newsHeadLines;
        }

        public List<DateTime> getNewsDateTimes(string symbol)
        {
            List<DateTime> newsDateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from News where Symbol=@symbol order by DateTime";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                    while(reader.Read())
                {
                    newsDateTimes.Add((DateTime)reader[1]);
                }
            }
            sqlConnection.Close();

            return newsDateTimes;
        }

        public void updateNewsStory(string symbol, DateTime dateTime, string text)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE News SET text=@text WHERE symbol=@symbol AND dateTime = @dateTime";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@text", text);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("newsStory updated");
        }

        public void updateNewsHeadline(string symbol, DateTime dateTime, string headline)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "UPDATE News SET headline=@headline WHERE symbol=@symbol AND dateTime = @dateTime";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@headline", headline);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("newsHeadline updated");
        }


        public void addNews(string symbol, DateTime dateTime, string headline, string text)
        {
            string sql = "INSERT News(Symbol, DateTime, Headline, Text) VALUES ";
            sql += "(@symbol, @dateTime, @headline, @text)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@headline", headline);
            cmd.Parameters.AddWithValue("@text", text);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("News created");
        }

        public void deleteNews(string Symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM News WHERE Symbol = @symbol" ;

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", Symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("News deleted");
        }

        /**********************PURCHASE LIMIT DATABASE ACCESS**************************/
        public List<string> getAllPurchLimitSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from PurchaseLimit where ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[2].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }
        
        public List<DateTime> getAllPurchLimitDateTimes(int id, string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from PurchaseLimit where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[0]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }
        
        public int getPurchLimitShares(int id, string symbol, DateTime dateTime)
        {
            int shares = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from PurchaseLimit where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    shares = (int)reader[3];
                }
            }
            sqlConnection.Close();

            return shares;
        }
        
        public decimal getPurchLimitPrice(int id, string symbol, DateTime dateTime)
        {
            decimal price = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from PurchaseLimit where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (decimal)reader[4];
                }
            }
            sqlConnection.Close();

            return price;
        }

        public void addPurchaseLimit(DateTime dateTime, int id, string symbol, int shares, decimal price)
        {
            string sql = "INSERT PurchaseLimit(DateTime, ID, Symbol, shares, price) VALUES ";
            sql += "(@dateTime, @id, @symbol, @shares, @price)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shares", shares);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("PurchaseLimit created");
        }

        public void deletePurchaseLimit(DateTime dateTime, int id, string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM PurchaseLimit WHERE DateTime=@dateTime AND Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);

            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Purchase Limit deleted");
        }
        
        /**********************SALE LIMIT DATABASE ACCESS**************************/
        public List<DateTime> getAllSaleLimitDateTimes(int id, string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from SaleLimit where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);

            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[0]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }
        
        public List<string> getAllSaleLimitSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from SaleLimit where ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[2].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }
        
        public int getSaleLimitShares(int id, string symbol, DateTime dateTime)
        {
            int shares = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from SaleLimit where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);

            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    shares = (int)reader[3];
                }
            }
            sqlConnection.Close();

            return shares;
        }

        public decimal getSaleLimitPrice(int id, string symbol, DateTime dateTime)
        {
            decimal price = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from SaleLimit where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (decimal)reader[4];
                }
            }
            sqlConnection.Close();

            return price;
        }

        public void addSaleLimit(DateTime dateTime, int id, string symbol, int shares, decimal price)
        {
            string sql = "INSERT SaleLimit(DateTime, ID, Symbol, shares, price) VALUES ";
            sql += "(@dateTime, @id, @symbol, @shares, @price)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shares", shares);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("SaleLimit created");
        }

        public void deleteSaleLimit(DateTime dateTime, int id, string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM SaleLimit WHERE DateTime=@dateTime AND Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Sale Limit deleted");
        }

        /**********************SHORT SALE DATABASE ACCESS**************************/
        public List<DateTime> getAllShortSaleDateTimes(int id, string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSale where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[0]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }

        public List<string> getAllShortSaleSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = 
                new System.Data.SqlClient.SqlConnection(connectionString);
            string sql = "SELECT * from ShortSale where id=@id order by Symbol";
            // string sql = "SELECT DISTINCT Symbol from ShortSale where id=@id order by Symbol";

            System.Data.SqlClient.SqlCommand cmd =
                new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add((string)reader[2]);
                }
            }
            sqlConnection.Close();

            return symbols;
        }

        public List<string> getShortSaleSymbol(int id, string symbol)
        {
            List<string> symbolList = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSale where ID=@id and Symbol = @symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbolList.Add(cutString(reader[2].ToString()));
                }
            }
            sqlConnection.Close();

            return symbolList;
        }

        public int getShortSaleShares(DateTime dateTime,int id, string symbol)
        {
            int shares = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSale where DateTime=@dateTime and ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    shares = (int)reader[3];
                }
            }
            sqlConnection.Close();

            return shares;
        }

        public decimal getShortSalePrice(DateTime dateTime, int id, string symbol)
        {
            decimal price = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSale where DateTime=@dateTime and ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);

            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (decimal)reader[4];
                }
            }
            sqlConnection.Close();

            return price;
        }

        public void addShortSale(DateTime dateTime, int id, string symbol, int shares, decimal price)
        {
            string sql = "INSERT ShortSale(DateTime, ID, Symbol, Shares, Price) VALUES ";
            sql += "(@dateTime, @id, @symbol, @shares, @price)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shares", shares);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("ShortSale created");
        }

        public void deleteShortSale(DateTime dateTime, int id, string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM ShortSale WHERE DateTime=@dateTime AND Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);


            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Short Sale deleted");
        }

        /********************** SHORT SALE LIMIT ORDER DATABASE ACCESS**************************/
        public List<string> getAllShortSaleLimitOrderSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSaleLimitOrder where ID=@id order by Symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[2].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }

        public List<DateTime> getShortSaleLimitOrderDateTimes(int id, string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSaleLimitOrder where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[0]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }

        public decimal getShortSaleLimitOrderLowPrice(DateTime dateTime, int id, string symbol)
        {
            decimal lowPrice = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSaleLimitOrder where DateTime=@dateTime and ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);

            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    lowPrice = (decimal)reader[3];
                }
            }
            sqlConnection.Close();

            return lowPrice;
        }

        public decimal getShortSaleLimitOrderHighPrice(DateTime dateTime, int id, string symbol)
        {
            decimal highPrice = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from ShortSaleLimitOrder where DateTime=@dateTime and ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);

            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    highPrice = (decimal)reader[4];
                }
            }
            sqlConnection.Close();

            return highPrice;
        }


        public void addShortSaleLimitOrder(DateTime dateTime, int id, string symbol, decimal lowPrice, decimal highPrice)
        {
            string sql = "INSERT ShortSaleLimitOrder(DateTime, ID, Symbol, LowPrice, HighPrice) VALUES ";
            sql += "(@dateTime, @id, @symbol, @lowPrice, @highPrice)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@lowPrice", lowPrice);
            cmd.Parameters.AddWithValue("@highPrice", highPrice);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("ShortSaleLimitOrder created");
        }

        public void deleteShortSaleLimitOrder(DateTime dateTime, int id, string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM ShortSaleLimitOrder WHERE DateTime=@dateTime AND Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("ShortSaleLimitOrder deleted");
        }

        /**********************WATCH LIST DATABASE ACCESS**************************/
        public List<string> getAllWatchListSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from WatchList where ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[1].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }

        public void addWatchList(int id, string symbol)
        {
            string sql = "INSERT WatchList(ID, Symbol) VALUES ";
            sql += "(@id, @symbol)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("WatchList created");
        }

        public void deleteWatchList(int id, string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM WatchList WHERE Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Watch List deleted");
        }

        /**********************STOCK PURCHASE DATABASE ACCESS**************************/
        public int getStockPurchaseShares(int id, string symbol, DateTime dateTime)
        {
            int shares = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockPurchase where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    shares = (int)reader[3];
                }
            }
            sqlConnection.Close();

            return shares;
        }

        public decimal getStockPurchasePrice(int id, string symbol, DateTime dateTime)
        {
            decimal price = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockPurchase where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (decimal)reader[4];
                }
            }
            sqlConnection.Close();

            return price;
        }

        public List<string> getAllStockPurchaseSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockPurchase where ID=@id order by Symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[1].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }

        public List<DateTime> getStockPurchaseDateTimes(int id, string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockPurchase where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[2]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }

        public void addStockPurchase(int id, string symbol, DateTime dateTime, int Shares, decimal price)
        {
            string sql = "INSERT StockPurchase(ID, Symbol, DateTime, Shares, Price) VALUES ";
            sql += "(@id, @symbol, @dateTime, @Shares, @price)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Shares", Shares);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock Purchase created");
        }

        public void deleteStockPurchase(int id, string symbol, DateTime dateTime)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM StockPurchase WHERE DateTime=@dateTime AND Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock Purchase deleted");
        }

        /**********************STOCK SALE DATABASE ACCESS**************************/
        public int getStockSaleShares(int id, string symbol, DateTime dateTime)
        {
            int shares = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockSale where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    shares = (int)reader[3];
                }
            }
            sqlConnection.Close();

            return shares;
        }

        public decimal getStockSalePrice(int id, string symbol, DateTime dateTime)
        {
            decimal price = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockSale where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (decimal)reader[4];
                }
            }
            sqlConnection.Close();

            return price;
        }

        public List<string> getAllStockSaleSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockSale where ID=@id order by Symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[1].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }

        public List<DateTime> getStockSaleDateTimes(int id, string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockSale where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[2]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }

        public void addStockSale(int id, string symbol, DateTime dateTime, int Shares, decimal price)
        {
            string sql = "INSERT StockSale(ID, Symbol, DateTime, Shares, Price) VALUES ";
            sql += "(@id, @symbol, @dateTime, @Shares, @price)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Shares", Shares);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock Sale created");
        }

        public void deleteStockSale(int id, string symbol, DateTime dateTime)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM StockSale WHERE DateTime=@dateTime AND Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Stock Sale deleted");
        }

        /**********************STOCK PRICE DATABASE ACCESS**************************/
 
        public List<decimal> getAllStockPrices(string symbol)
        {
            List<decimal> prices = new List<decimal>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            string sql = "Select * from StockPrice where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    prices.Add((decimal)reader[1]);
                }
            }

            sqlConnection.Close();

            return prices;
        }

        public List<DateTime> getStockPriceDateTimes(string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockPrice where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[0]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }

        public void addStockPrice (DateTime dateTime, decimal price, string symbol)
        {
            string sql = "INSERT StockPrice(DateTime, Price, Symbol) VALUES ";
            sql += "(@dateTime, @price, @symbol)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@symbol", symbol);

            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            // MessageBox.Show("Stock Price created");
        }

        public void deleteStockPrice(string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM StockPrice WHERE Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            // MessageBox.Show("Stock Price deleted");
        }


        /**********************STOCK HISTORY DATABASE ACCESS**************************/
        public decimal getStockHistoryPrice(string symbol)
        {
            decimal price = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockHistory where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (decimal)reader[2];
                }
            }
            sqlConnection.Close();

            return price;
        }

        public List<DateTime> getStockHistoryDateTimes(string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from StockPrice where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[1]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }

        public void addStockHistory(string symbol, DateTime dateTime, decimal price)
        {
            string sql = "INSERT StockHistory(Symbol, DateTime, Price) VALUES ";
            sql += "(@symbol, @dateTime, @price)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            // MessageBox.Show("Stock History Price created");
        }

        public void deleteStockHistory(string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM StockPrice WHERE Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }

        /**********************DIVIDEND DATABASE ACCESS**************************/
        public decimal getDividendPerShare(string symbol)
        {
            decimal dividend = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Dividend where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dividend = (decimal)reader[2];
                }
            }
            sqlConnection.Close();

            return dividend;
        }

        public decimal getEarningsPerShare(string symbol)
        {
            decimal earnings = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Dividend where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    earnings = (decimal)reader[3];
                }
            }
            sqlConnection.Close();

            return earnings;
        }

        public decimal getRevenuePerShare(string symbol)
        {
            decimal revenue = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Dividend where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    revenue = (decimal)reader[4];
                }
            }
            sqlConnection.Close();

            return revenue;
        }

        public DateTime getDividendDateTime(string symbol)
        {
            DateTime dateTime = new DateTime();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Dividend where Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dateTime = (DateTime)reader[1];
                }
            }
            sqlConnection.Close();

            return dateTime;
        }

        public void addDividend(string symbol, DateTime dateTime, decimal dividendPerShare,
                               decimal earningsPerShare, decimal revenuePerShare)
        {
            string sql = "INSERT Dividend(Symbol, DateTime, DividendPerShare, EarningsPerShare, RevenuePerShare) VALUES ";
            sql += "(@symbol, @dateTime, @dividendPerShare, @earningsPerShare, @revenuePerShare)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@dividendPerShare", dividendPerShare);
            cmd.Parameters.AddWithValue("@earningsPerShare", earningsPerShare);
            cmd.Parameters.AddWithValue("@revenuePerShare", revenuePerShare);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Dividend created");
        }

        public void deleteDividend(string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM Dividend WHERE Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Dividend deleted");
        }

        /**********************INVESTOR DIVIDEND DATABASE ACCESS**************************/
        public List<string> getAllInvestorDividendSymbols(int id)
        {
            List<string> symbols = new List<string>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from InvestorDividend where ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    symbols.Add(cutString(reader[1].ToString()));
                }
            }
            sqlConnection.Close();

            return symbols;
        }

        public List<DateTime> getInvestorDividendDateTimes(int id, string symbol)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from InvestorDividend where ID=@id and Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateTimes.Add((DateTime)reader[2]);
                }
            }
            sqlConnection.Close();

            return dateTimes;
        }

        public decimal getInvestorDividend(int id, string symbol, DateTime dateTime)
        {
            decimal dividend = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from InvestorDividend where DateTime=@dateTime and Symbol=@symbol and ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dividend = (int)reader[3];
                }
            }
            sqlConnection.Close();

            return dividend;
        }

        public void addInvestorDividend(int id, string symbol, DateTime dateTime, decimal investorDividend)
        {
            string sql = "INSERT InvestorDividend(ID, Symbol, DateTime, InvestorDividend) VALUES ";
            sql += "(@id, @symbol, @dateTime, @price)";

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@price", investorDividend);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Investor Dividend created");
        }

        public void deleteInvestorDividend(int id, string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM InvestorDividend WHERE Symbol=@symbol AND ID=@id";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Investor Dividend deleted");
        }

        /**********************BIAS DATABASE ACCESS**************************/
        public decimal getBiasHighTarget(string symbol)
        {
            decimal highTarget = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Bias where Symbol = @symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    highTarget = (decimal)reader[1];
                }
            }
            sqlConnection.Close();

            return highTarget;
        }

        public decimal getBiasLowTarget(string symbol)
        {
            decimal lowTarget = -1;

            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "Select * from Bias where Symbol = @symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    lowTarget = (decimal)reader[2];
                }
            }
            sqlConnection.Close();

            return lowTarget;
        }

        public void updateBiasHighTarget(string symbol, decimal highTarget, decimal lowTarget)
        {
            string sql = "UPDATE Bias SET HighTarget = @highTarget";
            sql += "WHERE Symbol = @symbol";

            System.Data.SqlClient.SqlConnection sqlConnection =
                new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@highTarget", highTarget);
            cmd.Parameters.AddWithValue("@lowTarget", lowTarget);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Bias Record High Target Updated");
        }

        public void updateBiasLowTarget(string symbol, decimal highTarget, decimal lowTarget)
        {
            string sql = "UPDATE Bias SET LowTarget = @lowTarget";
            sql += "WHERE Symbol = @symbol";

            System.Data.SqlClient.SqlConnection sqlConnection =
                new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Parameters.AddWithValue("@highTarget", highTarget);
            cmd.Parameters.AddWithValue("@lowTarget", lowTarget);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Bias Record Low Target Updated");
        }

        public void addBias(string Symbol, decimal HighTarget, decimal LowTarget)
        {
            string sql = "INSERT Bias(Symbol, HighTarget, LowTarget) VALUES";
            sql += "(@symbol, @highTarget, @lowTarget)";

            System.Data.SqlClient.SqlConnection sqlConnection =
                new System.Data.SqlClient.SqlConnection(connectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", Symbol);
            cmd.Parameters.AddWithValue("@highTarget", HighTarget);
            cmd.Parameters.AddWithValue("@lowTarget", LowTarget);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("New Bias Record Created");
        }

        public void deleteBias(string symbol)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            //TODO: sql string
            string sql = "DELETE FROM Bias WHERE Symbol=@symbol";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@symbol", symbol);
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Bias deleted");
        }


    }
}
