﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;

namespace PSIMP.Web.Areas.Assets.Controllers
{
    public class AllocateController : Controller
    {
        //
        // GET: /Assets/Allocate/

        public ActionResult Index()
        {
            return this.ComponentConfig();
        }

    }
}