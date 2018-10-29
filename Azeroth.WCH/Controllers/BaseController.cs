using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Au/
        protected override void OnAuthentication(System.Web.Mvc.Filters.AuthenticationContext filterContext)
        {
            var lstMenu = WCH.Models.MenuInfo.GetList();
            this.ViewData["lstMenu"] = lstMenu;
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            //throw new ArgumentException("没有权限");
            // filterContext.Result = this.View("~/Views/Home/NoAuthorization.cshtml");
            //base.OnAuthorization(filterContext);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if(!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                this.ViewData["ErrorMsg"] = filterContext.Exception.Message;
                filterContext.Result = this.View("~/Views/Home/OnException.cshtml");
                filterContext.ExceptionHandled = true;
            }
        }

      


    }
}