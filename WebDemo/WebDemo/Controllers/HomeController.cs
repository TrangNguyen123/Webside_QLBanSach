using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Category()
        {
            ViewBag.Message = "Your Category page.";

            return View();
        }
        public ActionResult Detail()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Account()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Rigister()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
    }
}