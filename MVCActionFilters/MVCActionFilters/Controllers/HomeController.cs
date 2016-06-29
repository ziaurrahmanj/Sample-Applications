using MVCActionFilters.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionFilters.Controllers
{
    //    The ASP.NET MVC framework supports four different types of filters:

    //Authorization filters – Implements the IAuthorizationFilter attribute.
    //Action filters – Implements the IActionFilter attribute.
    //Result filters – Implements the IResultFilter attribute.
    //Exception filters – Implements the IExceptionFilter attribute.
    //Filters are executed in the order listed above. For example, authorization filters are always executed before action filters and exception filters are always executed after every other type of filter.

    //Authorization filters are used to implement authentication and authorization for controller actions. For example, the Authorize filter is an example of an Authorization filter.

    //Action filters contain logic that is executed before and after a controller action executes. You can use an action filter, for instance, to modify the view data that a controller action returns.

    //Result filters contain logic that is executed before and after a view result is executed.For example, you might want to modify a view result right before the view is rendered to the browser.

    //Exception filters are the last type of filter to run. You can use an exception filter to handle errors raised by either your controller actions or controller action results.You also can use exception filters to log errors.

    //Each different type of filter is executed in a particular order.If you want to control the order in which filters of the same type are executed then you can set a filter's Order property.

    //The base class for all action filters is the System.Web.Mvc.FilterAttribute class. If you want to implement a particular type of filter, then you need to create a class that inherits from the base Filter class and implements one or more of the IAuthorizationFilter, IActionFilter, IResultFilter, or ExceptionFilter interfaces.

//    The Base ActionFilterAttribute Class

//In order to make it easier for you to implement a custom action filter, the ASP.NET MVC framework includes a base ActionFilterAttribute class. This class implements both the IActionFilter and IResultFilter interfaces and inherits from the Filter class.

//The terminology here is not entirely consistent.Technically, a class that inherits from the ActionFilterAttribute class is both an action filter and a result filter.However, in the loose sense, the word action filter is used to refer to any type of filter in the ASP.NET MVC framework.

//The base ActionFilterAttribute class has the following methods that you can override:

//OnActionExecuting – This method is called before a controller action is executed.
//OnActionExecuted – This method is called after a controller action is executed.
//OnResultExecuting – This method is called before a controller action result is executed.
//OnResultExecuted – This method is called after a controller action result is executed.

    [LogActionFilter]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        //Handle Error
        //E.g.: Redirect application to a custom error page when an error is triggered by controller
        [HandleError]
        public ActionResult About()
        {
            throw new NullReferenceException();
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