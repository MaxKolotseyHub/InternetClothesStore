using InternetClothesStore.Db;
using InternetClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Security.Claims;
using System.Threading;

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
                items = db.Items.Include(x => x.Images).Include(x => x.Category).Where(x => x.Category.Name == category & (x.Sex == _sex | x.Sex == Sex.Unisex) & x.ClothingType == _type & x.Archive == false).ToList();
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
        public ActionResult Cart()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult ItemDescription(int id)
        {
            Item item = null;
            using (InternetStoreContext db = new InternetStoreContext())
            {
                item = db.Items
                    .Include(x => x.Images)
                    .Include(x => x.Category)
                    .Include(x => x.Sizes)
                    .FirstOrDefault(x => x.Id == id);
            }
            return View(item);
        }
        [HttpGet]
        public ActionResult ShowCart()
        {
            return View(MyCart.GetInstance().Cart);
        }
        [HttpGet]
        public ActionResult DeleteFromCart(int id)
        {
            Item item;
            if ((item = MyCart.GetInstance().Cart.FirstOrDefault(x => x.Id == id)) != null)
                MyCart.GetInstance().Cart.Remove(item);
            return RedirectToAction("ShowCart");
        }
        [HttpGet]
        public ActionResult PurchaseInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PurchaseInfo(Client client)
        {
            if (!ModelState.IsValid)
            {
                return View("PurchaseInfo", client);
            }
            using (InternetStoreContext db = new InternetStoreContext())
            {
                db.Clients.Add(client);
                Purchase purchase = new Purchase();
                purchase.Client = client;
                foreach (var item in MyCart.GetInstance().Cart)
                {
                    var it = db.Items.FirstOrDefault(x => x.Id == item.Id);
                    if (it != null)
                    {
                        var _size = it.Sizes.FirstOrDefault(x => x.MySize == item.SizeName);
                        if (_size != null)
                        {
                            _size.Count -= item.Quantity;
                        }
                    }
                    item.Archive = true;
                    purchase.Items.Add(item);
                }
                purchase.PurchaseDateTime = DateTime.Now;

                db.Purchases.Add(purchase);

                db.SaveChanges();

                MyCart.GetInstance().Cart.Clear();
            }
            return RedirectToAction("ShowCart");
        }
        [HttpPost]
        public ActionResult AddToCart(int Id, int quantity, string size)
        {
            size = size.Replace("\r\n", "").Trim();
            Item item;
            using (InternetStoreContext db = new InternetStoreContext())
            {
                item = db.Items.FirstOrDefault(x => x.Id == Id);
            }
            if (item != null)
            {
                item.Quantity = quantity;
                item.SizeName = size;
            }

            MyCart.GetInstance().Cart.Add(item);

            return RedirectToAction("Index");
        }
        public ActionResult Catalog()
        {
            using (InternetStoreContext db = new InternetStoreContext())
            {
                ViewBag.SexList = Enum.GetValues(typeof(Sex));
            }
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public ActionResult AdminTools()
        {
            return View();
        }
    }
}