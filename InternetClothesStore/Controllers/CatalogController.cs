using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetClothesStore.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}