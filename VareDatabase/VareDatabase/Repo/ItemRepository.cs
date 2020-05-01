using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;
using VareDatabase.DBContext;

namespace VareDatabase
{
    public class ItemRepository : IItemRepository
    {
        private VareDataModelContext db;
        public ItemRepository(VareDataModelContext context)
        {
            db = context;
        }
        public void AddItem(int buyOut, int userId, int expire, string[] tags, string title, string description, string[] images)
        {
            List<ImageEntity> newImages = new List<ImageEntity>();
            for (int i = 0; i < images.Length; i++)
            {
                ImageEntity item = new ImageEntity();
                item.ImageOfItem = images[i];
                newImages[i] = item;
            }
            List<TagEntity> newTags = new List<TagEntity>();
            for (int i = 0; i < tags.Length; i++)
            {
                TagEntity tag = new TagEntity();
                tag.Type = tags[i];
                newTags[i] = tag;
            }
            ItemEntity itemEntity = new ItemEntity()
            {
                BuyOutPrice = buyOut,
                DateCreated = DateTime.Now,
                ExpirationDate = DateTime.Now.AddDays(expire),
                Title = title,
                Images = newImages,
                Tags = newTags,
                DescriptionOfItem = description,
                UserIdSeller = userId,
            };
            GenerateTags(itemEntity.Title, itemEntity.ItemId);
            db.Add(itemEntity);
            db.SaveChanges();
        }
        public ItemEntity UpdateItem(int itemId) //getItem?
        {
            ItemEntity item = db.Items.Find(itemId);
            return item;
        }

        //Brugt i: BidOnItemRepository
        public void AddBid(int itemId, int bid, int userId)
        {
            ItemEntity item = db.Set<ItemEntity>().Find(itemId);
            if (item != null)
            {
                foreach (BidEntity b in item.Bids)
                {
                    if (b.Bid >= bid)
                    {
                        return;
                    }
                }
                item.Bids.Add(new BidEntity
                {
                    Bid = bid,
                    UserIdBuyer = userId
                });
            }
        }
        //this essentially sells the item or makes it unavailable if expired
        public void SoftDeleteItem(int itemId)
        {
            var items = db.Set<ItemEntity>().ToList();
            ItemEntity itemToDelete = items.First(x => x.ItemId == itemId);
            itemToDelete.Sold = true;
            db.SaveChanges();
        }
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
        public void AddImage(int itemId, string image)
        {
            ItemEntity item = db.Set<ItemEntity>().First(x => x.ItemId == itemId);
            item.Images.Add(new ImageEntity
            {
                ImageOfItem = image
            });
        }

        //ERMIN WAS HERE
        public void Search(string[] search)
        {
            List<ItemEntity> foundItems = new List<ItemEntity>();
            foreach (string s in search)
            {
                List<ItemEntity> ids = new List<ItemEntity>();
                ids = SearchByTag(s);
                foreach (ItemEntity i in ids)
                {
                    if (!foundItems.Contains(i))
                    {
                        foundItems.Add(i);
                    }
                }
            }

        }
        //ERMIN WAS HERE
        public List<ItemEntity> SearchByTag(string tag)
        {
            List<ItemEntity> itemsId = new List<ItemEntity>();
            var join = (from i in db.Items
                        join t in db.Tags on i.ItemId equals t.ItemId
                        select new
                        {
                            Title = i.Title,
                            Id = i.ItemId,
                            Tag = t.Type,
                        }).Where(x => x.Tag == tag).ToList();
            foreach (var j in join)
            {
                itemsId.AddRange(db.Items.Where(i => j.Id == i.ItemId).ToList());
            }
            return itemsId;
        }
    }
}
