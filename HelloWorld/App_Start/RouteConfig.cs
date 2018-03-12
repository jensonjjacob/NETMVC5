using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config"); // do not allow anyone to download .xml/.config

            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home1",
                url: "Home/Home",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );

            // Since this is the default route, commenting it to test action to action passage of data using ViewBag.This will cause the default route to be executed.
        /*    routes.MapRoute(
                name: "Home2",
                url: "",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );
        */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
