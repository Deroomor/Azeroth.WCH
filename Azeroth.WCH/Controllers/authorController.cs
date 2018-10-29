using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azeroth.WCH.Controllers
{
    public class AuthorController : BaseController
    {
        // GET: author
        public ActionResult Index()
        {
            return View();
        }
    }
}