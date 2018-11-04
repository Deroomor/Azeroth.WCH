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
        static Func<string, bool, string> GetLoginPage =  (Func<string,bool,string>)System.Delegate.CreateDelegate(typeof(Func<string,bool,string>), 
            typeof(System.Web.Security.FormsAuthentication).GetMethod("GetLoginPage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static, null,new Type[] { typeof(string), typeof(bool) }, null));

        protected override void OnAuthentication(System.Web.Mvc.Filters.AuthenticationContext filterContext)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                var loginurl= GetLoginPage(null, false);
                filterContext.Result = this.Redirect(loginurl);
                return;
            }
            System.Web.Security.FormsAuthentication.SetAuthCookie(this.User.Identity.Name, true);
            var userinfo = this.Session["userInfo"] as Model.DTO.UserInfo;
            userinfo = userinfo ?? new Model.DTO.UserInfo() {  Id=new Guid(this.User.Identity.Name), Name=System.IO.Path.GetRandomFileName()};
            this.Session["userInfo"] = userinfo;
            var lstMenu = Model.DTO.MenuInfo.GetList();
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