using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace Webdeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public Product getProductById(int id)
        {
            using (var dbDataContext = new WebContextDb())
            {
                return dbDataContext.Products.FirstOrDefault(x => x.ID == id);
            }
        }

        public List<Product> GetFakeProducts() {
            List<Product> list = new List<Product>()
            {
                new Product() { ID=1,Description="Cristal", PriceSale=3.5f,DateExpiration=null},
                new Product() { ID=1,Description="Pilsen", PriceSale=0f,DateExpiration = DateTime.Now },
                new Product() { ID=1,Description="Cuzqueña", PriceSale=0f, DateExpiration=null},
                new Product() { ID=1,Description="Coca Cola", PriceSale=2.0f, DateExpiration=null},
                new Product() { ID=1,Description="Inka Kola", PriceSale=1.5f, DateExpiration=DateTime.Now},
                new Product() { ID=1,Description="Pepsi", PriceSale=0f, DateExpiration=DateTime.Now},
            };
            return list;
        }
    }
}
