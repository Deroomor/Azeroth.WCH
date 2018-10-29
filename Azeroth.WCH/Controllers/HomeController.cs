using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    public class HomeController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            int a = 0;
            int b = 44 / a;
            return View();
        }
	}
}