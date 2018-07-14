using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace POS
{
    class Connection
    {
        SqlConnection cnn;
        public SqlConnection connect()
        {
            try
            {
                string readText = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\ConnectionString.txt");
                string connectionString = null;
                connectionString = Cryptography.Decrypt(readText);
                cnn = new SqlConnection(connectionString);
                cnn.Open();
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message + "Connections");
                cnn.Close();
            }
            return cnn;
        }
    }
}
