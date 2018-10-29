using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Wages.Controllers
{
    /// <summary>
    /// 奖惩
    /// </summary>
    public class OnceSalaryController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Wages/OnceSalary/
        public ActionResult Index()
        {
            return View();
        }
	}
}