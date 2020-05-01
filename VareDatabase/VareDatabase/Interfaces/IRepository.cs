using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetEntities();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        //void Update(T entity); maybe?
        //void Save(); maybe?
    }
}
