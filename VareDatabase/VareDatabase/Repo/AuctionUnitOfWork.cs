using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Interfaces;
using VareDatabase.DBContext;
using Microsoft.EntityFrameworkCore;
using VareDatabase.Interfaces.Auction;

namespace VareDatabase.Repo
{
    public class AuctionUnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; protected set; }
        public AuctionUnitOfWork(VareDataModelContext context)
        {
            Context = context;
            Bids = new BidOnItemRepository((VareDataModelContext)Context); //example
            Auctions = new CreateAuctionRepository((VareDataModelContext)Context);
            Edits = new EditAuctionRepository((VareDataModelContext)Context);
            Searches = new SearchAuctionRepository((VareDataModelContext)Context);
        }
        //interfaces for all repositories that are relevant for auctions
        public IBidOnItemRepository Bids { get; private set; } //example
        public ICreateAuctionRepository Auctions { get; private set; }
        public IEditAuctionRepository Edits { get; private set; }
        public ISearchAuctionRepository Searches { get; private set; }
        public void Commit()
        {
            Context.SaveChanges();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
