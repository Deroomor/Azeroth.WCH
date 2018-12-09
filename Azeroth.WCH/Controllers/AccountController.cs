using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    public class AccountController : Controller
    {
       public  IBll.IUserInfo BllUserInfo { set; get; }

        // GET: Account
        public ActionResult Login()
        {
            return View();
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

        public ActionResult SignIn(Model.DTO.LoginInput parameter)
        {
            if (!this.ModelState.IsValid)
                throw new ArgumentException("用户名和密码不能为空");
            var userInfo= this.BllUserInfo.ValidateSignIn(parameter);
            if (userInfo==null)
                return this.Json(new Common.RT("用户名或密码错误",string.Empty, System.Net.HttpStatusCode.Unauthorized) );
            System.Web.Security.FormsAuthentication.SetAuthCookie(userInfo.Id.ToString(), true);
            var target= System.Web.Security.FormsAuthentication.GetRedirectUrl(string.Empty, true);
           return  this.Json(new Common.RT(string.Empty,target));
        }

        public ActionResult Signout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return this.Redirect(System.Web.Security.FormsAuthentication.LoginUrl);

        }
    }
}