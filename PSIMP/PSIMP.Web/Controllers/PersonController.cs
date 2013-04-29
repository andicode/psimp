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
namespace PSIMP.Web.Controllers
{
    [DirectController(GenerateProxyForOtherAreas=true,GenerateProxyForOtherControllers=true)]
    public class PersonController : Controller
    {
        //public DBContext<Person> PersonService { get; set; }
        //public DBContext<Education> EducationService { get; set; }
        //public DBContext<Train> TrainService { get; set; }


        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            //PersonService = new DBContext<Person>();
            //EducationService = new DBContext<Education>();
            //TrainService = new DBContext<Train>();
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
            //DeletePicture(picture);
            //PersonService.CompletelyDelete(id);
            X.GetCmp<Store>("Person_Store").Reload();
            return this.Direct();
        }
        [HttpPost]
        public ActionResult Save(Person person, HttpPostedFileBase TempPicture)
        {
            //if (person.IsAdd())
            //{
            //    #region onCreate
            //    if (TempPicture != null)
            //    {
            //        var newImage = Guid.NewGuid().ToString() + TempPicture.FileName;
            //        TempPicture.SaveAs(Server.MapPath("~/Images/Person/" + newImage));
            //        person.Picture = newImage;
            //    }
            //    else
            //    {
            //        person.Picture = "default.jpg";
            //    }
            //    PersonService.Add(person);
            //    X.GetCmp<Hidden>("person_Info_Id").SetValue(person.Id);
            //    X.GetCmp<Hidden>("person_info_picture").SetValue(person.Picture);
            //    X.GetCmp<Store>("Person_Store").Reload();
            //    #endregion
            //}
            //else
            //{
            //    #region onEdit
            //    if (TempPicture != null)
            //    {
            //        var newImage = Guid.NewGuid().ToString() + TempPicture.FileName;
            //        TempPicture.SaveAs(Server.MapPath("~/Images/Person/" + newImage));
                    
            //            DeletePicture(person.Picture);
                    
            //        person.Picture = newImage;
            //    }
            //    PersonService.Update(person);
            //    X.GetCmp<Hidden>("person_info_picture").SetValue(person.Picture);
            //    X.GetCmp<Store>("Person_Store").Reload();
            //    #endregion
            //}
            var result = this.Direct();
            result.IsUpload = true;
            return result;
        }

        //public ActionResult GetPersons(StoreRequestParameters parameters)
        //{
        //    //var persons = PersonService.GetPagesData(parameters.Start, parameters.Limit);
        //    //return this.Store(persons, PersonService.Count());
        //}

        //#region 教育背景
        //public ActionResult GetEducations(long id,StoreRequestParameters parameters)
        //{
        //    var educations = EducationService
        //        .Where(m=>m.PersonId==id)
        //        .GetPagesData(parameters.Start, parameters.Limit);
        //    return this.Store(educations, 
        //        EducationService.Count(m => m.PersonId == id));
 
        //}
        //[DirectMethod]
        //public ActionResult SaveEdu(bool isPhantom,long personId, string values)
        //{
        //    var edu = JSON.Deserialize<Education>(values);
        //    edu.PersonId = personId;
        //    if (isPhantom)
        //    {
        //        EducationService.Add(edu);
        //    }
        //    else
        //    {
        //        EducationService.Update(edu);
        //    }
        //    return Json(new {Id=edu.Id, valid = true });
        //}
        //[AcceptVerbs(HttpVerbs.Post)]   
        //public ActionResult DeleteEdu(long id)
        //{
        //    EducationService.CompletelyDelete(id);
        //    return this.Direct();
        //}
        //#endregion

        //#region 培训经历
        //public ActionResult GetTrains(long id, StoreRequestParameters parameters)
        //{
        //    var educations = EducationService
        //        .Where(m => m.PersonId == id)
        //        .GetPagesData(parameters.Start, parameters.Limit);
        //    return this.Store(educations,
        //        EducationService.Count(m => m.PersonId == id));

        //}
        //[DirectMethod]
        //public ActionResult SaveTrain(bool isPhantom, long personId, string values)
        //{
        //    var edu = JSON.Deserialize<Train>(values);
        //    edu.PersonId = personId;
        //    if (isPhantom)
        //    {
        //        TrainService.Add(edu);
        //    }
        //    else
        //    {
        //        TrainService.Update(edu);
        //    }
        //    return Json(new { Id = edu.Id, valid = true });
        //}
        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult DeleteTrain(long id)
        //{
        //    TrainService.CompletelyDelete(id);
        //    return this.Direct();
        //}
        //#endregion

        //private void DeletePicture(string picture)
        //{
        //    if (string.IsNullOrEmpty(picture) || picture == "default.jpg")
        //    {
        //        return;
        //    }
        //    if (System.IO.File.Exists(Server.MapPath("~/Images/Person/" + picture)))
        //    {
        //        System.IO.File.Delete(Server.MapPath("~/Images/Person/" + picture));
        //    }
        //}
    }
}
