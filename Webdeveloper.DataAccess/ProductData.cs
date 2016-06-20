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
    }
}
