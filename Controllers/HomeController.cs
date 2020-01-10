using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
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
            ViewBag.Sentence = "This comes from the controller.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewData["FromController"] = "This view is from the controller";
            return View();
        }
        public ActionResult Services()
        {
            ViewData["FromController"] = "We offer lots of great Services.";
            return View();
        }
    }
}