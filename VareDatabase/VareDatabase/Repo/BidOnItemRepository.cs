using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.DBContext;
using VareDatabase.Models;

namespace VareDatabase.Repo
{
    public class BidOnItemRepository
    {

        private VareDataModelContext db;

        public BidOnItemRepository(VareDataModelContext db)
        {
            this.db = db;
        }

        public void AddBid(int itemId, int bid, int userId)
        {
            ItemEntity item = db.Set<ItemEntity>().Find(itemId);
            if (item != null)
            {
                foreach (BidEntity b in item.Bids)
                {
                    if (b.Bid >= bid)
                    {
                        return;
                    }
                }
                item.Bids.Add(new BidEntity
                {
                    Bid = bid,
                    UserIdBuyer = userId
                });
            }
        }
    }
}
