using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using Ext.Net;

namespace PSIMP.Web.Areas.Assets.Controllers
{
    public class UseController : Controller
    {
        //
        // GET: /Assets/Use/

        public ActionResult Index()
        {
            return this.ComponentConfig();
        }

    }
}
