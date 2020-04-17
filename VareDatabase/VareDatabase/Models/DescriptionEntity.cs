using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace VareDatabase.Models
{

    public class DescriptionEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImageOfItem { get; set; }
        [Required]
        [MaxLength(300)]
        public string DescriptionOfItem { get; set; }

        //Navigational property
        public ItemEntity Item { get; set; }
        public int ItemId { get; set; }
    }
}