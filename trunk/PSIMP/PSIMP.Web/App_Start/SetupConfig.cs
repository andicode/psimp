using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace PSIMP.Web
{
    public class SetupConfig
    {
        public static void Setup()
        {
            PSIMP.Models.PSIMPDBContainer db=new PSIMP.Models.PSIMPDBContainer();
            //看看数据库是否存在，否则创建数据库
            db.Database.CreateIfNotExists();            
            //初始化权限管理功能
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            if (!WebSecurity.UserExists("admin"))
            {
                //创建管理员帐号
                WebSecurity.CreateUserAndAccount("admin", "admin",requireConfirmationToken:true);
            }
            //----其他初始化数据
        }
    }
}