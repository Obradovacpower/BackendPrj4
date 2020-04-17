using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Timers;

namespace VareDatabase.Models
{
    public class TimeEntity
    {
        public int Id { get; set; }
        public DateTime expiration { get; set; }
        public DateTime timeOfCreation { get; set; }

        //Navigational property
        public ItemEntity Item { get; set; }
        public int ItemId { get; set; }
    }
}