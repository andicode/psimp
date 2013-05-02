using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSIMP.Models;
using WebMatrix.WebData;
using PSIMP.Repository.Account;
using Ext.Net;

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
                user.UserFolders.Add(new UserFolders
                { 
                    FolderName="我的文档",
                    ParentID=null,
                    IsSys=true
                });
                UserService.Update(user);
            }

            var rootFolder = user.UserFolders.Where(m => m.ParentID == null).Single();
            NodeCollection nodes = new NodeCollection();
            
            var root =new Node(){ Text=rootFolder.FolderName,NodeID=rootFolder.ID.ToString(),Expanded=true,Icon=Icon.FolderUser };
            GetFolderNodes(root, rootFolder);
            nodes.Add(root);
            var shared = new Node() { Text = "共享文档", NodeID = "shared", Icon = Icon.FolderConnect, Leaf = true };
            nodes.Add(shared);
            return View(nodes);
        }

        private void GetFolderNodes(Node node,UserFolders folder)
        {
            var folders = folder.Children;
            if (folder.Children.Count == 0)
            {
                node.EmptyChildren = true;
            }
            foreach (var item in folders)
            {
                var chlid = new Node();
                chlid.Text = item.FolderName;
                chlid.NodeID = item.ID.ToString();
                node.Children.Add(chlid);
                GetFolderNodes(chlid, item);
            }
        }

    }
}
