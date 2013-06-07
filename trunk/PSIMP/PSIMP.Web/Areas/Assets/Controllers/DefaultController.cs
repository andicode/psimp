using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;

namespace PSIMP.Web.Areas.Assets.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Assets/Default/

        public ActionResult Index()
        {
            return this.ComponentConfig();
        }
        public ActionResult GetAssets()
        {
            return this.Store(null, 0);
        }

        public ActionResult AssetInfo(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.PartialExtView();
            }
            return this.PartialExtView();
        }
    }
}
