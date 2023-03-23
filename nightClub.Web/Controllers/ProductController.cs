using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nightClub.BusinessLogic;
using nightClub.BusinessLogic.Interfaces;
using nightClub.Web.Models;

namespace nightClub.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private readonly IProduct _productBL;
        public ProductController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _productBL = bl.GetProductBL();
        }
        //public ActionResult Index()
        //{
        //    _productBL.GetProductByID(1);
        //    return View();
        //}
        public ActionResult Index()
        {
            var product = Request.QueryString["p"];
            UserData u = new UserData();
            u.Username = "Customer";
            u.SingleProduct = product;

            return View(u);
        }

        [HttpPost]
        public ActionResult Index(string btn)
        {
            return RedirectToAction("Index", "Product", new { @p = btn });
        }
    }
}