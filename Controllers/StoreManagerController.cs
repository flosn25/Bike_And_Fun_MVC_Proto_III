using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bike_And_Fun_MVC_Proto_III.Models;

namespace Bike_And_Fun_MVC_Proto_III.Controllers
{
    public class StoreManagerController : Controller
    {
        private BikeAndFunEntities db = new BikeAndFunEntities();

        //
        // GET: /StoreManager/

        public ActionResult Index()
        {
            var types = db.types.Include(a => a.category).Include(a => a.items);    // hier sollte item stehen
            return View(db.types.ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ActionResult Details(int id)
        {
            Bike_And_Fun_MVC_Proto_III.Models.Type type = db.types.Find(id);
            if (type == null)
            {
                return HttpNotFound();
            }
            return View(type);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
//            ViewBag.categoryId = new SelectList(db.categorys, "categoryId", "Name");
//            ViewBag.itemId = new SelectList(db.items, "itemId", "Name");
            return View();
        }

        //
        // POST: /StoreManager/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bike_And_Fun_MVC_Proto_III.Models.Type type)
        {
            if (ModelState.IsValid)
            {
                db.types.Add(type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(type);
        }

        //
        // GET: /StoreManager/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Bike_And_Fun_MVC_Proto_III.Models.Type type = db.types.Find(id);
            if (type == null)
            {
                return HttpNotFound();
            }
            return View(type);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Bike_And_Fun_MVC_Proto_III.Models.Type type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(type);
        }

        //
        // GET: /StoreManager/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Bike_And_Fun_MVC_Proto_III.Models.Type type = db.types.Find(id);
            if (type == null)
            {
                return HttpNotFound();
            }
            return View(type);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bike_And_Fun_MVC_Proto_III.Models.Type type = db.types.Find(id);
            db.types.Remove(type);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}