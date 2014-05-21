using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bike_And_Fun_MVC_Proto_III.Models;

namespace Bike_And_Fun_MVC_Proto_III.Controllers
{
    public class StoreController : Controller
    {
        BikeAndFunEntities storeDB = new BikeAndFunEntities();
        //
        // GET: /Store/

        public ActionResult Index()
        {
            //var categorys = new List<Category>
            //{
            //    new Category { catName = "Fahräder"},
            //    new Category { catName = "Zubehör"},
            //    new Category { catName = "Kleidung"}
            //};

            var categorys = storeDB.categorys.ToList();

            return View(categorys);
        }

        public ActionResult Details(int id)
        {
            //var category = new Category { catName = "Kategoriename " + id };
            //return View(category);

            // Retrieve Category and its Associated Types from database
            var type = storeDB.types.Find(id);
            return View(type);
        }

        public ActionResult Browse(string category)
        {
            //var categoryModel = new Category { catName = category };
            //return View(categoryModel);

            // Retrieve Category and its Associated Types from database
            var categoryModel = storeDB.categorys.Include("types").Single(g => g.catName == category);
            
            return View(categoryModel);
        }

    }
}
