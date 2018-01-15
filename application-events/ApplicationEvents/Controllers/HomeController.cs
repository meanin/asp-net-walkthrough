using System.Web.Mvc;

namespace ApplicationEvents.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Write("Controller Action");
            return new EmptyResult();
        }
    }
}