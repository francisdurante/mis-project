using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.forOverride
{
    class forOverrideDAO
    {
        public static bool toVoidItem(string userID, string password)
        {
            Connection cn = new Connection();
            forOverrideVO.setResultInOverride = false;
            try
            {
                SqlCommand toRetrieveUser = new SqlCommand("SELECT * FROM dbo.UserInfo WHERE UserName = @userID AND Password = @password", cn.connect());
                toRetrieveUser.Parameters.AddWithValue("@userID", userID);
                toRetrieveUser.Parameters.AddWithValue("@password", Cryptography.Encrypt(password));
                SqlDataReader toRetrieveUserReader = toRetrieveUser.ExecuteReader();
                if (toRetrieveUserReader.HasRows)
                {
                    toRetrieveUserReader.Close();
                    cn.connect().Close();
                    forOverrideVO.setResultInOverride = true;
                }
                else
                {
                    forOverrideVO.getResultInOverride = false;
                }
                return forOverrideVO.getResultInOverride;
            }
            catch(Exception k)
            {
                cn.connect().Close();
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public static string toGetPosition(string userId)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieveUser = new SqlCommand("SELECT * FROM dbo.UserInfo WHERE UserName = @userID", cn.connect());
                toRetrieveUser.Parameters.AddWithValue("@userID", userId);
                SqlDataReader toRetrieveUserReader = toRetrieveUser.ExecuteReader();
                if (toRetrieveUserReader.HasRows)
                {
                    while (toRetrieveUserReader.Read())
                    {
                        forOverrideVO.setPosition = toRetrieveUserReader.GetString(4);
                        forOverrideVO.setFullName = toRetrieveUserReader.GetString(3);
                    }
                    toRetrieveUserReader.Close();
                    cn.connect().Close();
                    return forOverrideVO.getPosition;
                }
                else
                {
                    toRetrieveUserReader.Close();
                    cn.connect().Close();
                    return "";
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
                return "";
            }
        }
    }
}
