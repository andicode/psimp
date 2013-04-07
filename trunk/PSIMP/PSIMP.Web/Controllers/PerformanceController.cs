using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSIMP.Web.Controllers
{
    public class PerformanceController : Controller
    {
        //
        // GET: /Performance/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PerformanceUI()
        {
            return View();
        }
    }
}
