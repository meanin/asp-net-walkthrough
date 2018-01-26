using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using HandlersAndModules.Handlers;

namespace HandlersAndModules
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //hides /home/dummy instead of running on home controller
            routes.Add(new Route("home/dummy", new DummyRouteHandler()));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
