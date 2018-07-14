using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.foLogin
{
    class forLoginDAO
    {
        public static void toRetrieveUsersInfo(int UserLoggedID)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieve = new SqlCommand("SELECT * FROM dbo.UserInfo WHERE UserName = @userName", cn.connect());
                toRetrieve.Parameters.AddWithValue("@userName", UserLoggedID);
                SqlDataReader toRetrieveReader = toRetrieve.ExecuteReader();
                if (toRetrieveReader.HasRows)
                {
                    while (toRetrieveReader.Read())
                    {
                        forLoginVO.setUserID        = Convert.ToInt32(toRetrieveReader.GetValue(0));
                        forLoginVO.setUserLoggedIn  = Convert.ToInt32(toRetrieveReader.GetValue(1));
                        forLoginVO.setPassword      = toRetrieveReader.GetString(2);
                        forLoginVO.setFullName      = toRetrieveReader.GetString(3);
                        forLoginVO.setPosition      = toRetrieveReader.GetString(4);
                        forLoginVO.setStatus        = toRetrieveReader.GetString(5);
                        forLoginVO.setState         = toRetrieveReader.GetString(6);
                    }
                    toRetrieveReader.Close();
                    cn.connect().Close();
                }
                else
                {
                    MessageBox.Show("User ID is Not Register!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.connect().Close();
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }
    }
}
