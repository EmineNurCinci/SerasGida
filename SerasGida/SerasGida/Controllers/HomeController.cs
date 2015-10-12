using SerasGida.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerasGida.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [isAuthentication]
        public ActionResult Index()
        {
            return View();
        }
    }
}