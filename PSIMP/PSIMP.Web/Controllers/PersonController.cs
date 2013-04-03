using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using PSIMP.Web.Models;
namespace PSIMP.Web.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersionUI(string containerId)
        {
            return this.ComponentConfig();
        }
        public ActionResult Create()
        {
            return this.PartialExtView();
        }
        public ActionResult Edit()
        {
            return this.PartialExtView();
        }
        [HttpPost]
        public ActionResult Save()
        {
            X.Msg.Alert("保存成功", "已经添加到成功").Show();
            return this.Direct();
        }
        public ActionResult GetPersons(StoreRequestParameters parameters)
        {
            return this.Store(PSIMP.Web.Models.PersonModel.GetAll(), 6);
        }

    }
}
