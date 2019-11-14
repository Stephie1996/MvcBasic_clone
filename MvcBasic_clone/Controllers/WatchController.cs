using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_clone.Controllers
{
    public class WatchController : Controller
    {
        // GET: Watch
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WatchPage()
        {
            return View();
        }
    }
}