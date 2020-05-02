using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase.Interfaces.Auction
{
    public interface ISearchAuctionRepository : IRepository<ItemEntity>
    {
        public void search(string[] search);
        public List<ItemEntity> SearchByTag(string tag);
    }
}
