using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase
{
    public interface IRepository: IDisposable
    {
        IEnumerable<ItemEntity> GetItemEntities();
        ItemEntity GetItemById(int itemId);
        void InsertItem(ItemEntity itemEntity);
        void DeleteItem(int itemId);
        void UpdateItem(ItemEntity itemEntity);
        void Save();
    }
}
