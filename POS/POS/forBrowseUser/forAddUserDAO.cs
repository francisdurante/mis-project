using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.forBrowseUser
{
    class forAddUserDAO
    {
        public static frmBrowseUser browseUserListView { get; set; }
        public static frmAddUser cbInAddUser { get; set; }

        public static void toRetrieveUser()
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieveUser = new SqlCommand("SELECT * FROM dbo.UserInfo", cn.connect());
                SqlDataReader toRetrieveUserReader = toRetrieveUser.ExecuteReader();
                browseUserListView.lvUserList.Items.Clear();
                if (toRetrieveUserReader.HasRows)
                {
                    while (toRetrieveUserReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toRetrieveUserReader.GetInt32(0).ToString());
                        items.SubItems.Add(toRetrieveUserReader.GetValue(1).ToString());
                        items.SubItems.Add(toRetrieveUserReader.GetString(3));
                        items.SubItems.Add(toRetrieveUserReader.GetString(4));
                        items.SubItems.Add(toRetrieveUserReader.GetString(6));
                        items.SubItems.Add(toRetrieveUserReader.GetString(5));
                        browseUserListView.lvUserList.Items.Add(items);
                    }
                    toRetrieveUserReader.Close();
                    cn.connect().Close();
                }
                else
                {
                    MessageBox.Show("No Data Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.connect().Close();
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }

        public static void toSearchUser(string SearchCode)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSearchUser = new SqlCommand("SELECT * FROM dbo.UserInfo WHERE UserName LIKE @searchCode OR FullName LIKE @searchCode", cn.connect());
                toSearchUser.Parameters.AddWithValue("@searchCode", "%" + SearchCode + "%");
                SqlDataReader toSearchUserReader = toSearchUser.ExecuteReader();
                browseUserListView.lvUserList.Items.Clear();
                if (toSearchUserReader.HasRows)
                {
                    while (toSearchUserReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toSearchUserReader.GetInt32(0).ToString());
                        items.SubItems.Add(toSearchUserReader.GetValue(1).ToString());
                        items.SubItems.Add(toSearchUserReader.GetString(3));
                        items.SubItems.Add(toSearchUserReader.GetString(4));
                        items.SubItems.Add(toSearchUserReader.GetString(6));
                        items.SubItems.Add(toSearchUserReader.GetString(5));
                        browseUserListView.lvUserList.Items.Add(items);
                    }
                    toSearchUserReader.Close();
                    cn.connect().Close();
                }
                else
                {
                    toSearchUserReader.Close();
                    cn.connect().Close();
                    browseUserListView.lvUserList.Items.Clear();
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }

        public static void toSaveEditUser(int userName, string FullName, string Postion, string State, string Status, int Id)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSaveEdit = new SqlCommand("UPDATE dbo.UserInfo SET UserName = @userName, FullName = @fullName, Position = @position, State = @state, Status = @status, UpdateAt = @dateToday WHERE UserID = @id", cn.connect());
                toSaveEdit.Parameters.AddWithValue("@userName", userName);
                toSaveEdit.Parameters.AddWithValue("@fullName", FullName);
                toSaveEdit.Parameters.AddWithValue("@position", Postion);
                toSaveEdit.Parameters.AddWithValue("@state", State);
                toSaveEdit.Parameters.AddWithValue("@status", Status);
                toSaveEdit.Parameters.AddWithValue("@dateToday", DateTime.Now);
                toSaveEdit.Parameters.AddWithValue("@id", Id);
                toSaveEdit.ExecuteNonQuery();
                MessageBox.Show("One User Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }
        
        public static bool toSaveNewUser(int UserName, string Password, string FullName, string Postion, string State, string Status,int InsertedBy)
        {
            Connection cn = new Connection();
            try
            {
                if (!ifUserIsExisting(UserName))
                {
                    SqlCommand toSaveNew = new SqlCommand("INSERT INTO dbo.UserInfo(UserName,Password,FullName,Position,State,Status,CreatedBy,CreatedAt)"
                    + " VALUES (@userName,@password,@fullName,@position,@state,@status,@insertedBy,@dateToday)", cn.connect());
                    toSaveNew.Parameters.AddWithValue("@userName", UserName);
                    toSaveNew.Parameters.AddWithValue("@password", Cryptography.Encrypt(Password));
                    toSaveNew.Parameters.AddWithValue("@fullName", FullName);
                    toSaveNew.Parameters.AddWithValue("@position", Postion);
                    toSaveNew.Parameters.AddWithValue("@state", State);
                    toSaveNew.Parameters.AddWithValue("@status", Status);
                    toSaveNew.Parameters.AddWithValue("@insertedBy", InsertedBy);
                    toSaveNew.Parameters.AddWithValue("@dateToday", DateTime.Now);
                    toSaveNew.ExecuteNonQuery();
                    cn.connect().Close();
                    MessageBox.Show("One User Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("User ID Is Already Used!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static bool ifUserIsExisting(int UserName)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheck = new SqlCommand("SELECT * FROM dbo.UserInfo WHERE UserName = @userName", cn.connect());
                toCheck.Parameters.AddWithValue("@userName", UserName);
                SqlDataReader toCheckReader = toCheck.ExecuteReader();
                if (toCheckReader.HasRows)
                {
                    toCheckReader.Close();
                    cn.connect().Close();
                    return true;
                }
                else
                {
                    toCheckReader.Close();
                    cn.connect().Close();
                    return false;
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
                return false;
            }
        }

        public static void toDeleteUser(int id)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toDelete = new SqlCommand("DELETE FROM dbo.UserInfo WHERE UserID = @id", cn.connect());
                toDelete.Parameters.AddWithValue("@id", id);
                toDelete.ExecuteNonQuery();
                MessageBox.Show("One User Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toRetrieveUser();
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }
        public static void toRetrievePosition()
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieve = new SqlCommand("SELECT * FROM dbo.UserPosition", cn.connect());
                SqlDataReader toRetrieveReader = toRetrieve.ExecuteReader();
                cbInAddUser.cbPosition.Items.Clear();
                if (toRetrieveReader.HasRows)
                {
                    while (toRetrieveReader.Read())
                    {
                        cbInAddUser.cbPosition.Items.Add(toRetrieveReader.GetString(1));
                    }
                    toRetrieveReader.Close();
                    cn.connect().Close();
                }
                else
                {
                    toRetrieveReader.Close();
                    cn.connect().Close();
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }
    }
}
