using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace VareDatabase.Interfaces.Auction
{
    public interface ICreateAuctionRepository : IRepository<ItemEntity>
    {
        void AddItem(int buyOut, int userId, int expire, string[] tags, string title, string drescription,
            string[] images);

        void AddImage(int itemId, string image);

        void AddTag(int itemId, string newTag);

    }
}

