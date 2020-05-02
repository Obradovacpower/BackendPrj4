using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase.Interfaces
{
    public interface IItemRepository : IRepository<ItemEntity>
    {
        IEnumerable<ItemEntity> Search(string searchString);
        void GenerateTags(ItemEntity item);
        void AddTag(int id, string newTag);
    }
}
