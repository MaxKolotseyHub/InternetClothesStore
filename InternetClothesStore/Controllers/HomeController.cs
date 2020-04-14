using InternetClothesStore.Db;
using InternetClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetClothesStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (InternetStoreContext ctx = new InternetStoreContext())
            {
                var category = ctx.Categories.ToList().First();
                var items = ctx.Items.FirstOrDefault(x => x.Categories.FirstOrDefault(y => y.Id == category.Id) !=null);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}