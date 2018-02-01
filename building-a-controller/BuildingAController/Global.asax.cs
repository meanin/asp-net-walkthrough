using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BuildingAController.Controllers;
using BuildingAController.Utils;

namespace BuildingAController
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // Do not register both custom dependency resolver and controller factory because of:
            // https://github.com/ASP-NET-MVC/aspnetwebstack/blob/4e40cdef9c8a8226685f95ef03b746bc8322aa92/src/System.Web.Mvc/SingleServiceResolver.cs
            // ControllerBuilder.Current.SetControllerFactory(new DummyControllerFactory());
            DependencyResolver.SetResolver(new DummyDependencyResolver());
        }
    }
}
