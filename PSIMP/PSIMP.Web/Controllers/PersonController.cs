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
            base.Initialize(requestContext);
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetPersons()
        {
            var data = PersonService.GetAll();
            return this.Store(data, PersonService.Count());
        }

        public ActionResult PersonInfo(string id)
        {
            return this.ComponentConfig();
        }
        [HttpPost]
        public ActionResult Save(PM_PersonBaseInfo person, HttpPostedFileBase TempPicture)
        {
            if (person.IsCreate)
            {
                PersonService.Add(person);
            }
            X.GetCmp<FormPanel>("Person_Basic_Info").SetValues(person);
            var result = this.Direct();
            result.IsUpload = true;
            return result;
        }
        public ActionResult Photo(string id)
        {
            var person=PersonService.Get(id);
            if(person.TwoInchPhoto==null)
            {
                return File(Server.MapPath("~/Images/Person/default.jpg"), "image/jpeg");
            }
            else
            {
                return File(person.TwoInchPhoto,"image/jpeg");
            }
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
