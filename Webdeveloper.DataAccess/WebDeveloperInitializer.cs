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
        }
    }
}
