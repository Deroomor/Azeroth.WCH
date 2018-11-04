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
        [Common.FunctionComment("页面-新文章")]
        public ActionResult Index()
        {
            return View();
        }
        [Common.FunctionComment("页面-编辑文章")]
        public ActionResult Edit()
        {
            return View();
        }
        [Common.FunctionComment("页面-文章详情")]
        public ActionResult Play()
        {
            return View();
        }
    }
}