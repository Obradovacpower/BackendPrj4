using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase.Interfaces.Auction
{
    interface IEditAuctionRepository : IRepository<ItemEntity>
    {
        ItemEntity DeleteImage(int itemId, int imageId);
        ItemEntity EditItem(int itemId, int expire, int buyOut, string description);
        ItemEntity SoftDeleteItem(int itemId);
        ItemEntity RemoveTag(int itemId, string tagToRemove);
        ItemEntity GetItem(int itenId);

    }
}
