using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BuildingAController.Controllers
{
    public class DummyController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            HttpContext.Current.Response.Write("<p>DummyController response Body</p>");
        }
    }
}