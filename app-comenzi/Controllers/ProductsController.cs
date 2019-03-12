using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app_comenzi.Models;

namespace app_comenzi.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products/Random
        public ActionResult Random()
        {
            var product = new Product() { Id = 1, Name = "Cartofi copti", Description = "Faimosii cartofi copti", Price = 5.5f, Supply = 200 };

            return View(product);
        }
    }
}