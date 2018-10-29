using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Azeroth.WCH
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //System.Web.Mvc.GlobalFilters.Filters.Add(new ErrorHandler());
            //this.BeginRequest += MvcApplication_BeginRequest;
            //this.PostAuthenticateRequest += MvcApplication_PostAuthenticateRequest;
            //this.PostMapRequestHandler += MvcApplication_PostMapRequestHandler;
            //this.EndRequest += MvcApplication_EndRequest;
            //this.Error += MvcApplication_Error;
        }

        public override void Init()
        {
            this.Error+=MvcApplication_Error;
            this.EndRequest += MvcApplication_EndRequest;
        }

        void MvcApplication_EndRequest(object sender, EventArgs e)
        {
            int abd = 4444444;
        }

        void MvcApplication_PostMapRequestHandler(object sender, EventArgs e)
        {
            int cc = 4;
        }

        void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {
            int cc = 4;
        }

        void MvcApplication_BeginRequest(object sender, EventArgs e)
        {
            int b = 4;
        }

        void MvcApplication_Error(object sender, EventArgs e)
        {
            
            int a = 3;
        }
    }

    public class ErrorHandler:System.Web.Mvc.HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            
            base.OnException(filterContext);
        }
    }
}
