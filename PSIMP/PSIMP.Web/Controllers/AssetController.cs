using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSIMP.Web.Controllers
{
    public class AssetController : Controller
    {
        //
        // GET: /Asset/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AssetUI()
        {
            return View();
        }

    }
}
