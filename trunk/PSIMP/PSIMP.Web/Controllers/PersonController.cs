using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;
using PSIMP.Models;
using System.IO;
namespace PSIMP.Web.Controllers
{
    [DirectController(GenerateProxyForOtherAreas=true,GenerateProxyForOtherControllers=true)]
    public class PersonController : Controller
    {
        //private PersonRepository PersonService { get; set; }

        public ActionResult Frame()
        {
            return View();
        }

        /// <summary>
        /// 人员管理主界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        #region 人员基础信息

        public ActionResult GetPersons()
        {
            return this.Store(null, 0);
            //var data = PersonService.GetAll();
            //return this.Store(data, PersonService.Count());
        }

        public ActionResult PersonInfo(string id)
        {
            return this.ComponentConfig();
        }

        [HttpPost]
        public ActionResult Save(PM_PersonBaseInfo person, HttpPostedFileBase TempPicture)
        {
            //if (person.IsCreate)
            //{
            //    if (TempPicture != null)
            //    {
            //        var buff = new byte[TempPicture.InputStream.Length];
            //        TempPicture.InputStream.Read(buff, 0, (int)TempPicture.InputStream.Length);
            //        person.TwoInchPhoto = buff;
            //    }
            //    PersonService.Add(person);
            //}
            //else
            //{
            //    if (TempPicture != null)
            //    {
            //        var buff = new byte[TempPicture.InputStream.Length];
            //        TempPicture.InputStream.Read(buff, 0, (int)TempPicture.InputStream.Length);
            //        person.TwoInchPhoto = buff;
            //    }
            //    PersonService.Update(person);
            //}
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
            //var model = PersonService.Get(id);
            return this.ComponentConfig("Details", null);
        }

        public ActionResult Photo(string id)
        {
            PM_PersonBaseInfo person = null;//PersonService.Get(id);
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
            //PersonService.CompletelyDelete(id);
            X.GetCmp<Store>("Person_Store").Reload();
            X.Msg.NotifyTop("操作成功");
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

        #endregion

        #region 人员注册信息

        public ActionResult GetRegisters()
        {
            return this.Store(null,0);
        }

        #endregion

        #region 保险信息
        public ActionResult GetInsurances()
        {
            return this.Store(null, 0);
        }
        #endregion
    }
}
