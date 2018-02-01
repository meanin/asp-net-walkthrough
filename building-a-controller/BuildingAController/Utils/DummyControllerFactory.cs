using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using BuildingAController.Controllers;

namespace BuildingAController.Utils
{
    public class DummyControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if(controllerName.Equals("dummy", StringComparison.OrdinalIgnoreCase))
                return DependencyResolver.Current.GetService(typeof(DummyController)) as IController;

            throw new NotImplementedException();
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            (controller as IDisposable)?.Dispose();
        }
    }
}