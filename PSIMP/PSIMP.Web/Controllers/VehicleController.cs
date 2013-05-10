using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
namespace PSIMP.Web.Controllers
{
    public class VehicleController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        //基础信息
        public ActionResult UI_BasicInfo()
        {
            return this.ComponentConfig();
        }
        //贷款/还款信息
        public ActionResult UI_LoanRepayment()
        {
            return this.ComponentConfig();
        }
    }
}
