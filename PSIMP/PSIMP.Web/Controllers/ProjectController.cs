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
        public ActionResult Index()
        {
            return this.View();
        }
        public ActionResult UI_BasicInfo()
        {
            return this.ComponentConfig();
        }
        public ActionResult UI_Project(string id)
        {
            return this.ComponentConfig();
        }
    }
}
