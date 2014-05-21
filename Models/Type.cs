using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bike_And_Fun_MVC_Proto_III.Models
{
    public class Type
    {
        public int typeId { get; set; }
        public string typeName { get; set; }
        public List<int>itemIds { get; set; }               
        public string typeArtUrl { get; set; }
        public Category category { get; set; }
        public List<int>items { get; set; }                  
    }
}