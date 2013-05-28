using PSIMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace System.Web
{
    public static class MvcExtensions
    {
        //public static UserProfile AccountUser(this Controller controller)
        //{
        //    return controller.User as UserProfile;
        //}
        //public static bool SetAccuountUser(this Controller controller, UserProfile user)
        //{
        //    return true;// WebSecurity.Login(user.UserName, user.UserName);
        //}

        public static string ToMd5(this string source)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(source, "MD5");
        }
    }
}