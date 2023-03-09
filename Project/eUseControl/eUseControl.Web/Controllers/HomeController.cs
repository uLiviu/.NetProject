using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            UserData u = new UserData();
            u.UserName = "Customer";
            u.Products = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" };

            return View(u);
        }

        //public ActionResult Product()
        //{
        //    var product = Request.QueryString["p"];

        //    UserData u = new UserData();
        //    u.UserName = "Customer";
        //    u.SingleProduct = product;

        //    return View(u);
        //}

        ////http://localhost:31843/Home/Product?p=JORA
        //[HttpPost]
        //public ActionResult Product(string btn)
        //{
        //    return RedirectToAction("Product", "Home", new { @p = btn });
        //}
        @section Scripts
        {
            @Scripts.Render("~/bundles/unobstrusive/js")
        <script type = "text/javascript" >
                       function succes(data)
        {
            if (data.RedirectUrl)
            {
                window.location.href = data.RedirectUrl;
            }
            else
            {
                $("#restulTarget").text(data.msg);
            }
        }
        </script>
    }
    [HttpPost]
    public ActionResult Product(string btn)
    {
        return Json(new { RedirectUrl = UrlHelper.Action("Product", new { p = btn }) });
    }
}