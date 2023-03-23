using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nightClub.Web.Models;

namespace nightClub.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UserData u = new UserData();
            u.Username = "Costumer";
            u.ProducList = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" };

            return View(u);
        }
    }
}