using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.forBrowsePosition
{
    class forBrowsePositionDAO
    {
        public static frmBrowsePosition browsePositionListView;

        public static void toRetrievePosition()
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieve = new SqlCommand("SELECT * FROM dbo.UserPosition", cn.connect());
                SqlDataReader toRetrieveReader = toRetrieve.ExecuteReader();
                browsePositionListView.lvPosition.Items.Clear();
                if (toRetrieveReader.HasRows)
                {
                    while (toRetrieveReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toRetrieveReader.GetInt32(0).ToString());
                        items.SubItems.Add(toRetrieveReader.GetString(1));
                        items.SubItems.Add(toRetrieveReader.GetString(2));
                        items.SubItems.Add(toRetrieveReader.GetInt32(3).ToString());
                        items.SubItems.Add(toRetrieveReader.GetValue(4).ToString());
                        browsePositionListView.lvPosition.Items.Add(items);
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
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }

        public static void toSaveNewPosition(string Position, string Status, int createdBy)
        {
            Connection cn = new Connection();
            try
            {
                if (!ifPositionIsExisting(Position))
                {
                    SqlCommand toSave = new SqlCommand("INSERT INTO dbo.UserPosition(PositionName,PositionStatus,CreatedBy)"
                    + " VALUES(@position,@status,@createdBy)", cn.connect());
                    toSave.Parameters.AddWithValue("@position", Position);
                    toSave.Parameters.AddWithValue("@status", Status);
                    toSave.Parameters.AddWithValue("@createdBy", createdBy);
                    toSave.ExecuteNonQuery();
                    MessageBox.Show("One Position Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.connect().Close();
                    toRetrievePosition();
                }
                
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }

        public static bool ifPositionIsExisting(string Position)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheck = new SqlCommand("SELECT * FROM dbo.UserPosition WHERE PositionName = @position", cn.connect());
                toCheck.Parameters.AddWithValue("@position", Position);
                SqlDataReader toCheckReader = toCheck.ExecuteReader();
                if (toCheckReader.HasRows)
                {
                    MessageBox.Show("The Position is Already in Database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.connect().Close();
                    toCheckReader.Close();
                    return true;
                }
                else
                {
                    cn.connect().Close();
                    toCheckReader.Close();
                    return false;
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
                return false;
            }
        }
        public static bool toSaveEditPosition(string Position, string Status,int id)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSaveEdit = new SqlCommand("UPDATE dbo.UserPosition SET PositionName = @position, PositionStatus = @status, UpdateAt = @dateNow WHERE UserPositionID = @id", cn.connect());
                toSaveEdit.Parameters.AddWithValue("@position", Position);
                toSaveEdit.Parameters.AddWithValue("@status", Status);
                toSaveEdit.Parameters.AddWithValue("@dateNow", DateTime.Now);
                toSaveEdit.Parameters.AddWithValue("@id", id);
                toSaveEdit.ExecuteNonQuery();
                cn.connect().Close();
                MessageBox.Show("One Position Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toRetrievePosition();
                return true;
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
                return false;
            }
        }
        public static void toDeletePosition(int id)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toDelete = new SqlCommand("DELETE FROM dbo.UserPosition WHERE UserPositionID = @id", cn.connect());
                toDelete.Parameters.AddWithValue("@id", id);
                toDelete.ExecuteNonQuery();
                MessageBox.Show("One Position Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
                toRetrievePosition();
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }
        public static void toSearchPosition(string Position)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSearch = new SqlCommand("SELECT * FROM dbo.UserPosition WHERE PositionName LIKE @position", cn.connect());
                toSearch.Parameters.AddWithValue("@position", "%" + Position + "%");
                SqlDataReader toSearchReader = toSearch.ExecuteReader();
                browsePositionListView.lvPosition.Items.Clear();
                if (toSearchReader.HasRows)
                {
                    while (toSearchReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toSearchReader.GetInt32(0).ToString());
                        items.SubItems.Add(toSearchReader.GetString(1));
                        items.SubItems.Add(toSearchReader.GetString(2));
                        items.SubItems.Add(toSearchReader.GetInt32(3).ToString());
                        items.SubItems.Add(toSearchReader.GetValue(4).ToString());
                        browsePositionListView.lvPosition.Items.Add(items);
                    }
                
                    cn.connect().Close();
                    toSearchReader.Close();
                }
                else
                {
                    cn.connect().Close();
                    toSearchReader.Close();
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
