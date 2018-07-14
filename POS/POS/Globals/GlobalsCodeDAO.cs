using POS.foLogin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace POS.Globals
{
    class GlobalsCodeDAO
    {
       public static frmParameters parametersDetail { get; set; }
       public static frmAuditTrail auditTrailListView { get; set; }
        public static bool RetrieveConnectionString()
        {

            string readText = Cryptography.Decrypt(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\ConnectionString.txt"));
            if (readText.Equals(""))
            {
                return false;
            }
            else
            {
                String[] cs = readText.Split(';');
                String[] ip = cs[0].Split('=');
                String[] database = cs[1].Split('=');
                String[] user = cs[2].Split('=');
                String[] password = cs[3].Split('=');
                GlobalCodeVO.setServerIp = ip[1];
                GlobalCodeVO.setDatabaseName = database[1];
                GlobalCodeVO.setDatabaseUser = user[1];
                GlobalCodeVO.setDatabasePassword = password[1];
                return true;
            }
        }

        public static void  toSaveConnectionString(string serverIP, string databaseName, string databaseUser, string databasePassword)
        {
            try
            {
                TextWriter text = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\ConnectionString.txt");
                string cs = "Data Source=" + serverIP + ";Initial Catalog=" + databaseName + ";User ID=" + databaseUser + ";Password=" + databasePassword;
                string connectionString = Cryptography.Encrypt(cs);
                text.Write(connectionString);
                text.Close();
                MessageBox.Show("Connection String Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }

        public static int toTestConnection(string serverIP, string databaseName, string databaseUser, string databasePassword)
        {
            int connectionState = 0;
            SqlConnection cnn;
            cnn = new SqlConnection("Data Source = " + serverIP + "; Initial Catalog = " + databaseName + "; User ID = " + databaseUser + "; Password = " + databasePassword);
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    connectionState = 1;
                }
                else
                {
                    cnn.Close();
                    connectionState = 0;
                }
            }
            catch (Exception k)
            {
                cnn.Close();
                connectionState = 0;
            }
            cnn.Close();
            return connectionState;
        }

        public static bool toSaveInAuditTrail(string actions, string processBy, string loggedInUser, DateTime processDate, string actionField)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSaveAction = new SqlCommand("toSaveInAuditTrail", cn.connect());
                toSaveAction.CommandType = CommandType.StoredProcedure;
                toSaveAction.Parameters.AddWithValue("@actions", actions);
                toSaveAction.Parameters.AddWithValue("@processBy", processBy);
                toSaveAction.Parameters.AddWithValue("@loggedInUser", loggedInUser);
                toSaveAction.Parameters.AddWithValue("@processDate", processDate);
                toSaveAction.Parameters.AddWithValue("@actionField", actionField);
                int result = toSaveAction.ExecuteNonQuery();
                if(result > 0)
                {
                    cn.connect().Close();
                    return true;
                }
                else
                {
                    cn.connect().Close();
                    return false;
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
                return false;
            }
        }

        public static void toRetrieveParameters()
        {
            try
            {
                parametersDetail.txtCompanyName.Text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\CompanyName.txt");
                parametersDetail.txtCompanyAddress.Text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\CompanyAddress.txt");
                parametersDetail.txtBranch.Text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\Branch.txt");
                parametersDetail.txtBranchAddress.Text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\BranchAddress.txt");
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        public static void toSaveParameters()
        {
            try
            {
                TextWriter companyName = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\CompanyName.txt");
                TextWriter companyAddress = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\ComapnyAddress.txt");
                TextWriter branch = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Branch.txt");
                TextWriter branchAddress = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\BranchAddress.txt");
                companyName.Write(parametersDetail.txtCompanyName.Text);
                companyAddress.Write(parametersDetail.txtCompanyAddress.Text);
                branch.Write(parametersDetail.txtBranch.Text);
                branchAddress.Write(parametersDetail.txtBranchAddress.Text);
                companyName.Close();
                companyAddress.Close();
                branch.Close();
                branchAddress.Close();
                MessageBox.Show("Parameters Save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public static void toRetrieveAuditTrail(string search)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieve = new SqlCommand("SELECT * FROM dbo.AuditTrail WHERE ProcessBy LIKE @search ORDER BY AuditID DESC", cn.connect());
                toRetrieve.Parameters.AddWithValue("@search", "%"+ search + "%");
                SqlDataReader toRetrieveReader = toRetrieve.ExecuteReader();
                auditTrailListView.lvAuditTrail.Items.Clear();
                if (toRetrieveReader.HasRows)
                {
                    while (toRetrieveReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toRetrieveReader.GetInt32(0).ToString());
                        items.SubItems.Add(toRetrieveReader.GetString(1));
                        items.SubItems.Add(toRetrieveReader.GetString(2));
                        items.SubItems.Add(toRetrieveReader.GetString(3));
                        items.SubItems.Add(toRetrieveReader.GetValue(4).ToString());
                        auditTrailListView.lvAuditTrail.Items.Add(items);
                    }
                    cn.connect().Close();
                    toRetrieveReader.Close();
                }
                else
                {
                    cn.connect().Close();
                    toRetrieveReader.Close();
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }

        public static string toGenerateTransactionCode(int length)
        {
            string transactionCode = "";
            string r = "";
            Random random = new Random();
            for (int x = 0; x < length; x++)
            {
                r += random.Next(0, 9).ToString();
            }
            transactionCode = r;
            return transactionCode;
        }
        public static string ifExistingTransactionCode(string transactionCode)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheckTransactionCode = new SqlCommand("SELECT * FROM dbo.Transactions WHERE TransactionNumber = @transactionNumber", cn.connect());
                toCheckTransactionCode.Parameters.AddWithValue("@transactionNumber", transactionCode);
                SqlDataReader toCheckTransactionCodeReader = toCheckTransactionCode.ExecuteReader();
                if (!toCheckTransactionCodeReader.HasRows)
                {
                    return transactionCode;
                }
                else
                {
                    return ifExistingTransactionCode(toGenerateTransactionCode(12));
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
                return "";
            }
        }
        public static void toChangeState(string state)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toChangeState = new SqlCommand("UPDATE dbo.UserInfo SET State = @state WHERE UserID = @userID", cn.connect());
                toChangeState.Parameters.AddWithValue("@state", state);
                toChangeState.Parameters.AddWithValue("@userID", forLoginVO.getUserID);
                toChangeState.ExecuteNonQuery();
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }
    }
}