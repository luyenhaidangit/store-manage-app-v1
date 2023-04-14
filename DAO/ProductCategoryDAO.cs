using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProductCategoryDAO : DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from ProductCategories";
            return connect.GetData(sql);
        }

        public bool Add(ProductCategory obj)
        {
            try
            {
                string sql = string.Format("INSERT INTO ProductCategories VALUES (N'{0}',N'{1}')", obj.Name, obj.Description);
                RunSQL(sql);
                return true;
            }catch(Exception ex)
            {
                throw ex;
            } 
        }

        public bool Edit(ProductCategory obj)
        {
            try
            {
                string sql = string.Format("update ProductCategories set Name = N'{0}', Description = N'{1}' WHERE Id=N'{2}'", obj.Name, obj.Description, obj.Id);
                RunSQL(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                string sql = "Delete from ProductCategories WHERE ID = '" + id + "'";
                RunSQL(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Search(string name)
        {
            string sql = "select * FROM ProductCategories WHERE Name Is Null Or Name like N'%" + name + "%'";
            return connect.GetData(sql);
        }
    }
}
