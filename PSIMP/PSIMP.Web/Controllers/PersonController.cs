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

        public ActionResult Edit()
        {
            return this.PartialExtView();
        }

        public ActionResult Delete(long id,string picture)
        {
            DeletePicture(picture);
            PersonService.CompletelyDelete(id);
            X.GetCmp<Store>("Person_Store").Reload();
            return this.Direct();
        }
        [HttpPost]
        public ActionResult Save(Person person, HttpPostedFileBase TempPicture)
        {
            if (person.IsAdd())
            {
                #region onCreate
                if (TempPicture != null)
                {
                    var newImage = Guid.NewGuid().ToString() + TempPicture.FileName;
                    TempPicture.SaveAs(Server.MapPath("~/Images/Person/" + newImage));
                    person.Picture = newImage;
                }
                else
                {
                    person.Picture = "default.jpg";
                }
                PersonService.Add(person);
                X.GetCmp<Hidden>("person_Info_Id").SetValue(person.Id);
                X.GetCmp<Hidden>("person_info_picture").SetValue(person.Picture);
                X.GetCmp<Store>("Person_Store").Reload();
                #endregion
            }
            else
            {
                #region onEdit
                if (TempPicture != null)
                {
                    var newImage = Guid.NewGuid().ToString() + TempPicture.FileName;
                    TempPicture.SaveAs(Server.MapPath("~/Images/Person/" + newImage));
                    
                        DeletePicture(person.Picture);
                    
                    person.Picture = newImage;
                }
                PersonService.Update(person);
                X.GetCmp<Hidden>("person_info_picture").SetValue(person.Picture);
                X.GetCmp<Store>("Person_Store").Reload();
                #endregion
            }
            var result = this.Direct();
            result.IsUpload = true;
            return result;
        }
        public ActionResult GetPersons(StoreRequestParameters parameters)
        {
            var persons = PersonService.GetPagesData(parameters.Start, parameters.Limit);
            return this.Store(persons, PersonService.Count());
        }



        private void DeletePicture(string picture)
        {
            if (string.IsNullOrEmpty(picture) || picture == "default.jpg")
            {
                return;
            }
            if (System.IO.File.Exists(Server.MapPath("~/Images/Person/" + picture)))
            {
                System.IO.File.Delete(Server.MapPath("~/Images/Person/" + picture));
            }
        }
    }
}
