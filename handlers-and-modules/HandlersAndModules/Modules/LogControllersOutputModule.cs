using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace HandlersAndModules.Modules
{
    public class LogControllersOutputModule : IHttpModule
    {
        private HttpApplication _context;

        public void Init(HttpApplication context)
        {
            _context = context;
            _context.BeginRequest += ContextOnBeginRequest;
            _context.EndRequest += ContextOnEndRequest;
        }

        private void ContextOnBeginRequest(object sender, EventArgs eventArgs)
        {
            string requestBody;
            using (var steamReader = new StreamReader(_context.Request.InputStream))
            {
                requestBody = steamReader.ReadToEnd();
            }

            var logObject = new LogRequestResponse
            {
                Body = requestBody,
                Headers = _context.Request.Headers
                    .AllKeys.Aggregate(string.Empty, (current, key) => current + $"{key}: {_context.Request.Headers[key]},\n"),
                HttpMethod = _context.Request.HttpMethod
            };
            Debug.WriteLine(logObject.ToString());


            HttpResponse response = HttpContext.Current.Response;
            OutputFilterStream filter = new OutputFilterStream(response.Filter);
            response.Filter = filter;
        }

        private void ContextOnEndRequest(object sender, EventArgs eventArgs)
        {
            var logObject = new LogRequestResponse
            {
                Body = ((OutputFilterStream)_context.Response.Filter).ReadStream(),
                Headers = _context.Response.Headers
                    .AllKeys.Aggregate(string.Empty, (current, key) => current + $"{key}: {_context.Response.Headers[key]},\n"),
                HttpMethod = _context.Request.HttpMethod
            };
            Debug.WriteLine(logObject.ToString());
        }

        public void Dispose()
        {
            
        }

        private class LogRequestResponse
        {
            public string Headers { private get; set; }
            public string Body { private get; set; }
            public string HttpMethod { private get; set; }

            public override string ToString()
            {
                return $"HttpMethod: {HttpMethod}\nHeaders: \n{Headers}\n\nBody:\n{Body}";
            }

        }
    }
}