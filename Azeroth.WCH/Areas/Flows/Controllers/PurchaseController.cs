using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Flows.Controllers
{
    /// <summary>
    /// 请购
    /// </summary>
    public class PurchaseController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Flows/Purchase/
        public ActionResult Index()
        {
            return View();
        }
	}
}