using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using InventoryManagement.Models;

namespace Inventory.BL
{
    public class ProductBL
    {
        public List<ProductModel> GetAllProduct()
        {
            ConnectionModel cm = new ConnectionModel();
            List<ProductModel> listPM = null;
            var query = string.Format("select * from Products");

            SqlConnection conn = new SqlConnection(cm.connection);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                listPM = new List<ProductModel>();
                while(dr.Read())
                {
                    ProductModel pm = new ProductModel();
                    pm.ID = Convert.ToInt32(dr["ID"]);
                    pm.Name = Convert.ToString(dr["Name"]);
                    pm.Category = Convert.ToString(dr["Category"]);
                    pm.Color = Convert.ToString(dr["Color"]);
                    pm.UnitPrice = Convert.ToInt32(dr["UnitPrice"]);
                    pm.AvailableQuantity = Convert.ToInt32(dr["AvailableQuantity"]);

                    listPM.Add(pm);
                }
                listPM.TrimExcess();
            }
            return listPM;
        }
    }
}
