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
        public ActionResult Index()
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (InternetStoreContext db = new InternetStoreContext())
            {
                var item = db.Items.FirstOrDefault(x=>x.Id==id);
                if (item != null)
                {
                    db.Items.Remove(item);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Item item;
            using (InternetStoreContext db = new InternetStoreContext())
            {
                item = db.Items.Include(x => x.Images).Include(x => x.Category).Include(x => x.Sizes).FirstOrDefault(x=>x.Id == id);
            }
            return View(item);
        }
        [HttpGet]
        public ActionResult DeleteImage(int imageid)
        {
            int itemid = 0;
            using(InternetStoreContext db = new InternetStoreContext())
            {
                var item = db.Images.FirstOrDefault(x => x.Id == imageid);
                if(item!=null)
                {
                    itemid = item.ItemId;
                    db.Images.Remove(item);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Details", new {id = itemid});
        }
        [HttpPost]
        public ActionResult AddImage(int itemid, string url)
        {
            using(InternetStoreContext db = new InternetStoreContext())
            {
                var item = db.Items.FirstOrDefault(x=>x.Id == itemid);
                item.Images.Add(new Image() { Path = url});
                db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = itemid });
        }
        [HttpPost]
        public ActionResult Details(Item item)
        {
            using (InternetStoreContext db = new InternetStoreContext())
            {
                db.Items.Attach(item);
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
            return View(item);
        }
    }
}