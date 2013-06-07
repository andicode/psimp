using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;

namespace PSIMP.Web.Areas.Persons.Controllers
{
    public class ContractsController : Controller
    {
        //
        // GET: /Persons/Contracts/

        public ActionResult Index()
        {
            return this.ComponentConfig();
        }
        public ActionResult GetContracts()
        {
            return this.Store(null, 0);
        }

    }
}
