using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
namespace PSIMP.Web.Controllers
{
    public class AdministrationController : Controller
    {
        //
        // GET: /Performance/

        public ActionResult Frame()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PerformanceUI()
        {
            return View();
        }

        public ActionResult GanttData()
        {
            return Content("");
        }
    }
}
