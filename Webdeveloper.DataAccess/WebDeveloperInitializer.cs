using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace Webdeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client { Name="Juan", LastName="Perez"},
                new Client { Name="Maria", LastName="Perez"},
                new Client { Name="Fabiola", LastName="Perez"},
                new Client { Name="Mirella", LastName="Perez"},
                new Client { Name="Almendra", LastName="Perez"}
            };

            clients.ForEach(c=> context.Clients.Add(c));
            context.SaveChanges();

            var Product = new List<Product>
            {
                new Product { Code="GT20161", Description="Galleta Soda", PriceCost=0.4f,PriceSale=0.6f,Amount=25,DateRegister=DateTime.Now,DateExpiration=DateTime.Now,Active=true},
                new Product { Code="GT20162", Description="Galleta Vainilla", PriceCost=0.4f,PriceSale=0.6f,Amount=25,DateRegister=DateTime.Now,DateExpiration=DateTime.Now,Active=true},
                new Product { Code="GT20163", Description="Galleta Club Social", PriceCost=0.6f,PriceSale=0.7f,Amount=25,DateRegister=DateTime.Now,DateExpiration=DateTime.Now,Active=true},
            };
            Product.ForEach(c => context.Products.Add(c));
            context.SaveChanges();
        }
    }
}
