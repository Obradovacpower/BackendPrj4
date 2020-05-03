using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Interfaces;
using VareDatabase.Repo;
using VareDatabase.Repo.Auction;
using VareDatabase.Models;

namespace VareDatabase
{
    public class DatabaseLogic
    {
        private readonly IUnitOfWork unit;
        private readonly IItemRepository repo;
        //private ILoginRepository _loginRepo; //does not exist atm
        public DatabaseLogic(IUnitOfWork unit, IItemRepository repo)
        {
            this.unit = unit;
            this.repo = repo;
        }
        public void AddItem(ItemEntity item)
        {
            repo.Create(item);
            repo.GenerateTags(item);
            unit.Commit();
        }
        public void Delete(ItemEntity item)
        {
            repo.Delete(item);
        }

        public IEnumerable<ItemEntity> GetAll()
        {
            return repo.GetAll();
        }
        public ItemEntity GetSingle(int id)
        {
            return repo.Read(id);
        }
        public void Save()
        {
            unit.Commit(); 
        }
        public void AddTag(int id, string newTag)
        {
            repo.AddTag(id, newTag);
        }
        public IEnumerable<ItemEntity> Search(string searchingstring)
        {
            return repo.Search(searchingstring);
        }
    }
}
