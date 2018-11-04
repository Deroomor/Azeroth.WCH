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
        public ActionResult Login(Model.DTO.UserInfo userInfo)
        {
            userInfo = userInfo ?? new Model.DTO.UserInfo();
            this.ViewData["userInfo"] = userInfo;
            if (string.IsNullOrEmpty(userInfo.Name) || string.IsNullOrEmpty(userInfo.Password))
                return View();
            if (userInfo.Password != "123")
                return this.View();
            userInfo.Id = Guid.NewGuid();
            this.Session["userInfo"] = userInfo;
            System.Web.Security.FormsAuthentication.SetAuthCookie(userInfo.Id.ToString(), true);
            var target= System.Web.Security.FormsAuthentication.GetRedirectUrl(string.Empty, true);
            return this.Redirect(target);
        }

        public ActionResult Signout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return this.Redirect(System.Web.Security.FormsAuthentication.LoginUrl);

        }
    }
}