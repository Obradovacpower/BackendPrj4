using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VareDatabase.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DBContext.VareDataModelContext db;
        //constructor
        public Repository(DBContext.VareDataModelContext db)
        {
            this.db = db;
        }
        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }
        public IEnumerable<T> GetEntities()
        {
            return db.Set<T>().ToList();
        }
        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
        }
        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
        }
    }
}
