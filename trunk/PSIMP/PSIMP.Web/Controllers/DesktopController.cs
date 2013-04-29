using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSIMP.Web.Controllers
{
    public class DesktopController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "工程监理信息化管理平台";
            //if (!WebMatrix.WebData.WebSecurity.IsAuthenticated)
            //{
            //    return RedirectToAction("Login", "Account");
            //}
            return View(DesktopFrame.Modules());
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}
