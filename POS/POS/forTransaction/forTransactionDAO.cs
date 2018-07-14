using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.foLogin;

namespace POS.forTransaction
{
    class forTransactionDAO
    {
        public static int transactionID = 0;
        public static bool toRetrieveItem(string itemCode)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetreieveItemDetails = new SqlCommand("toRetrieveItemDetails", cn.connect());
                toRetreieveItemDetails.CommandType = CommandType.StoredProcedure;
                toRetreieveItemDetails.Parameters.AddWithValue("@itemCode", itemCode);
                SqlDataReader toRetreieveItemDetailsReader = toRetreieveItemDetails.ExecuteReader();
                if (toRetreieveItemDetailsReader.HasRows)
                {
                    while (toRetreieveItemDetailsReader.Read())
                    {
                        forTransactionVO.setItemName     = toRetreieveItemDetailsReader.GetString(2);
                        forTransactionVO.setPriceAt      = Convert.ToDouble(toRetreieveItemDetailsReader.GetValue(4));
                        forTransactionVO.setItemQuantity = Convert.ToInt32(toRetreieveItemDetailsReader["ItemQuantity"].ToString());
                    }
                    cn.connect().Close();
                    toRetreieveItemDetailsReader.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Item Code is not Save in Database\nPlease Contact Administrator!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.connect().Close();
                    return false;
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k+"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
                return false;
            }
        }

        public static bool toPostTransactionsGetTransactionID(string[] items, string transactionNumber, double totalAmount)
        {
            bool saved = false;
            Connection cn = new Connection();
            try
            {
                SqlCommand toSaveTransactions = new SqlCommand("dbo.toSaveInTransactions", cn.connect());
                toSaveTransactions.CommandType = CommandType.StoredProcedure;
                toSaveTransactions.Parameters.AddWithValue("@transactionNumber", transactionNumber);
                toSaveTransactions.Parameters.AddWithValue("@totalItemCount", items.Length);
                toSaveTransactions.Parameters.AddWithValue("@totalAmount", totalAmount);
                toSaveTransactions.Parameters.AddWithValue("@postedBy", forLoginVO.getUserID);

                SqlDataReader toSaveTransactionsReader = toSaveTransactions.ExecuteReader();
                while(toSaveTransactionsReader.Read())
                {
                    transactionID = Convert.ToInt32(toSaveTransactionsReader.GetValue(0));
                }
                if(transactionID != 0)
                {
                    saved = true;
                }
                cn.connect().Close();
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
                saved = false;
            }
            return saved;
        }
        public static bool toPostTransactionDetails(string[] itemsCode, int[] qty, double[] totalAmountPerItem)
        {
            bool transac = false;
            Connection cn = new Connection();
            try
            {
                for (int x = 0; x < itemsCode.Length; x++)
                {
                    SqlCommand toSaveInTransactionDetails = new SqlCommand("dbo.toSaveTransactionDetails", cn.connect());
                    toSaveInTransactionDetails.CommandType = CommandType.StoredProcedure;
                    toSaveInTransactionDetails.Parameters.AddWithValue("@itemCode", itemsCode[x]);
                    toSaveInTransactionDetails.Parameters.AddWithValue("@quantity", qty[x]);
                    toSaveInTransactionDetails.Parameters.AddWithValue("@totalAmount", totalAmountPerItem[x]);
                    toSaveInTransactionDetails.Parameters.AddWithValue("@transactionID", transactionID);
                    toSaveInTransactionDetails.ExecuteNonQuery();
                }
                transac = true;
                cn.connect().Close();
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
                transac = false;
            }
            return transac;
        }

        public static void toDeductInInventory(string[] itemCode, int[] qty)
        {
            int newQuantity = 0;
            Connection cn = new Connection();
            try
            {
                for (int x = 0; x < itemCode.Length; x++)
                {
                    SqlCommand currentQuantity = new SqlCommand("SELECT ItemQuantity FROM ItemList WHERE ItemCode = @itemCode", cn.connect());
                    currentQuantity.Parameters.AddWithValue("@itemCode", itemCode[x]);
                    SqlDataReader currentQuantityReader = currentQuantity.ExecuteReader();
                    while(currentQuantityReader.Read())
                    {
                        newQuantity = Convert.ToInt32(currentQuantityReader["ItemQuantity"].ToString()) - qty[x];
                    }
                    SqlCommand toUpdateQuantity = new SqlCommand("UPDATE ItemList SET ItemQuantity = @newQuantity WHERE ItemCode = @itemCode", cn.connect());
                    toUpdateQuantity.Parameters.AddWithValue("@newQuantity", newQuantity);
                    toUpdateQuantity.Parameters.AddWithValue("@itemCode", itemCode[x]);
                    toUpdateQuantity.ExecuteNonQuery();
                    cn.connect().Close();
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
            }
        }
    }
}
