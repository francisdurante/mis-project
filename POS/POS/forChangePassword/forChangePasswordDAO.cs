using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.forChangePassword
{
    class forChangePasswordDAO
    {
        public static bool toChangePassword(string NewPassword, int UserID)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toChange = new SqlCommand("UPDATE dbo.UserInfo SET Password = @password WHERE UserName = @userName", cn.connect());
                toChange.Parameters.AddWithValue("@password", Cryptography.Encrypt(NewPassword));
                toChange.Parameters.AddWithValue("@userName", UserID);
                toChange.ExecuteNonQuery();
                return true;
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
                return false;
            }
        }
    }
}
