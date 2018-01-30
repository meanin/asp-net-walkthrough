using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BuildingAController.Controllers;

namespace BuildingAController
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //ControllerBuilder.Current.SetControllerFactory(new DummyControllerFactory());
            DependencyResolver.SetResolver(new DummyDependencyResolver());
        }
    }

    public class DummyDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            
            var types = GetType().Assembly.GetTypes()
                .Where(serviceType.IsAssignableFrom)
                .Where(s => !s.IsInterface);
            if(types.Any())
                return Activator.CreateInstance(types.First());

            throw new Exception($"Cannot find parameterless constructor for implementation of {serviceType}");
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
