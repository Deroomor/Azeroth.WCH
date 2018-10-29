using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Flows.Controllers
{
    /// <summary>
    /// 请假
    /// </summary>
    public class LeaveController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Flows/Leave/
        public ActionResult Index()
        {
            return View();
        }
	}
}