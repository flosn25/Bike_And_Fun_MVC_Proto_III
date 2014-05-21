using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bike_And_Fun_MVC_Proto_III.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string catName { get; set; }
        public string Description { get; set; }
        public List<Type> types { get; set; }
    }
}