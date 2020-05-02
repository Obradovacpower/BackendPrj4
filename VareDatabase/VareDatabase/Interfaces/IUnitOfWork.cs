using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VareDatabase.Interfaces.Auction;

namespace VareDatabase.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }

        IBidOnItemRepository Bids();
        ICreateAuctionRepository Auctions();
        IEditAuctionRepository Edits();
        ISearchAuctionRepository Searches();
        void Commit();
        //IRepository GetRepository();
    }
}
