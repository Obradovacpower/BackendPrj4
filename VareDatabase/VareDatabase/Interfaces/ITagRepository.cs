using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Models;

namespace VareDatabase.Interfaces
{
    interface ITagRepository : IRepository<TagEntity>
    {
        void Create(TagEntity tag);
        TagEntity Read(int id);
        IEnumerable<TagEntity> GetAll();
        IEnumerable<TagEntity> GetAllTagForSpecificItem(int id);
    }
}
