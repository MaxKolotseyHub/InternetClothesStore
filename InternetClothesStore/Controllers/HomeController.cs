using InternetClothesStore.Db;
using InternetClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace InternetClothesStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>();
            using(InternetStoreContext db=new InternetStoreContext())
            {
                categories = db.Categories.ToList();
            }
            return View(categories);
        }

        [HttpGet]
        public ActionResult SelectCategory(string category)
        {
            List<Item> items = new List<Item>();
            using(InternetStoreContext db = new InternetStoreContext())
            {
                items = db.Items.Include(x=>x.Images).Include(x=>x.Category).Where(x => x.Category.Name == category).ToList();
            }
            return PartialView(items);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}