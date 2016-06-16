using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace Webdeveloper.DataAccess
{
    public class ClientData:BaseDataAccess<Client>
    {
        public Client getClientById(int id) {
            using (var dbcontext = new WebContextDb())
            {
                return dbcontext.Clients.FirstOrDefault(x => x.ID == id);
            }
                //return (Client)(this.GetList().Find(x => x.ID == id));
        }
    }
}
