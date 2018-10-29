using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Wages.Controllers
{
    public class BonusController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Wages/Bonus/
        public ActionResult Index()
        {
            return View();
        }
	}
}