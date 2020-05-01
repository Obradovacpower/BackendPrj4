using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.DBContext;
using VareDatabase.Models;

namespace VareDatabase.Repo
{
    public class SeachForItemRepository: IItemRepository
    {
        private VareDataModelContext db;

        public SeachForItemRepository(VareDataModelContext db)
        {
            this.db = db;
        }

        public void search(string[] search)
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
