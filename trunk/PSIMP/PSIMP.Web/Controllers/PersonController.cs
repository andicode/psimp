using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using PSIMP.Models;
using PSIMP.Repository;
namespace PSIMP.Web.Controllers
{
    public class PersonController : Controller
    {
        DBContext db = new DBContext();
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
            return this.PartialExtView(new Person());
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

            db.Add(person);
            X.Msg.Alert("保存成功", "已经添加到成功").Show();
            X.GetCmp<Hidden>("person_Info_Id").SetValue(person.Id);
            return this.Direct();
        }
        public ActionResult GetPersons(StoreRequestParameters parameters)
        {
            return this.Store(db.GetAll<Person>(), 6);
        }

        public ActionResult Picture(long id)
        {
            var person= db.Get<Person>(id);
            if (person != null && person.Picture != null)
            {
                return File(person.Picture, "image/jpeg");
            }
            return File(Server.MapPath("~/Images/default_image_male.jpg"), "image/png");
        }

    }
}
