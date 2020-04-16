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
    public class HomePartialController : Controller
    {
        // GET: HomePartial
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return PartialView();
        }
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
    }
}