using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    public class AccountController : Controller
    {
        IBll.IUserInfo BllUserInfo { set; get; }

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SignIn(Model.DTO.LoginInput parameter)
        {
            if (this.ModelState.IsValid)
                throw new ValidateModelException(this.ModelState);
            var userInfo= this.BllUserInfo.ValidateSignIn(parameter);
            if (userInfo==null)
                return this.Json(new Common.RT("用户名或密码错误") {  Status= System.Net.HttpStatusCode.Unauthorized});
            System.Web.Security.FormsAuthentication.SetAuthCookie(userInfo.Id.ToString(), true);
            var target= System.Web.Security.FormsAuthentication.GetRedirectUrl(string.Empty, true);
           return  this.Json(new Common.RT("登陆成功") {  Body= new { target} });
        }

        public ActionResult Signout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return this.Redirect(System.Web.Security.FormsAuthentication.LoginUrl);

        }
    }
}