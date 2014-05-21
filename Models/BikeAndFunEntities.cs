using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bike_And_Fun_MVC_Proto_III.Models
{
    public class BikeAndFunEntities : DbContext
    {
        public DbSet<Type> types { get; set; }
        public DbSet<Category> categorys { get; set; }
    }
}