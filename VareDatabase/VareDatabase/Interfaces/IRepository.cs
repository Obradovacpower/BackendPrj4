using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        TEntity Read(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
    }
}
