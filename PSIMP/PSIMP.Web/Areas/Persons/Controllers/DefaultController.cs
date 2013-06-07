using Ext.Net;
using Ext.Net.MVC;
using Microsoft.Practices.Unity;
using PSIMP.Application.Interface.Person;
using PSIMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSIMP.Web.Areas.Persons.Controllers
{
    [DirectController(GenerateProxyForOtherAreas = true, GenerateProxyForOtherControllers = true,AreaName="Persons")]    
    public class DefaultController : Controller
    {
        [Dependency]
        public IPersonService PersonService { get; set; }
        //
        // GET: /Persons/Default/

        public ActionResult Index()
        {
            return this.ComponentConfig();
        }

        public ActionResult GetPersons(StoreRequestParameters srp)
        {
            var total = 0;
            var data = PersonService.GetAll().GetPagesData(srp.Start, srp.Limit, out total);
            return this.Store(data, total);
        }

        public ActionResult PersonInfo(string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.PartialExtView();
            }
            else
            {
                var model = PersonService.Get(id);
                return this.PartialExtView(model);
            }
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

        public ActionResult Details(string id)
        {
            var model = PersonService.Get(id);
            return this.PartialExtView(model);
        }

        public ActionResult Photo(string id)
        {
            PM_PersonBaseInfo person = PersonService.Get(id);
            if (person.TwoInchPhoto == null)
            {
                return File(Server.MapPath("~/Images/Person/default.jpg"), "image/jpeg");
            }
            else
            {
                return File(person.TwoInchPhoto, "image/jpeg");
            }
        }

        public ActionResult Delete(string id)
        {
            //PersonService.CompletelyDelete(id);
            X.GetCmp<Store>("Person_Store").Reload();
            X.Msg.NotifyTop("功能未实现");
            return this.Direct();
        }

        public ActionResult PersonDlg(string backID, string backName, string callback = "")
        {
            var scripts = "";
            scripts += "App." + backID + ".setValue(record.data.ID);";
            scripts += "App." + backName + ".setValue(record.data.PersonName);";
            if (callback != "")
            {
                scripts += callback;
            }
            ViewBag.Scripts = scripts;
            return this.PartialExtView();
        }

        #region 教育信息

        public ActionResult GetEdus()
        {
            return this.Store(null, 0);
        }
        [DirectMethod]
        public ActionResult SaveEdu(bool isPhantom, string personId, string values)
        {
            return Json(new { Id = 0, valid = false, msg = "数据库交互还没有做" });
        }
        public ActionResult DeleteEdu()
        {
            return null;
        }
        public ActionResult GetTrains()
        {
            return this.Store(null, 0);
        }
        [DirectMethod]
        public ActionResult SaveTrain(bool isPhantom, string personId, string values)
        {
            return Json(new { Id = 0, valid = false, msg = "数据库交互还没有做" });
        }
        public ActionResult DeleteTrain()
        {
            return null;
        }
        #endregion

        #region 职称信息
        public ActionResult GetTitles()
        {
            return this.Store(null, 0);
        }
        [DirectMethod]
        public ActionResult SaveTitles(bool isPhantom, string personId, string values)
        {
            return Json(new { Id = 0, valid = false, msg = "数据库交互还没有做" });
        }
        public ActionResult DeleteTitles()
        {
            return null;
        }
        #endregion

        #region 工作经历
        public ActionResult GetWorks()
        {
            return this.Store(null, 0);
        }
        [DirectMethod]
        public ActionResult SaveWorks(bool isPhantom, string personId, string values)
        {
            return Json(new { Id = 0, valid = false, msg = "数据库交互还没有做" });
        }
        public ActionResult DeleteWorks()
        {
            return null;
        }
        #endregion

        #region 证书证件
        public ActionResult GetCerts()
        {
            return this.Store(null, 0);
        }
        [DirectMethod]
        public ActionResult SaveCerts(bool isPhantom, string personId, string values)
        {
            return Json(new { Id = 0, valid = false, msg = "数据库交互还没有做" });
        }
        public ActionResult DeleteCerts()
        {
            return null;
        }
        #endregion
    }
}
