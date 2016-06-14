using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace Webdeveloper.DataAccess
{
    public class ClientData
    {
        public List<Client> GetList()
        {
            //using crea un objeto y cuando termina de utilizarse lo destruye
            using (var dbcontext = new WebContextDb())
            {
                return dbcontext.Clients.ToList();
            }
        }
        public List<Client> GetFakeData()
        {
            return new List<Client> {
               new Client { ID=1,Name="Juan",LastName="Perez"},
               new Client { ID=2,Name="Raul",LastName="Ruidiaz"}
            };
        }
    }
}
