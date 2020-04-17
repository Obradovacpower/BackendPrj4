using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VareDatabase.Models
{

    public class BidEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Bid { get; set; }
        [Required]
        public int UserIdBuyer { get; set; }

        //Navigational property
        public ItemEntity Item { get; set; }
        public int ItemId { get; set; }
    }
}