using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ApplicationEvents;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), nameof(MvcApplication.Pre_Application_Start))]
namespace ApplicationEvents
{
    public class MvcApplication : HttpApplication
    {
        public static void Pre_Application_Start()
        {
            Debug.WriteLine("Pre_Application_Start");
            //HttpContext does not exist yet, as no request received
            //Response.Write("Pre_Application_Start");

            // For registering HttpModules to be sure they are initialized before any request
        }

        protected void Application_Start()
        {
            Debug.WriteLine($"Registered {HttpContext.Current.ApplicationInstance.Modules} on pre application start");
            //HttpContext does not exist yet, as no request received
            //Response.Write($"Registered {HttpContext.Current.ApplicationInstance.Modules} on pre application start");

            Debug.WriteLine("Application_Start");
            //HttpContext does not exist yet, as no request received
            //Response.Write("<p>Application_Start");

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        // "BeginRequest" - Occurs as the first event in the HTTP pipeline chain of execution when ASP.NET responds to a request.
        protected void Application_BeginRequest()
        {
            Debug.WriteLine("Application_BeginRequest");
            Response.Write("<p>Application_BeginRequest</p>");
        }

        // "AuthenticateRequest" - Occurs when a security module has established the identity of the user.
        protected void Application_AuthenticateRequest()
        {
            Debug.WriteLine("Application_AuthenticateRequest");
            Response.Write("<p>Application_AuthenticateRequest</p>");
        }

        // "PostAuthenticateRequest" - Occurs when a security module has established the identity of the user.
        protected void Application_PostAuthenticateRequest()
        {
            Debug.WriteLine("Application_PostAuthenticateRequest");
            Response.Write("<p>Application_PostAuthenticateRequest</p>");
        }

        // "AuthorizeRequest" - Occurs when a security module has verified user authorization.
        protected void Application_AuthorizeRequest()
        {
            Debug.WriteLine("Application_AuthorizeRequest");
            Response.Write("<p>Application_AuthorizeRequest</p>");
        }

        // "PostAuthorizeRequest" - Occurs when the user for the current request has been authorized.
        protected void Application_PostAuthorizeRequest()
        {
            Debug.WriteLine("Application_PostAuthorizeRequest");
            Response.Write("<p>Application_PostAuthorizeRequest</p>");
        }

        // "ResolveRequestCache" - Occurs when ASP.NET finishes an authorization event to let the caching modules serve requests from the cache, bypassing execution of the event handler (for example, a page or an XML Web service).
        protected void Application_ResolveRequestCache()
        {
            Debug.WriteLine("Application_ResolveRequestCache");
            Response.Write("<p>Application_ResolveRequestCache</p>");
        }

        // "PostResolveRequestCache" - Occurs when ASP.NET bypasses execution of the current event handler and allows a caching module to serve a request from the cache.
        protected void Application_PostResolveRequestCache()
        {
            Debug.WriteLine("Application_PostResolveRequestCache");
            Response.Write("<p>Application_PostResolveRequestCache</p>");
        }

        // "MapRequestHandler" - Occurs when the handler is selected to respond to the request.
        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Application_MapRequestHandler");
            Response.Write("<p>Application_MapRequestHandler</p>");
        }

        // "PostMapRequestHandler" - Occurs when ASP.NET has mapped the current request to the appropriate event handler.
        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Application_PostMapRequestHandler");
            Response.Write("<p>Application_PostMapRequestHandler</p>");

            //We can change here set request handler to our own 
        }

        // "AcquireRequestState" - Occurs when ASP.NET acquires the current state (for example, session state) that is associated with the current request.
        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Application_AcquireRequestState");
            Response.Write("<p>Application_AcquireRequestState</p>");
        }

        // "PostAcquireRequestState" - Occurs when the request state (for example, session state) that is associated with the current request has been obtained.
        protected void Application_PostAcquireRequestState()
        {
            Debug.WriteLine("Application_PostAcquireRequestState");
            Response.Write("<p>Application_PostAcquireRequestState</p>");
        }

        // "PreRequestHandlerExecute" - Occurs just before ASP.NET starts executing an event handler (for example, a page or an XML Web service).
        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Application_PreRequestHandlerExecute");
            Response.Write("<p>Application_PreRequestHandlerExecute</p>");
        }

        // "PostRequestHandlerExecute" - Occurs when the ASP.NET event handler (for example, a page or an XML Web service) finishes execution.
        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Application_PostRequestHandlerExecute");
            Response.Write("<p>Application_PostRequestHandlerExecute</p>");
        }

        // "ReleaseRequestState" - Occurs after ASP.NET finishes executing all request event handlers. This event causes state modules to save the current state data.
        protected void Application_ReleaseRequestState()
        {
            Debug.WriteLine("Application_ReleaseRequestState");
            Response.Write("<p>Application_ReleaseRequestState</p>");
        }

        // "PostReleaseRequestState" - Occurs when ASP.NET has completed executing all request event handlers and the request state data has been stored.
        protected void Application_PostReleaseRequestState()
        {
            Debug.WriteLine("Application_PostReleaseRequestState");
            Response.Write("<p>Application_PostReleaseRequestState</p>");
        }

        // "UpdateRequestCache" - Occurs when ASP.NET finishes executing an event handler in order to let caching modules store responses that will be used to serve subsequent requests from the cache.
        protected void Application_UpdateRequestCache()
        {
            Debug.WriteLine("Application_UpdateRequestCache");
            Response.Write("<p>Application_UpdateRequestCache</p>");
        }

        // "PostUpdateRequestCache" - Occurs when ASP.NET finishes updating caching modules and storing responses that are used to serve subsequent requests from the cache.
        protected void Application_PostUpdateRequestCache()
        {
            Debug.WriteLine("Application_PostUpdateRequestCache");
            Response.Write("<p>Application_PostUpdateRequestCache</p>");
        }

        // "LogRequest" - Occurs just before ASP.NET performs any logging for the current request.
        protected void Application_LogRequest()
        {
            Debug.WriteLine("Application_LogRequest");
            Response.Write("<p>Application_LogRequest</p>");
        }

        // "PostLogRequest" - Occurs when ASP.NET has completed processing all the event handlers for the <see cref="E:System.Web.HttpApplication.LogRequest" /> event.
        protected void Application_PostLogRequest()
        {
            Debug.WriteLine("Application_PostLogRequest");
            Response.Write("<p>Application_PostLogRequest</p>");
        }

        // "EndRequest" - Occurs as the last event in the HTTP pipeline chain of execution when ASP.NET responds to a request.
        protected void Application_EndRequest()
        {
            Debug.WriteLine("Application_EndRequest");
            Response.Write("<p>Application_EndRequest</p>");
        }

        // "Error" - Occurs when an unhandled exception is thrown.
        protected void Application_Error()
        {
            Debug.WriteLine("Application_Error");
            Response.Write("<p>Application_Error</p>");
        }

        // "PreSendRequestHeaders" - Occurs just before ASP.NET sends HTTP headers to the client.
        protected void Application_PreSendRequestHeaders()
        {
            Debug.WriteLine("Application_PreSendRequestHeaders");
            Response.Write("<p>Application_PreSendRequestHeaders</p>");
        }

        // "PreSendRequestContent" - Occurs just before ASP.NET sends content to the client.
        protected void Application_PreSendRequestContent()
        {
            Debug.WriteLine("Application_PreSendRequestContent");
            Response.Write("<p>Application_PreSendRequestContent</p>");
        }

        // "RequestCompleted" - Occurs when the managed objects that are associated with the request have been released.
        protected void Application_RequestCompleted()
        {
            Debug.WriteLine("Application_RequestCompleted");
            //HttpContext does not exist anymore
            //Response.Write("<p>Application_RequestCompleted");
        }

        protected void Application_End()
        {
            Debug.WriteLine("Application_End");
            //HttpContext does not exist anymore
            //Response.Write("<p>Application_End");
        }
    }
}
