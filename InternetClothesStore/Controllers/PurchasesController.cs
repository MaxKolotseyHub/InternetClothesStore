using InternetClothesStore.Db;
using InternetClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetClothesStore.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly InternetStoreContext db;
        public PurchasesController()
        {
            db = new InternetStoreContext();
        }
        // GET: Purchases
        public ActionResult Index()
        {
            return View(db.Purchases.ToList());
        }
        public ActionResult Delete(int id)
        {
            var p = db.Purchases.FirstOrDefault(x=>x.Id==id);
            if (p != null)
            {
                db.Purchases.Remove(p);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var p = db.Purchases.FirstOrDefault(x => x.Id == id);
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Purchase p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Client(Client client, int id)
        {
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Edit", new { id = id });
        }
        [HttpPost]
        public ActionResult Status(string state, int id)
        {
            var p = db.Purchases.FirstOrDefault(x => x.Id == id);
            if (p != null)
            {
                p.State = state;
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Edit", new { id = id });
        }
    }
}