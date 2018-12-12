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
        public IBll.IArticle BllArticle { set; get; }
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

        public ActionResult Save(Model.Document doc)
        {
            //System.Threading.Thread.Sleep(1*1000);
            if (doc.Id == Guid.Empty)
            {
                doc.Id = Guid.NewGuid();
                this.BllArticle.Add(doc);
            }
            else
            {
                this.BllArticle.EditById(doc, x => new { x.Content, x.Title, x.ContentAbstract });
            }
            return this.Json(new Common.RT() { Status = System.Net.HttpStatusCode.OK, Msg = "保存成功", Body = new { Id = doc.Id } });
           
        }
    }
}