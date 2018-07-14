using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.forItemLists
{
    
    class forItemListDAO
    {
        public static frmItemList itemListListView { get; set; }

        public static void toRetrieveItems()
        {
            Connection cn = new Connection();

            try
            {
                SqlCommand toRetreieveItemDetails = new SqlCommand("SELECT * FROM dbo.ItemList", cn.connect());
                SqlDataReader toRetreieveItemDetailsReader = toRetreieveItemDetails.ExecuteReader();
                itemListListView.lvListView.Items.Clear();
                if (toRetreieveItemDetailsReader.HasRows)
                {
                    while (toRetreieveItemDetailsReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toRetreieveItemDetailsReader.GetValue(0).ToString());
                        items.SubItems.Add(toRetreieveItemDetailsReader.GetString(1));
                        items.SubItems.Add(toRetreieveItemDetailsReader.GetString(2));
                        items.SubItems.Add(toRetreieveItemDetailsReader.GetString(3));
                        items.SubItems.Add(toRetreieveItemDetailsReader.GetValue(4).ToString());
                        itemListListView.lvListView.Items.Add(items);
                    }
                    toRetreieveItemDetailsReader.Close();
                    cn.connect().Close();
                }
                else
                {
                    MessageBox.Show("No Items In Database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toRetreieveItemDetailsReader.Close();
                    cn.connect().Close();
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
            }
        }

        public static void toSearchItem(string ItemName)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSearch = new SqlCommand("SELECT * FROM dbo.ItemList WHERE ItemName LIKE @itemName", cn.connect());
                toSearch.Parameters.AddWithValue("@itemName", "%" + ItemName + "%");
                SqlDataReader toSearchReader = toSearch.ExecuteReader();
                itemListListView.lvListView.Items.Clear();
                if (toSearchReader.HasRows)
                {
                    while (toSearchReader.Read())
                    {
                        ListViewItem items = new ListViewItem(toSearchReader.GetValue(0).ToString());
                        items.SubItems.Add(toSearchReader.GetString(1));
                        items.SubItems.Add(toSearchReader.GetString(2));
                        items.SubItems.Add(toSearchReader.GetString(3));
                        items.SubItems.Add(toSearchReader.GetValue(4).ToString());
                        itemListListView.lvListView.Items.Add(items);
                    }
                    toSearchReader.Close();
                    cn.connect().Close();
                }
                else
                {
                    toSearchReader.Close();
                    cn.connect().Close();
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.connect().Close();
            }
        }

        
    }
}
