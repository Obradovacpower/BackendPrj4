//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using VareDatabase.Interfaces;
//using VareDatabase.Repo;
//using VareDatabase.Models;
//using VareDatabase.DBContext;

//namespace VareDatabase.Repo.Auction
//{
//    public class TagRepository : Repository<TagEntity>, ITagRepository
//    {
//        private VareDataModelContext db;

//        public TagRepository(VareDataModelContext db):base(db)
//        {
//            this.db = db;
//        }
//        public void Create(int itemId, string newTag)
//        {
//            ItemEntity item = db.Set<ItemEntity>().ToList().First(x => x.ItemId == itemId);
//            if (item == null)
//            {
//                return;
//            }
//            bool exists = false;
//            foreach (TagEntity t in item.Tags) //check each tag if it exists
//            {
//                if (t.Type == newTag)
//                {
//                    exists = true;
//                }
//            }
//            if (!exists) //if it doesnt exist add it
//            {
//                item.Tags.Add(new TagEntity()
//                {
//                    Type = newTag,
//                });
//            }
//        }

//        public TagEntity Read(int id)
//        {

//        }
//        public IEnumerable<TagEntity> GetAll();
//        {

//        }

//        public IEnumerable<TagEntity> GetAllTagForSpecificItem(int id);
//        {
//            return 
//        }

//        public void Delete(TagEntity entity)
//        {

//        }
//    }
//}
