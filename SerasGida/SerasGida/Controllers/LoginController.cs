using SerasGida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerasGida.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(UserModel user)
        {
            if (user.Username=="admin" && user.Password=="12345")
            {
                Session["UserName"] = "admin@admin.com";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}