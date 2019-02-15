using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Areas.Attendance.Controllers
{
    public class SchedulController : WCH.Controllers.BaseController
    {
        // GET: Attendance/Schedul
        public ActionResult Index()
        {
            return View();
        }
    }
}