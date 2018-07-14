using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using POS.Globals;

namespace POS.forAddItem
{
    class forAddItemDAO
    {
        string currentItemName = "";
        int currentQty = 0;
        double currentPrice = 0.00;

        public static int toRetrieveItemCategory()
        {
            int response = 0;
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieveCategory = new SqlCommand("SELECT * FROM ItemCategory WHERE Status = 'ACTIVE'", cn.connect());
                SqlDataReader toRetrieveCategoryReader = toRetrieveCategory.ExecuteReader();
                if (!toRetrieveCategoryReader.HasRows)
                {
                    response = 2;
                }
                else
                {
                    forAddItemsVO.frmAddItemContent.cbCategory.Items.Add("");
                    while (toRetrieveCategoryReader.Read())
                    {
                        forAddItemsVO.frmAddItemContent.cbCategory.Items.Add(toRetrieveCategoryReader["CategoryName"]);
                    }
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
                response = 0;
            }
            cn.connect().Close();
            return response;
        }
        public static bool ExistingItem(string itemCode,int checking)
        {
            bool existing = false;
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheckIfExisting = new SqlCommand("SELECT * FROM ItemList WHERE ItemCode = @itemCode", cn.connect());
                toCheckIfExisting.Parameters.AddWithValue("@itemCode", itemCode);
                SqlDataReader toCheckIfExistingReader = toCheckIfExisting.ExecuteReader();
                if(toCheckIfExistingReader.HasRows)
                {
                    if (checking == 1)
                    {
                        while (toCheckIfExistingReader.Read())
                        {
                            forAddItemsVO.frmAddItemContent.cbCategory.Text = toCheckIfExistingReader["ItemCategory"].ToString();
                            forAddItemsVO.frmAddItemContent.txtItemName.Text = toCheckIfExistingReader["ItemName"].ToString();
                            forAddItemsVO.frmAddItemContent.txtItemPrice.Text = toCheckIfExistingReader["ItemPrice"].ToString();
                            forAddItemsVO.frmAddItemContent.txtQuantity.Text = toCheckIfExistingReader["ItemQuantity"].ToString();
                        }

                        existing = true;
                    }
                    if(checking == 2)
                    {
                        existing = true;
                    }
                }
                else
                {
                    forAddItemsVO.frmAddItemContent.cbCategory.Text = "";
                    forAddItemsVO.frmAddItemContent.txtItemName.Clear();
                    forAddItemsVO.frmAddItemContent.txtItemPrice.Clear();
                    forAddItemsVO.frmAddItemContent.txtQuantity.Clear();
                   
                    existing = false;
                }
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
                existing = false;
                cn.connect().Close();
            }
            cn.connect().Close();
            return existing;
        }
        public static void toAddItem(string itemCode, string itemName,string itemCategory, double price, int qty)
        {
            Connection cn = new Connection();
            try
            {
                if (ExistingItem(itemCode,2))
                {
                    SqlCommand toUpdateExistingItem = new SqlCommand("UPDATE ItemList SET ItemName = @itemName, ItemCategory = @itemCategory, ItemPrice = @itemPrice, ItemQuantity = @itemQty, UpdateAt = @date WHERE ItemCode = @itemCode", cn.connect());
                    toUpdateExistingItem.Parameters.AddWithValue("@itemName", itemName);
                    toUpdateExistingItem.Parameters.AddWithValue("@itemCategory", itemCategory);
                    toUpdateExistingItem.Parameters.AddWithValue("@itemPrice", price);
                    toUpdateExistingItem.Parameters.AddWithValue("@itemQty", qty);
                    toUpdateExistingItem.Parameters.AddWithValue("@date", DateTime.Now);
                    toUpdateExistingItem.Parameters.AddWithValue("@itemCode", itemCode);
                    toUpdateExistingItem.ExecuteNonQuery();
                    MessageBox.Show("One Item Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // GlobalsCodeDAO.toSaveInAuditTrail()
                    forAddItemsVO.frmAddItemContent.cbCategory.Text = "";
                    forAddItemsVO.frmAddItemContent.txtItemName.Clear();
                    forAddItemsVO.frmAddItemContent.txtItemPrice.Clear();
                    forAddItemsVO.frmAddItemContent.txtQuantity.Clear();
                    forAddItemsVO.frmAddItemContent.txtItemCode.Clear();
                }
                else
                {
                    SqlCommand toSaveNewItem = new SqlCommand("INSERT INTO ItemList(ItemCode,ItemName,ItemCategory,ItemPrice,ItemQuantity,CreatedAt) VALUES (@itemCode,@itemName,@itemCategory,@itemPrice,@itemQty,@date)", cn.connect());
                    toSaveNewItem.Parameters.AddWithValue("@itemCode", itemCode);
                    toSaveNewItem.Parameters.AddWithValue("@itemName", itemName);
                    toSaveNewItem.Parameters.AddWithValue("@itemCategory", itemCategory);
                    toSaveNewItem.Parameters.AddWithValue("@itemPrice", price);
                    toSaveNewItem.Parameters.AddWithValue("@itemQty", qty);
                    toSaveNewItem.Parameters.AddWithValue("@date", DateTime.Now);
                    toSaveNewItem.ExecuteNonQuery();
                    MessageBox.Show("One Item Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    forAddItemsVO.frmAddItemContent.cbCategory.Text = "";
                    forAddItemsVO.frmAddItemContent.txtItemName.Clear();
                    forAddItemsVO.frmAddItemContent.txtItemPrice.Clear();
                    forAddItemsVO.frmAddItemContent.txtQuantity.Clear();
                    forAddItemsVO.frmAddItemContent.txtItemCode.Clear();
                }
                cn.connect().Close();
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
            }
        }
    }
}
