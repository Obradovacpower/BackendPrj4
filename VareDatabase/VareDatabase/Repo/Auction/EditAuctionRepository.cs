using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.DBContext;
using VareDatabase.Models;
using VareDatabase.Interfaces.Auction;

namespace VareDatabase.Repo
{
    public class EditAuctionRepository : Repository<ItemEntity>, IEditAuctionRepository
    {
        private VareDataModelContext db;
        public EditAuctionRepository(VareDataModelContext db) : base(db)
        {
            this.db = db;
        }
        //delete image
        public void DeleteImage(int itemId, int imageId)
        {
            //make sure atleast one image is on the item
            ItemEntity item = db.Set<ItemEntity>().ToList().First(x => (x.ItemId == itemId));
            if (item != null && item.Tags.Count > 1)
            {
                foreach (ImageEntity img in item.Images)
                {
                    if (img.Id == imageId)
                    {
                        item.Images.Remove(img);
                        break;
                    }
                }
                //if we get here no image was found with that id
            }
        }
        //edit item
        public void EditItem(int itemId, int expire = 0, int buyOut = 0, string description = null)
        {
            ItemEntity item = db.Set<ItemEntity>().ToList().First(x => x.ItemId == itemId);
            if (item == null)
            {
                //make sure we find an item
                return;
            }
            //DateTime.Compare(itemToFind.Expiration, DateTime.Now) >= 0
            if (expire > 0 && item.Bids == null && item.ExpirationDate < DateTime.Now) //make sure no bids are made and is after current date
            {
                item.ExpirationDate.AddDays(expire);
            }
            if ((buyOut < item.BuyOutPrice && buyOut > 0) && item.ExpirationDate < DateTime.Now)
            {
                item.BuyOutPrice = buyOut;
            }
            if (description != null)
            {
                item.DescriptionOfItem = description;
            }
        }
        //softDeleteItem
        public void SoftDeleteItem(int itemId)
        {
            var items = db.Set<ItemEntity>().ToList();
            ItemEntity itemToDelete = items.First(x => x.ItemId == itemId);
            itemToDelete.Sold = true;
            db.SaveChanges();
        }
        //remove tag
        public void RemoveTag(int itemId, string tagToRemove)
        {
            //find item, then find if tag exist
            //then delete the desired tag
            ItemEntity item = db.Set<ItemEntity>().ToList().First(x => (x.ItemId == itemId));
            if (item != null && item.Tags.Count > 1)
            {
                foreach (TagEntity tag in item.Tags)
                {
                    if (tag.Type == tagToRemove)
                    {
                        item.Tags.Remove(tag);
                        break;
                    }
                }
            }

        }
        //UpdateItem
        public ItemEntity GetItem(int itemId)
        {
            ItemEntity item = db.Items.Find(itemId);
            return item;
        }
    }
}
