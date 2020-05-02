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
        public VareDataModelContext Context { get; protected set; }
        public AuctionUnitOfWork(VareDataModelContext context)
        {
            Context = context;
        }
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
