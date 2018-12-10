using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    [Common.FunctionComment("文章")]
    public class ArticleController : BaseController
    {
        [Common.FunctionComment("页面-详情")]
        public ActionResult Index()
        {
            return View();
        }

        [Common.FunctionComment("页面-新文章")]
        public ActionResult Paper()
        {
            return View();
        }

        public ActionResult Save()
        {
            System.Threading.Thread.Sleep(2*1000);
            return this.Json(new Common.RT() { Status = System.Net.HttpStatusCode.ExpectationFailed,Msg="保存失败" });
        }
    }
}