using SerasGida.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;

namespace SerasGida.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[isAuthentication]
        public ActionResult Index()
        {
            using (StockContext sc = new StockContext())
            {
                sc.Personeller.ToList();
            }
           return View();
        }
    }
}