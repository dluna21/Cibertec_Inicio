using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Permite la seguridad en mvc
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Razor se trabaja en el formato 25-12-2016 con guion
            //routes.MapRoute(
            //    name: "RazorDate",
            //    url: "Razor/{date}",
            //    defaults: new { controller = "Razor",
            //                    action = "EntryDate"
            //    }
            //);

            routes.MapMvcAttributeRoutes();
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Razor", action = "Index", id = UrlParameter.Optional }
            ); 
        }
    }
}
