using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkTutorial.Controllers
{
    public class HomeController : Controller
    {
        Model1Container context = new Model1Container();
        public ActionResult Index()
        {
            //transaction if EF
            using (System.Data.Entity.DbContextTransaction dbTrans = context.Database.BeginTransaction())
            {
                try {
                    Notifications notif1 = new Notifications { Message = "msg1", NotifType = 1, TimeStamp = DateTime.Now };
                    context.Notifications.Add(notif1);
                    context.SaveChanges();
                    
                    context.Database.ExecuteSqlCommand(@"update Notifications set Message='msg1 updated' where Id="+ notif1.Id);
                    context.SaveChanges();

                    dbTrans.Commit();
                }
                catch (Exception ex)
                {
                    dbTrans.Rollback();
                }
            }
            

                return View(context.Notifications.ToList());
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