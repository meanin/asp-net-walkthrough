using System.Web;

namespace HandlersAndModules.Handlers
{
    public class DummyHandler : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p>DummyHandler</p>");
        }
    }
}