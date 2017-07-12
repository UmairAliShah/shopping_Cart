using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping_Cart_Practice.Models;
namespace Shopping_Cart_Practice.Controllers
{
    public class ProductController : Controller
    {
        private shopping_cart_practiceEntities db = new shopping_cart_practiceEntities();
        public ActionResult Index()
        {

            ViewBag.listProducts = db.Table_Product.ToList();
            ViewBag.qty = new SelectList(db.Table_Product, "id", "p_quntity");
            return View(db.Table_Product.ToList());
        }
	}
}