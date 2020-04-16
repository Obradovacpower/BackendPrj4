using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace VareDatabase.Models
{

    public class ItemEntity
    {
        [Key]
        public int ItemId { get; set; }
        public string Type { get; set; }

        //Navigational property
        public DescriptionEntity Description { get; set; }
        public BidEntity Bid { get; set; }
        public TimeEntity Time { get; set; }
    }
}