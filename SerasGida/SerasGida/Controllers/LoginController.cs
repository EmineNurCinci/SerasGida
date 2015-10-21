using BusinessAccessLayer;
using SerasGida.Entities;
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
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel user)
        {
            var result = RepoInstance.personelrepo.Check(user.UserName, user.Password);
            if (result != null)
            {
                List<MenuDetails> menu = new List<MenuDetails>();

                MenuDetails mn1 = new MenuDetails();
                mn1.MenuName = "Urun";
                mn1.ActionName = "Product";
                mn1.ControllerName = "Home";
                menu.Add(mn1);
                MenuDetails mn2 = new MenuDetails();
                mn2.MenuName = "Müşteri";
                mn2.ActionName = "Customer";
                mn2.ControllerName = "Home";
                menu.Add(mn2);
                MenuDetails mn3 = new MenuDetails();
                mn3.MenuName = "Personel";
                mn3.ActionName = "Employee";
                mn3.ControllerName = "Home";
                menu.Add(mn3);
                //MenuDetails mn4 = new MenuDetails();
                //mn4.MenuName = "Kampanyalar";
                //mn4.ActionName = "Campaigns";
                //mn4.ControllerName = "Home";
                //menu.Add(mn4);


                Session["menus"] = menu;
                Session["Username"] = user.UserName;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}