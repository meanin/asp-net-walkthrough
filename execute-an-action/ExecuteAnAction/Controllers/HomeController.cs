
using System;
using System.Web.Mvc;
using ExecuteAnAction.Filters;
using ExecuteAnAction.Selectors;

namespace ExecuteAnAction.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public void Void()
        {
            HttpContext.Response.Write("<p>HomeController - Index Action wrote directly into Response</p>");
        }

        [HttpGet]
        [ActionName("Index")]
        public ActionResult Index()
        {
            return Content("<p>HomeController - ActionResult Index is materialized in Response after OnAuthenticationChallenge AuthenticationFilter</p>");
        }

        [HttpGet]
        [MobileOnly]
        [ActionName("Index")]
        public ActionResult IndexMobile()
        {
            return Content("<p>HomeController - ActionResult IndexMobile is materialized in Response after OnAuthenticationChallenge AuthenticationFilter</p>");
        }

        [NonAction]
        public void NotAnAction()
        {
            
        }

        [HttpGet]
        [CustomExceptionFilter]
        public void Exception()
        {
            throw new Exception("<p>Custom exception from an action</p>");
        }
    }
}