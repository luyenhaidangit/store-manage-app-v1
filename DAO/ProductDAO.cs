using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class ProductDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select p.Id,p.Name,p.Price,p.Quantity,p.ProductCategoryId,pc.Name AS ProductCategoryName from Products AS p INNER JOIN ProductCategories AS pc ON p.ProductCategoryId = pc.Id";
            return connect.GetData(sql);
        }

        public bool Add(Product obj)
        {
            try
            {
                string sql = string.Format("INSERT INTO Products VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", obj.Name, obj.Description, obj.Image, obj.Price, obj.Quantity, obj.ProductCategoryId);
                RunSQL(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public bool Edit(Product obj)
        {
            try
            {
                string sql = string.Format("update Products set Name = N'{0}', Description = N'{1}',Image = N'{2}',Price=N'{3}',Quantity=N'{4}',ProductCategoryId=N'{5}' WHERE IDStudent=N'{6}'", obj.Name, obj.Description, obj.Image, obj.Price, obj.Quantity, obj.ProductCategoryId, obj.Id);
                RunSQL(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                string sql = string.Format("Delete from Products WHERE Id = '" + id.Trim() + "'");
                RunSQL(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Search(string nameProduct, string nameProductCategory, decimal? startPriceSearch, decimal? endPriceSearch)
        {
            string sql = @"SELECT p.Id, p.Name, p.Price, p.Quantity, p.ProductCategoryId, pc.Name AS ProductCategoryName FROM Products AS p INNER JOIN ProductCategories AS pc ON p.ProductCategoryId = pc.Id WHERE 1=1";

            if (!string.IsNullOrEmpty(nameProduct))
            {
                sql += " AND p.Name LIKE N'%" + nameProduct + "%'";
            }

            if (!string.IsNullOrEmpty(nameProductCategory))
            {
                sql += " AND pc.Name LIKE N'%" + nameProductCategory + "%'";
            }

            if (startPriceSearch > 0)
            {
                sql += " AND p.Price >= " + startPriceSearch;
            }

            if (endPriceSearch > 0)
            {
                sql += " AND p.Price <= " + endPriceSearch;
            }

            return connect.GetData(sql);
        }

    }
}
