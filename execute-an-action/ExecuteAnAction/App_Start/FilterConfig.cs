using System.Web;
using System.Web.Mvc;
using ExecuteAnAction.Filters;

namespace ExecuteAnAction
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthenticationFilter());
            filters.Add(new AuthorizationFilter());
            filters.Add(new LogActionFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
