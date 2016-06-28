using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            Log(filterContext.RouteData, "OnActionExecuting");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log(filterContext.RouteData, "OnResultExecuted");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log(filterContext.RouteData, "OnResultExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log(filterContext.RouteData, "OnActionExecuted");
        }

        public static void Log(RouteData routerdata,string message)
        {
            Debug.WriteLine($"{message} controller:{routerdata.Values["controller"]} Action: {routerdata.Values["action"]}", "Action Filter log");
        }
    }
}