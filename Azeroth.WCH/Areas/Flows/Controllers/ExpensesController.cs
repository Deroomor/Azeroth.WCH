using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Flows.Controllers
{
    /// <summary>
    /// 报销
    /// </summary>
    public class ExpensesController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Flows/Expenses/
        public ActionResult Index()
        {
            return View();
        }
	}
}