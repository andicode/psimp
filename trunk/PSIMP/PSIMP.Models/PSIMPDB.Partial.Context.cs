﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSIMP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PSIMPDBContainer : DbContext
    {
         public DbSet<UserProfile> UserProfileSet { get; set; }
         public DbSet<webpages_Membership> webpages_MembershipSet { get; set; }
         public DbSet<webpages_OAuthMembership> webpages_OAuthMembershipSet { get; set; }
         public DbSet<webpages_Roles> webpages_RolesSet { get; set; }
         public DbSet<PM_PersonBaseInfo> PM_PersonBaseInfoSet { get; set; }
    }
}
