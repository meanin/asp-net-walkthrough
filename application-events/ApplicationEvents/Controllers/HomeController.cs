using System.Web.Mvc;

namespace ApplicationEvents.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Write("<p>Controller Action</p>");
            return new EmptyResult();
        }
    }
}