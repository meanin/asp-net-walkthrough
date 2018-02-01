using System.Web.Mvc;

namespace ExecuteAnAction.Filters
{
    public class LogActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>LogActionFilter - OnActionExecuting</p>");
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>LogActionFilter - OnActionExecuted</p>");
        }
    }
}