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
         public DbSet<Psimp> PsimpSet { get; set; }
         public DbSet<UserProfile> UserProfileSet { get; set; }
         public DbSet<Person> PersonSet { get; set; }
         public DbSet<Education> EducationSet { get; set; }
         public DbSet<Train> TrainSet { get; set; }
    }
}
