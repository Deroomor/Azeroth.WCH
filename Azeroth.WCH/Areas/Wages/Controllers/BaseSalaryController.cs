using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Wages.Controllers
{
    /// <summary>
    /// 底薪
    /// </summary>
    public class BaseSalaryController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Wages/BaseSalary/
        public ActionResult Index()
        {
            return View();
        }
	}
}