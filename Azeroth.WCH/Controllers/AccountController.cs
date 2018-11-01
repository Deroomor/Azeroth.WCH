using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [System.Web.Mvc.HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.UserInfo userInfo)
        {
            userInfo = userInfo ?? new Models.UserInfo();
            this.ViewData["userInfo"] = userInfo;
            if (string.IsNullOrEmpty(userInfo.Name) || string.IsNullOrEmpty(userInfo.Password))
                return View();
            if (userInfo.Password != "123")
                return this.View();
            userInfo.Id = Guid.NewGuid();
            this.Session["userInfo"] = userInfo;
            System.Web.Security.FormsAuthentication.SetAuthCookie(userInfo.Id.ToString(), true);
            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(userInfo.Id.ToString(), true);
            return this.Redirect(System.Web.Security.FormsAuthentication.DefaultUrl);
        }

        public ActionResult Signout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return this.Redirect(System.Web.Security.FormsAuthentication.LoginUrl);

        }
    }
}