using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace VareDatabase.Models
{

    public class DescriptionEntity
    {
        public int Id { get; set; }
        public string imageOfItem { get; set; }
        public string descriptionOfItem { get; set; }
        public string title { get; set; }

        //Navigational property
        public ItemEntity Item { get; set; }
        public int ItemId { get; set; }
    }
}