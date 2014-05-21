using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bike_And_Fun_MVC_Proto_III.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BikeAndFunEntities>
    {
        protected override void Seed(BikeAndFunEntities context)
        {
            var categorys = new List<Category>
            {
                new Category { catName = "Fahräder" },
                new Category { catName = "Zubehör" },
                new Category { catName = "Kleidung" },
            };

            var items = new List<Item>
            {
                new Item { itemName = "Fahrrad 1", /*category="Fahräder",*/ article_no="0001", unitPrice=1, colorDescription="rot", size="24", /*type = MTB ,*/ description="tolles fahrrad."},
                new Item { itemName = "Fahrrad 2" },
                new Item { itemName = "Fahrrad 3" },
                new Item { itemName = "Fahrrad 4" },
                new Item { itemName = "Schaltung 1" },
                new Item { itemName = "Bremse 1" },
                new Item { itemName = "Jacke 1" },
                new Item { itemName = "Hose 1" },

            };

            new List<Type>
            {
                new Type { typeName = "MTB", typeId = 0001, /*itemIds = "2000",*/ typeArtUrl = "/Content/Images/placeholder.gif", category = categorys.Single(g => g.catName == "Fahräder"), /*items="4000"*/},
				new Type { typeName = "Trekking", typeId = 0002, /*itemIds = "2010",*/ typeArtUrl = "/Content/Images/placeholder.gif", category = categorys.Single(g => g.catName == "Fahräder"), /*items="4100"*/},
				new Type { typeName = "Kids", typeId = 0003, /*itemIds = "2020",*/ typeArtUrl = "/Content/Images/placeholder.gif", category = categorys.Single(g => g.catName == "Fahräder"), /*items="4200"*/},
				new Type { typeName = "Hose", typeId = 0004, /*itemIds = "2030",*/ typeArtUrl = "/Content/Images/placeholder.gif", category = categorys.Single(g => g.catName == "Kleidung"), /*items="4300"*/},
				new Type { typeName = "Jacke", typeId = 0005, /*itemIds = "2040",*/ typeArtUrl = "/Content/Images/placeholder.gif", category = categorys.Single(g => g.catName == "Kleidung"), /*items="4400"*/},
				new Type { typeName = "Bremse", typeId = 0006, /*itemIds = "2050",*/ typeArtUrl = "/Content/Images/placeholder.gif", category = categorys.Single(g => g.catName == "Zubehör"), /*items="4500"*/},
				new Type { typeName = "Schaltung", typeId = 0007, /*itemIds = "2060",*/ typeArtUrl = "/Content/Images/placeholder.gif", category = categorys.Single(g => g.catName == "Zubehör"), /*items="4600"*/},
/*                new Type { Title = "For Those About To Rock We Salute You", Category = Categorys.Single(g => g.Name == "Rock"), Price = 8.99M, Item = Items.Single(a => a.Name == "AC/DC"), TypeArtUrl = "/Content/Images/placeholder.gif" },
                new Type { Title = "Let There Be Rock", Category = Categorys.Single(g => g.Name == "Rock"), Price = 8.99M, Item = Items.Single(a => a.Name == "AC/DC"), TypeArtUrl = "/Content/Images/placeholder.gif" },
                new Type { Title = "Balls to the Wall", Category = Categorys.Single(g => g.Name == "Rock"), Price = 8.99M, Item = Items.Single(a => a.Name == "Accept"), TypeArtUrl = "/Content/Images/placeholder.gif" },
                new Type { Title = "Restless and Wild", Category = Categorys.Single(g => g.Name == "Rock"), Price = 8.99M, Item = Items.Single(a => a.Name == "Accept"), TypeArtUrl = "/Content/Images/placeholder.gif" },
                new Type { Title = "Górecki: Symphony No. 3", Category = Categorys.Single(g => g.Name == "Classical"), Price = 8.99M, Item = Items.Single(a => a.Name == "Adrian Leaper & Doreen de Feis"), TypeArtUrl = "/Content/Images/placeholder.gif" },
  */              
            }.ForEach(a => context.types.Add(a));
        }
    }
}