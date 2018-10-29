using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Wages.Controllers
{
    public class EmployeeController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Wages/Employee/
        public ActionResult Index()
        {
            return View();
        }
	}
}