using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class ProductBUS
    {
        public ProductDAO productDAO = new ProductDAO();

        public DataTable GetData()
        {
            return productDAO.GetData();
        }

        public bool Add(Product obj)
        {
            return productDAO.Add(obj);
        }

        public bool Edit(Product obj)
        {
            return productDAO.Edit(obj);
        }

        public bool Delete(string id)
        {
            return productDAO.Delete(id);
        }

        public DataTable Search(string nameProduct,string nameProductCategory,decimal? startPriceSearch,decimal? endPriceSearch)
        {
            return productDAO.Search(nameProduct, nameProductCategory, startPriceSearch, endPriceSearch);
        }
    }
}
