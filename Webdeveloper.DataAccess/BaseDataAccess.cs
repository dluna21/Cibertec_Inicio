using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Webdeveloper.DataAccess
{
    public class BaseDataAccess<T> : IDataAccess<T> where T: class
    {
        public int Add(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Added;
                return dbContext.SaveChanges();
            }
            //termina el using y se realiza un dispose para liberar la memoria.
        }

        public int Delete(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                return dbContext.SaveChanges();
            }
        }

        public List<T> GetList()
        {
            using (var dbContext = new WebContextDb()) {
                return dbContext.Set<T>().ToList();
            }
        }

        public int Update(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                return dbContext.SaveChanges();
            }
        }
    }
}
