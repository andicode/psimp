using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
namespace PSIMP.Web.Controllers
{
    public class QueryController : Controller
    {
        //
        // GET: /Query/
        public ActionResult Frame()
        {
            return View();
        }
        public ActionResult Index()
        {
            return this.ComponentConfig();
        }
        public ActionResult QueryUI()
        {
            return View();
        }
    }
}
