using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (!this.User.Identity.IsAuthenticated)
                System.Web.Security.FormsAuthentication.RedirectToLoginPage();
            System.Web.Security.FormsAuthentication.SetAuthCookie(this.User.Identity.Name, true);
            var userinfo = this.Session["userInfo"] as Models.UserInfo;
            userinfo = userinfo ?? new Models.UserInfo() {  Id=new Guid(this.User.Identity.Name), Name=System.IO.Path.GetRandomFileName()};
            this.Session["userInfo"] = userinfo;
            var lstMenu = WCH.Models.MenuInfo.GetList();
            this.ViewData["lstMenu"] = lstMenu;
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            //throw new ArgumentException("没有权限");
            //filterContext.Result = this.View("~/Views/Home/NoAuthorization.cshtml");
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

        protected internal new JsonResult Json(object data)
        {
            return this.Json(data, JsonRequestBehavior.AllowGet);
        }



    }
}