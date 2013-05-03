using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using PSIMP.Models;
using System.IO;
using PSIMP.Repository;
namespace PSIMP.Web.Controllers
{
    [DirectController(GenerateProxyForOtherAreas=true,GenerateProxyForOtherControllers=true)]
    public class PersonController : Controller
    {
        private PersonRepository PersonService { get; set; }
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            PersonService = new PersonRepository();
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
                if (TempPicture != null)
                {
                    var buff = new byte[TempPicture.InputStream.Length];
                    TempPicture.InputStream.Read(buff, 0, (int)TempPicture.InputStream.Length);
                    person.TwoInchPhoto = buff;
                }
                PersonService.Add(person);
            }
            else
            {
                if (TempPicture != null)
                {
                    var buff = new byte[TempPicture.InputStream.Length];
                    TempPicture.InputStream.Read(buff, 0, (int)TempPicture.InputStream.Length);
                    person.TwoInchPhoto = buff;
                }
                PersonService.Update(person);
            }
            X.GetCmp<FormPanel>("Person_Basic_Info").SetValues(person);//重置表单
            X.GetCmp<Store>("Person_Store").Reload();//刷新表格
            X.AddScript("person.setFormState();");//修改表单图片
            X.Msg.NotifyTop("操作成功");
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
        
        public ActionResult Delete(string id)
        {
            PersonService.CompletelyDelete(id);
            X.GetCmp<Store>("Person_Store").Reload();
            X.Msg.NotifyTop("操作成功");
            return this.Direct();
        }       
    }
}
