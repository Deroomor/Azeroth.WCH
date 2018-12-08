using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Azeroth.WCH.Controllers
{
    public class BaseController : Controller
    {
        public   IBll.IUserInfo BllUserInfo { set; get; }

        /// <summary>
        /// 微软不公开这个方法。。。
        /// </summary>
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
            string id = this.User.Identity.Name;
            System.Web.Security.FormsAuthentication.SetAuthCookie(this.User.Identity.Name, true);
            var userInfo = this.Session.GetValue(SessionIndex.UserInfo) as Model.UserInfo;
            if(userInfo==null)//session丢失或者过期，重新从数据库取
                userInfo = this.BllUserInfo.GetById(Guid.Parse(id));
            this.Session.SetValue(SessionIndex.UserInfo, userInfo);

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
            filterContext.ExceptionHandled = true;
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                this.ViewData["ErrorMsg"] = filterContext.Exception.Message;
                filterContext.Result = this.View("~/Views/Home/OnException.cshtml");
                return;
            }
            filterContext.Result = this.Json(new Common.RT(filterContext.Exception.Message, string.Empty, System.Net.HttpStatusCode.InternalServerError));
        }

        protected internal new JsonResult Json(object data)
        {
            return this.Json(data, JsonRequestBehavior.AllowGet);
        }



    }
}