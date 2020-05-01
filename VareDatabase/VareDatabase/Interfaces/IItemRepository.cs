using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase
{
    public interface IItemRepository
    {
        public void AddItem(int buyOut, int userId, int expire, string[] tags, string title, string description, string[] images);
        ItemEntity UpdateItem(int itemId); //getItem?
        void AddBid(int itemId, int bid, int userId);
        //this essentially sells the item or makes it unavailable if expired
        void SoftDeleteItem(int itemId);
        void EditItem(int itemId, int expire = 0, int buyOut = 0, string description = null);
        void AddTag(int itemId, string newTag);
        void RemoveTag(int itemId, string tagToRemove);
        void DeleteImage(int itemId, int imageId);
        void AddImage(int itemId, string image);
        void Search(string[] search);
    }
}
