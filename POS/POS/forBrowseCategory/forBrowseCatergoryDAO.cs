using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.forBrowseCategory
{
    class forBrowseCatergoryDAO
    {
        public static frmBrowseCategory browseCatergoryListView { get; set; }

        public static void toRetrieveCategory(string Category)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieve = new SqlCommand("SELECT * FROM dbo.ItemCategory WHERE CategoryName LIKE @category", cn.connect());
                toRetrieve.Parameters.AddWithValue("@category", "%" + Category + "%");
                SqlDataReader toRetrieveReader = toRetrieve.ExecuteReader();
                browseCatergoryListView.lvCategory.Items.Clear();
                if (toRetrieveReader.HasRows)
                {
                    while (toRetrieveReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toRetrieveReader.GetInt32(0).ToString());
                        items.SubItems.Add(toRetrieveReader.GetString(1));
                        items.SubItems.Add(toRetrieveReader.GetString(2));
                        items.SubItems.Add(toRetrieveReader.GetInt32(3).ToString());
                        items.SubItems.Add(toRetrieveReader.GetValue(4).ToString());
                        browseCatergoryListView.lvCategory.Items.Add(items);
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

        public static void toRetrieveCategory()
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieve = new SqlCommand("SELECT * FROM dbo.ItemCategory", cn.connect());
                SqlDataReader toRetrieveReader = toRetrieve.ExecuteReader();
                browseCatergoryListView.lvCategory.Items.Clear();
                if (toRetrieveReader.HasRows)
                {
                    while (toRetrieveReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toRetrieveReader.GetInt32(0).ToString());
                        items.SubItems.Add(toRetrieveReader.GetString(1));
                        items.SubItems.Add(toRetrieveReader.GetString(2));
                        items.SubItems.Add(toRetrieveReader.GetInt32(3).ToString());
                        items.SubItems.Add(toRetrieveReader.GetValue(4).ToString());
                        browseCatergoryListView.lvCategory.Items.Add(items);
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

        public static void toSaveNewCategory(string Category, int InsertBy)
        {
            Connection cn = new Connection();
            try
            {
                if (ifCategoryIsNotExisting(Category))
                {
                    SqlCommand toSaveNew = new SqlCommand("INSERT INTO dbo.ItemCategory(CategoryName,CreatedBy) VALUES(@category,@createdBy)", cn.connect());
                    toSaveNew.Parameters.AddWithValue("@category", Category);
                    toSaveNew.Parameters.AddWithValue("@createdBy", InsertBy);
                    toSaveNew.ExecuteNonQuery();
                    MessageBox.Show("One Category Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.connect().Close();
                    toRetrieveCategory();
                    
                }
                else
                {
                    MessageBox.Show("The Category Is Already in Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.connect().Close();
                }
               
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }

        public static bool ifCategoryIsNotExisting(string Category)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheckIfExisting = new SqlCommand("SELECT * FROM dbo.ItemCategory WHERE CategoryName = @category", cn.connect());
                toCheckIfExisting.Parameters.AddWithValue("@category", Category);
                SqlDataReader toCheckIfExistingReader = toCheckIfExisting.ExecuteReader();
                if (!toCheckIfExistingReader.HasRows)
                {
                    cn.connect().Close();
                    toCheckIfExistingReader.Close();
                    return true;
                }
                else
                {
                    cn.connect().Close();
                    toCheckIfExistingReader.Close();
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

        public static bool toSaveEditCategory(int id,string Category, string Status)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSaveEdit = new SqlCommand("UPDATE dbo.ItemCategory SET CategoryName = @category, Status = @status, UpdateAt = @dateNow WHERE CategoryID = @id", cn.connect());
                toSaveEdit.Parameters.AddWithValue("@category", Category);
                toSaveEdit.Parameters.AddWithValue("@status", Status);
                toSaveEdit.Parameters.AddWithValue("@dateNow", DateTime.Now);
                toSaveEdit.Parameters.AddWithValue("@id", id);
                toSaveEdit.ExecuteNonQuery();
                MessageBox.Show("One Category Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
                toRetrieveCategory();
                return true;
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
                return false;
            }
        }

        public static void toDeleteCategory(int id)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toDelete = new SqlCommand("DELETE FROM dbo.ItemCategory WHERE CategoryID = @id", cn.connect());
                toDelete.Parameters.AddWithValue("@id", id);
                toDelete.ExecuteNonQuery();
                MessageBox.Show("One Item Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
                toRetrieveCategory();
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.connect().Close();
            }
        }
    }
}
