using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Wages.Controllers
{
    /// <summary>
    /// 考勤
    /// </summary>
    public class AttendanceController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Wages/Attendance/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            throw new ArgumentException("月份格式不正确");
            return View();
        }
	}
}