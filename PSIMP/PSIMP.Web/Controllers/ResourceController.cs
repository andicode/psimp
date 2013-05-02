using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSIMP.Models;
using WebMatrix.WebData;
using PSIMP.Repository.Account;

namespace PSIMP.Web.Controllers
{
    public class ResourceController : Controller
    {
        //
        // GET: /Resource/
        public UserProfileRepository UserService { get; set; }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            UserService = new UserProfileRepository();
            base.Initialize(requestContext);
        }
        
        public ActionResult Index()
        {
            var userId = WebSecurity.CurrentUserId;
            var user= UserService.Get(userId);
            if (user.UserFolders.Count == 0)
            {
                user.UserFolders.Add(new UserFolders { 
                    
                });
            }
            return View();

           
        }

    }
}
