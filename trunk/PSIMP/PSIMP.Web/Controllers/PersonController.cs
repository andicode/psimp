using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using PSIMP.Models;
//using PSIMP.Repository;
using System.IO;
using PSIMP.Repository;
namespace PSIMP.Web.Controllers
{
    [DirectController(GenerateProxyForOtherAreas=true,GenerateProxyForOtherControllers=true)]
    public class PersonController : Controller
    {
        private  DBContext<PM_PersonBaseInfo> PersonService { get; set; }
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            PersonService = new DBContext<PM_PersonBaseInfo>();
            //EducationService = new DBContext<Education>();
            //TrainService = new DBContext<Train>();
            base.Initialize(requestContext);
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersionUI(string containerId)
        {
            return this.ComponentConfig();
        }

        public ActionResult GetPersons()
        {
            var data = PersonService.GetAll();
            return this.Store(data, 1);
        }

        public ActionResult Edit()
        {
            return this.PartialExtView();
        }
        
        public ActionResult Delete(long id,string picture)
        {
            X.GetCmp<Store>("Person_Store").Reload();
            return this.Direct();
        }       
    }
}
