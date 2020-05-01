using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase.Interfaces.Auction
{
    public interface IEditAuctionRepository : IRepository<ItemEntity>
    {
        public void DeleteImage(int itemId, int imageId);
        public void EditItem(int itemId, int expire, int buyOut, string description);
        public void SoftDeleteItem(int itemId);
        public void RemoveTag(int itemId, string tagToRemove);
        public ItemEntity GetItem(int itemId);

    }
}
