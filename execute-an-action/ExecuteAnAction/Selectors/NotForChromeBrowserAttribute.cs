using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ExecuteAnAction.Selectors
{
    public class MobileOnlyAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            var userAgent = controllerContext.HttpContext.Request.UserAgent;
            var userBrowser = new HttpBrowserCapabilities { Capabilities = new Hashtable { { string.Empty, userAgent } } };

            return userBrowser.IsMobileDevice;
        }
    }
}