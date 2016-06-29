using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditorTemplatesExample.Controllers
{
    public class HomeController : Controller
    {
        sampledbEntities db = new sampledbEntities();
        public ActionResult Index()
        {

            return View(db.Customers.FirstOrDefault());
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