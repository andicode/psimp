using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using System.Reflection;
using PSIMP.Models;
namespace PSIMP.Web.Controllers
{
    public class StatisticsController : Controller
    {
        private Dictionary<int, string> Reports = new Dictionary<int, string>();
       
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            Reports.Add(3, "rp_person");
            Reports.Add(4, "rp_person");
            Reports.Add(5, "rp_person");
            Reports.Add(6, "rp_person");
            Reports.Add(7, "rp_person");
            Reports.Add(8, "rp_person");
            Reports.Add(9, "rp_person");
            Reports.Add(10, "rp_person");
            Reports.Add(11, "rp_person");
            Reports.Add(12, "rp_person");
            Reports.Add(13, "rp_person");
            Reports.Add(14, "rp_person");
            Reports.Add(15, "rp_person");
            Reports.Add(16, "rp_person");
            Reports.Add(17, "rp_person");
            base.Initialize(requestContext);
        }
        //
        // GET: /Query/
        public ActionResult Frame()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UI_Search()
        {
            return this.ComponentConfig();
        }
        public ActionResult UI_AdvancedSearch()
        {
            return this.ComponentConfig();
        }

        public ActionResult UI_Reports()
        {
            return this.ComponentConfig();
        }
        public ActionResult UI_Report(int id)
        {
            string name = ReportList.GetReports().SingleOrDefault(m => m.ID == id.ToString()).Name;
            return this.ComponentConfig("UI_Report", new ReportViewModel { ReportName=name,ReportAction= Reports[id]});
        }
        public ActionResult rp_person()
        {
            return View();
        }
    }
}
