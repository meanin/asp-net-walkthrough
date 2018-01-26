using System.Web;
using System.Web.Routing;

namespace HandlersAndModules.Handlers
{
    public class DummyRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new DummyHandler();
        }
    }
}