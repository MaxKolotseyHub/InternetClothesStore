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
        public ActionResult NavbarPartial()
        {
            using (InternetStoreContext db = new InternetStoreContext())
            {
                var menCloth = db.Items.Include(c => c.Category).Where(x => (x.Sex == Sex.Male || x.Sex == Sex.Unisex) & x.ClothingType == ClothingType.Cloth).Select(x => x.Category).Distinct().ToList();
                var menShoes = db.Items.Include(c => c.Category).Where(x => (x.Sex == Sex.Male || x.Sex == Sex.Unisex) & x.ClothingType == ClothingType.Shoes).Select(x => x.Category).Distinct().ToList();
                var womenCloth = db.Items.Include(c => c.Category).Where(x => (x.Sex == Sex.Female || x.Sex == Sex.Unisex) & x.ClothingType == ClothingType.Cloth).Select(x => x.Category).Distinct().ToList();
                var womenShoes = db.Items.Include(c => c.Category).Where(x => (x.Sex == Sex.Female || x.Sex == Sex.Unisex) & x.ClothingType == ClothingType.Shoes).Select(x => x.Category).Distinct().ToList();
                ViewBag.MenCloth = menCloth;
                ViewBag.WomenCloth = womenCloth;
                ViewBag.MenShoes = menShoes;
                ViewBag.WomenShoes = womenShoes;
            }
            return PartialView();
        }
        [HttpGet]
        public ActionResult SelectedCategory(string sex, string type, string category)
        {
            Sex _sex;
            ClothingType _type;

            if (sex == "male")
                _sex = Sex.Male;
            else _sex = Sex.Female;

            if (type == "cloth")
                _type = ClothingType.Cloth;
            else _type = ClothingType.Shoes;

            List<Item> items = new List<Item>();
            using (InternetStoreContext db = new InternetStoreContext())
            {
                items = db.Items.Include(x => x.Images).Include(x => x.Category).Where(x => x.Category.Name == category & (x.Sex == _sex | x.Sex == Sex.Unisex) & x.ClothingType == _type).ToList();
            }
            return View(items);
        }
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>();
            using (InternetStoreContext db = new InternetStoreContext())
            {
                categories = db.Categories.ToList();
            }
            return View(categories);
        }

        [HttpGet]
        public ActionResult SelectCategory(string category)
        {
            List<Item> items = new List<Item>();
            using (InternetStoreContext db = new InternetStoreContext())
            {
                items = db.Items.Include(x => x.Images).Include(x => x.Category).Where(x => x.Category.Name == category).ToList();
            }
            return PartialView(items);
        }
        public ActionResult Catalog()
        {
            using (InternetStoreContext db = new InternetStoreContext())
            {
                ViewBag.SexList = Enum.GetValues(typeof(Sex));

            }
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}