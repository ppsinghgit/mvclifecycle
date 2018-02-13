using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LifeCycleMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        int count = 0;
        protected void Application_Start()
        {
            Debug.Flush();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            count++;
            Debug.WriteLine(string.Concat(count, " Application_Start"));
        }

        protected void Application_AcquireRequestState()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_AcquireRequestState"));
        }
        protected void Application_AuthenticateRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_AuthenticateRequest"));
        }
        protected void Application_AuthorizeRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_AuthorizeRequest"));
        }
        protected void Application_BeginRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_BeginRequest", "----------------------------------------- Req Begin"));
        }
        protected void Application_Disposed()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_Disposed"));
        }
        protected void Application_EndRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_EndRequest", "----------------------------------------- Req End"));
        }
        protected void Application_Error()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_Error"));
        }
        protected void Application_LogRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_LogRequest"));
        }
        protected void Application_MapRequestHandler()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_MapRequestHandler"));
        }
        protected void Application_PostAcquireRequestState()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostAcquireRequestState"));
        }
        protected void Application_PostAuthenticateRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostAuthenticateRequest"));
        }
        protected void Application_PostAuthorizeRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostAuthorizeRequest"));
        }
        protected void Application_PostLogRequest()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostLogRequest"));
        }
        protected void Application_PostMapRequestHandler()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostMapRequestHandler"));
        }
        protected void Application_PostReleaseRequestState()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostReleaseRequestState"));
        }
        protected void Application_PostRequestHandlerExecute()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostRequestHandlerExecute"));
        }
        protected void Application_PostResolveRequestCache()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostResolveRequestCache"));
        }
        protected void Application_PostUpdateRequestCache()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PostUpdateRequestCache"));
        }
        protected void Application_PreRequestHandlerExecute()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PreRequestHandlerExecute"));
        }

        protected void Application_PreSendRequestContent()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PreSendRequestContent"));
        }
        protected void Application_PreSendRequestHeaders()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_PreSendRequestHeaders"));
        }
        protected void Application_ReleaseRequestState()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_ReleaseRequestState"));
        }
        protected void Application_RequestCompleted()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_RequestCompleted"));
            count = 0;
        }
        protected void Application_ResolveRequestCache()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_ResolveRequestCache"));
        }
        protected void Application_UpdateRequestCache()
        {
            count++;
            Debug.WriteLine(string.Concat(count, " Application_UpdateRequestCache"));
        }

    }
}
