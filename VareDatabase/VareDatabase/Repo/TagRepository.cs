using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;
using VareDatabase.DBContext;

namespace VareDatabase.Repo
{
    public class TagRepository : Repository<TagEntity>
    {
        public TagRepository(VareDataModelContext db) : base(db)
        {

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
        private void GenerateTags(string nameOfItem, int itemId)
        {
            string[] words = nameOfItem.Split(' ', ',', '.');
            foreach (string s in words)
            {
                AddTag(itemId, s);
            }
        }
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
    }
}
