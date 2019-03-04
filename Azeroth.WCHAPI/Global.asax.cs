using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Swashbuckle.Application;
namespace Azeroth.WCHAPI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            
            System.Web.Http.GlobalConfiguration.Configuration.Routes.MapHttpRoute("apil2","{controller}/{action}");
        }
    }
}