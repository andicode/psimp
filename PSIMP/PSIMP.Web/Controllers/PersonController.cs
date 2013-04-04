using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using PSIMP.Models;
using PSIMP.Repository;
using System.IO;
namespace PSIMP.Web.Controllers
{
    public class PersonController : Controller
    {
        public DBContext<Person> PersonService { get; set; }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            PersonService = new DBContext<Person>();
            base.Initialize(requestContext);
        }
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
            return new Ext.Net.MVC.PartialViewResult
            {
                ContainerId = "win_PersonModule",
                RenderMode = RenderMode.AddTo,
                WrapByScriptTag = false
            };
        }
        public ActionResult Edit()
        {
            return this.PartialExtView();
        }
        [HttpPost]
        public ActionResult Save(Person person, HttpPostedFileBase TempPicture)
        {
            if (TempPicture != null)
            {
                var stream = TempPicture.InputStream;
                byte[] buff = new byte[stream.Length];
                stream.Read(buff, 0, (int)stream.Length);
                person.Picture = buff;
            }
            else
            {
                person.Picture = System.IO.File.ReadAllBytes(Server.MapPath("~/Images/default_image_male.jpg"));
            }
            PersonService.Add(person);
            X.GetCmp<Hidden>("person_Info_Id").SetValue(person.Id);
            X.GetCmp<Store>("Person_Store").Reload();
            var result= this.Direct();
            result.IsUpload = true;
            return result;
        }
        public ActionResult GetPersons(StoreRequestParameters parameters)
        {
            var persons = PersonService.GetPagesData(parameters.Start, parameters.Limit);
            return this.Store(persons, PersonService.Count());
        }

        public ActionResult Picture(long id)
        {
            var person= PersonService.Get(id);
            if (person != null && person.Picture != null)
            {
                return File(person.Picture, "image/jpeg");
            }
            return File(Server.MapPath("~/Images/default_image_male.jpg"), "image/png");
        }

    }
}
