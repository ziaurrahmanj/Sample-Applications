using JoeBlogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAProj.Controllers
{
    public class HomeController : Controller
    {
        private string tags= "tags1,tag2";

        public ActionResult Index()
        {
           
            ViewBag.Message = "Your application Home page.";
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
    }
}