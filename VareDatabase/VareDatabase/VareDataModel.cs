using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Timers;

namespace VareDatabase
{

    
    public class Item
    {
        public int ItemId { get; set;}
        public string Type { get; set;}
    }

    public class Bud
    {
        public int userID_forLastBid { get; set; }
        public int price { get; set; }
        public int userID_forSeller { get; set; }
    }

    public class Tid
    {
        public Timer experation { get; set; }
        public string timeOfCreation { get; set; }
    }

    public class Beskrivelse
    {
        public string imageOfItem { get; set; }
        public string descriptionOfItem { get; set; }
        public string title { get; set; }
    }
    


}