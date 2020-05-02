using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;
using VareDatabase.DBContext;

namespace VareDatabase.Repo.Auction
{
    public interface IItemRepository : IRepository<ItemEntity>
    {
        public IEnumerable<ItemEntity> Search(string searchString);
    }
    public class ItemRepository : Repository<ItemEntity>, IItemRepository
    {
        private VareDataModelContext db;
        public ItemRepository(VareDataModelContext db) : base(db)
        {
            this.db = db;
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
