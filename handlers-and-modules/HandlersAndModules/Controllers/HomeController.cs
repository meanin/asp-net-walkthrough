using System.Web.Mvc;

namespace HandlersAndModules.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return new ContentResult
            {
                Content = "Response Body"
            };
        }
    }
}