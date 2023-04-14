using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductCategoryBUS
    {
        public ProductCategoryDAO productCategoryDAO = new ProductCategoryDAO();

        public DataTable GetData()
        {
            return productCategoryDAO.GetData();
        }

        public bool Add(ProductCategory obj)
        {
            return productCategoryDAO.Add(obj);
        }

        public bool Edit(ProductCategory obj)
        {
            return productCategoryDAO.Edit(obj);
        }

        public bool Delete(int id)
        {
            return productCategoryDAO.Delete(id);
        }

        public DataTable Search(string name)
        {
            return productCategoryDAO.Search(name);
        }
    }
}
