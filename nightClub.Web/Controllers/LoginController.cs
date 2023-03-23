using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nightClub.BusinessLogic.Interfaces;
using nightClub.BusinessLogic;
using nightClub.Domain.Entities.User;
using nightClub.Web.Models;

namespace nightClub.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _sessionBL;

        public LoginController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _sessionBL = bl.GetSessionBL(); 
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData()
                {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIP = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };
                var userLogin = _sessionBL.UserLogin(data);
                if (userLogin.Status)
                {
                    //ADD COOKie
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }
            }
            return View();
        }
    }
}