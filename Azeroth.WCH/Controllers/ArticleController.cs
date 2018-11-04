using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    [Common.FunctionComment("随笔")]
    public class ArticleController : BaseController
    {
        [Common.FunctionComment("新随笔")]
        public ActionResult Index()
        {
            return View();
        }
        [Common.FunctionComment("编辑")]
        public ActionResult Edit()
        {
            return View();
        }
        [Common.FunctionComment("正文")]
        public ActionResult Play()
        {
            return View();
        }
    }
}