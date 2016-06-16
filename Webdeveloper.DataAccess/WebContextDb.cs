using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace Webdeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {

        //ctor -> tab -tab : genera el constructor de la clase
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
        }

        public DbSet<Client> Clients { get; set; }

        //Elimina la extension 'es' en la creacion de nombres de los DbContext
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        
    }
}
