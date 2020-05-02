using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;
using VareDatabase.DBContext;

namespace VareDatabase
{
    public class TempTestClass
    {
        private VareDataModelContext db;
        public void CreateItem(int buyOut, int userId, int expire, string[] tags, string title, string description, string[] images)
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
        public void AddImage(int itemId, string image)
        {
            ItemEntity item = db.Set<ItemEntity>().First(x => x.ItemId == itemId);
            item.Images.Add(new ImageEntity
            {
                ImageOfItem = image
            });
        }
        private void GenerateTags(string nameOfItem, int itemId)
        {
            string[] words = nameOfItem.Split(' ', ',', '.');
            foreach (string s in words)
            {
                if (s != null)
                {
                    AddTag(itemId, s);
                }
            }
        }
        public void AddTag(int itemId, string newTag)
        {
            ItemEntity item = db.Set<ItemEntity>().ToList().First(x => x.ItemId == itemId);
            if (item == null)
            {
                return;
            }
            bool exists = false;
            foreach (TagEntity t in item.Tags) //check each tag if it exists
            {
                if (t.Type == newTag)
                {
                    exists = true;
                }
            }
            if (!exists) //if it doesnt exist add it
            {
                item.Tags.Add(new TagEntity()
                {
                    Type = newTag,
                });
            }
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

        public void search(string title)
        {
            string[] search = title.Split(' ', ',', '.');
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
