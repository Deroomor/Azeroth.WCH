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
    [Common.FunctionComment("公积金")]
    public class AccumulationController : Azeroth.WCH.Controllers.BaseController
    {
        //
        // GET: /Wages/Accumulation/
        [Common.FunctionComment("页面-列表和明细")]
        public ActionResult Index()
        {
            var type = this.HttpContext.Request["type"] ?? string.Empty;
            if (type == "detail")
                return Detail();
            return View();
        }

        private ActionResult Detail()
        {
            return View("~/Areas/Wages/Views/Accumulation/Detail.cshtml");
        }

        [Common.FunctionComment("导入")]
        public ActionResult Import()
        {
            throw new NotImplementedException();
        }

        [Common.FunctionComment("提交")]
        public ActionResult Submit()
        {
            throw new NotImplementedException();
        }

        [Common.FunctionComment("审核")]
        public ActionResult Approve()
        {
            throw new NotImplementedException();
        }
    }
}