using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;

namespace PSIMP.Web.Areas.Persons.Controllers
{
    public class CertificatesController : Controller
    {
        //
        // GET: /Persons/Certificates/

        public ActionResult Index()
        {
            return this.ComponentConfig();
        }

        public ActionResult GetCertificates()
        {
            return this.Store(null, 0);
        }

        public ActionResult CertificateInfo(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.PartialExtView();
            }
            return this.PartialExtView();
        }
    }
}
