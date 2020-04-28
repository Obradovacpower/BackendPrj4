using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VareDatabase.Models
{
    public class TagEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ItemEntity Item { get; set; }
        public int ItemId { get; set; }
    }
}
