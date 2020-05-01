using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.DBContext;
using VareDatabase.Repo;
using VareDatabase.Models;


namespace VareDatabase.Interfaces.Auction
{
    public interface IBidOnItemRepository : IRepository<BidEntity>
    {
        void AddBid(int itemId, int bid, int user);
    }
}
