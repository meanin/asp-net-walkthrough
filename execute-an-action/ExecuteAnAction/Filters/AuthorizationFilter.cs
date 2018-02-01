using System.Web.Mvc;

namespace ExecuteAnAction.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>AuthorizationFilter - OnAuthorization</p>");
        }
    }
}