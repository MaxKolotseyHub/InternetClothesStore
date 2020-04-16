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
    public class AdminController : Controller
    {
        [HttpGet]
        [Authorize(Roles = "admin")]
        public ActionResult AdminTools()
        {
            List<Item> items;
            using(InternetStoreContext db = new InternetStoreContext())
            {
                items = db.Items.Include(x => x.Images).Include(x => x.Category).Where(x=>x.Archive == false).ToList();
            }
            return View(items);
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Create(Item item, string path, string sex, string type)
        {
            using(InternetStoreContext db = new InternetStoreContext())
            {
                if (type == "одежда")
                    item.ClothingType = ClothingType.Cloth;
                else item.ClothingType = ClothingType.Shoes;

                if (sex == "мужское")
                    item.Sex = Sex.Male;
                else if (sex == "женское")
                    item.Sex = Sex.Female;
                else item.Sex = Sex.Unisex;

                item.Images.Add(new Image { Path = path});

                var category = db.Categories.FirstOrDefault(x => x.Name == item.Category.Name);
                if (category == null)
                    category = new Category() { Name = item.Category.Name};

                item.Category = category;
                db.Items.Add(item);
                db.SaveChanges();
            }
            return RedirectToAction("AdminTools");
        }
    }
}