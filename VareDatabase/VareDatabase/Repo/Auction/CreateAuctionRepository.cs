using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.DBContext;
using VareDatabase.Models;
using VareDatabase.Interfaces.Auction;

namespace VareDatabase.Repo
{
    public class CreateAuctionRepository : Repository<ItemEntity>, ICreateAuctionRepository
    {
        private VareDataModelContext db;
        public CreateAuctionRepository(VareDataModelContext db) : base(db)
        {
            this.db = db;
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
                if(s != null)
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
    }
}
