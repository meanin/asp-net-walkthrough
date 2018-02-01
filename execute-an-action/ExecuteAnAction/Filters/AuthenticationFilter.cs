using System.Web.Mvc.Filters;

namespace ExecuteAnAction.Filters
{
    public class AuthenticationFilter : IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>AuthenticationFilter - OnAuthentication</p>");
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>AuthenticationFilter - OnAuthenticationChallenge</p>");
        }
    }
}