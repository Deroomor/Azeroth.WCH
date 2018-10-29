using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Wages.Controllers
{
    /// <summary>
    /// 公积金
    /// </summary>
    public class AccumulationController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Wages/Accumulation/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {

            return View();
        }
	}
}