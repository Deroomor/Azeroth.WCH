using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Flows.Controllers
{
    /// <summary>
    /// 出差
    /// </summary>
    public class BusinessTravelController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Flows/BusinessTravel/
        public ActionResult Index()
        {
            return View();
        }
	}
}