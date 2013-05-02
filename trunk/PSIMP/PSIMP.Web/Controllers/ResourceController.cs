using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSIMP.Models;
using WebMatrix.WebData;
using PSIMP.Repository.Account;
using Ext.Net;
using Ext.Net.MVC;

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
            //如果用户第一次登录，则为用户创建默认目录
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
            
            var root =new Node(){ Text=rootFolder.FolderName, DataPath="/我的文档", NodeID=rootFolder.ID.ToString(),Expanded=true,Icon=Icon.FolderUser };
            GetFolderNodes(root, rootFolder);
            nodes.Add(root);

            var shared = new Node() { Text = "共享文档", NodeID = "shared", DataPath = "/共享文档", Icon = Icon.FolderConnect, Leaf = true };
            nodes.Add(shared);

            return View(nodes);
        }
        //递归生成目录树
        private void GetFolderNodes(Node node,UserFolders folder)
        {
            var folders = folder.Children;
            if (folder.Children.Count == 0)
            {
                node.EmptyChildren = true;
            }
            foreach (var item in folders)
            {
                var path = "/"+item.FolderName;
                GetDataPath(item, ref path);
                var chlid = new Node();
                chlid.Text = item.FolderName;
                chlid.NodeID = item.ID.ToString();
                chlid.DataPath = path;
                node.Children.Add(chlid);
                GetFolderNodes(chlid, item);
            }
        }
        private void GetDataPath(UserFolders folder,ref string dataPath)
        {
            if (folder.UserFolder != null)
            {
                dataPath="/"+folder.UserFolder.FolderName + dataPath;
                GetDataPath(folder.UserFolder, ref dataPath);
            }
        }
        public ActionResult FolderView(string id)
        {  
            var result = new List<FolderView>();
            if (id == "shared")
            {

            }
            else
            {
                var userId = WebSecurity.CurrentUserId;
                var user = UserService.Get(userId);
                var folder = user.UserFolders.Single(m => m.ID == long.Parse(id));
                foreach (var item in folder.Children)
                {
                    result.Add(new FolderView(true)
                    {
                        ID = item.ID,
                        Name = item.FolderName,
                        CanDelete = !item.IsSys
                    });
                }
                foreach (var item in folder.UserFiles)
                {
                    result.Add(new FolderView(false)
                    {
                        ID = item.ID,
                        Name = item.FileName,
                        CanDelete = true,
                        FileType = item.FileType,
                        FileSize = item.FileSize,
                        IsShared = item.IsShared,
                        Remark = item.Remark
                    });
                }
            }
            return this.Store(result);
        }
    }
}
