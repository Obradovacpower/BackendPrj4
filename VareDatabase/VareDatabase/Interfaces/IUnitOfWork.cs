using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VareDatabase.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        void Commit();
        //IRepository GetRepository();
    }
}
