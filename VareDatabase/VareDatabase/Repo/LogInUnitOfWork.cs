using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Interfaces;
using VareDatabase.DBContext;
using Microsoft.EntityFrameworkCore;

namespace VareDatabase.Repo
{
    public class LogInUnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; protected set; }
        public LogInUnitOfWork(/*LogInContext context*/)
        {
            //Context = context;
            //Bids = new BidOnItemRepository(Context); //example
        }
        //interfaces for all repositories that are relevant for auctions
        /*
         * public IBidOnItemRepository Bids { get; private set; } //example
         * CreateAuction
         * EditAuction
         * SearchForItem
         */
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
