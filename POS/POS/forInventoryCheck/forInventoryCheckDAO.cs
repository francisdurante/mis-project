using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.forInventoryCheck
{
    class forInventoryCheckDAO
    {
        public static void retrieveItem(string searchName)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieveItem = new SqlCommand("SELECT * FROM ItemList WHERE (ItemCode LIKE @search) OR (ItemName LIKE @search) OR (ItemCategory LIKE @search)", cn.connect());
                toRetrieveItem.Parameters.AddWithValue("@search", "%" + searchName + "%");
                SqlDataReader toRetrieveItemReader = toRetrieveItem.ExecuteReader();

                forInventoryCheckVO.frmInventoryCheckDetails.lvItemList.Items.Clear();
                while(toRetrieveItemReader.Read())
                {
                    ListViewItem item = new ListViewItem(toRetrieveItemReader["ItemCode"].ToString());
                    item.SubItems.Add(toRetrieveItemReader["ItemName"].ToString());
                    item.SubItems.Add(toRetrieveItemReader["ItemQuantity"].ToString());
                    item.SubItems.Add(toRetrieveItemReader["ItemCategory"].ToString());
                    forInventoryCheckVO.frmInventoryCheckDetails.lvItemList.Items.Add(item);
                }
                cn.connect().Close();
            }
            catch(Exception k)
            {

                cn.connect().Close();
            }
        }
    }
}
