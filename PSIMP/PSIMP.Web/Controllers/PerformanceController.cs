﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
namespace PSIMP.Web.Controllers
{
    public class PerformanceController : Controller
    {
        //
        // GET: /Performance/

        public ActionResult Frame()
        {
            return View();
        }
        public ActionResult Index()
        {
            return this.ComponentConfig();
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
