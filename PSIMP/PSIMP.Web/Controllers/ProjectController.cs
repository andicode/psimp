using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;

namespace PSIMP.Web.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Project/
        public ActionResult Frame()
        {
            return View();
        }
        public ActionResult Index()
        {
            return this.ComponentConfig();
        }

        public ActionResult ProjectUI()
        {
            return View();
        }
        public ActionResult GetConstructions()
        {
            return this.Store(new List<object> { new { Id = "1", f1 = "某公路建设公司", f2 = "200(Km)", f3 = "?", f4 = "土建工程", f5 = "200万", f6 = "四川xxxxxx", f7 = "133****1234", f8 = "王某" } }, 1);
        }

        public ActionResult GetContracts()
        {
            return this.Store(new List<object> { new { Id = "1", f1 = "某合同段简称", f2 = "某合同段全称", f3 = "K333-K444", f4 = "200", f5 = "2013-4-8", f6 = "?", f7 = "?" } }, 1);
        }

        public ActionResult GetProjects()
        {
            return this.Store(new List<object> { new { Id = "1", ProjectName = "某工程", GK = "正在建设.....", YZ = "某业主公司", JL = "某监理公司" } }, 1);
        }

    }
}
