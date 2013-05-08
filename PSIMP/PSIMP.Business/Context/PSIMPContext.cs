using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using PSIMP.Business.Model;
using PSIMP.Models;

namespace PSIMP.Business.Context
{
    public class PSIMPContext : DbContext
    {
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PM_PersonBaseInfo> PM_PersonBaseInfo { get; set; }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
