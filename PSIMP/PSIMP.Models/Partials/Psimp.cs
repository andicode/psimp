using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    public abstract partial class Psimp
    {
        public bool IsAdd()
        {
            return false;
            //return this.Id == default(long);
        }       
    }

    public class Psimp_MetaData
    {
        
        [Column(Hideable=false, Hidden = true)]
        public virtual long Id { get; set; }
        [Column(Ignore=true, Hidden = true)]
        public virtual Nullable<System.DateTime> CreateTime { get; set; }
        [Column(Ignore = true, Hidden = true)]
        public virtual Nullable<System.DateTime> UpdateTime { get; set; }
        [Column(Ignore = true, Hidden = true)]
        public virtual int CreateUserId { get; set; }
        [Column(Ignore = true, Hidden = true)]
        public virtual int UpdateUserId { get; set; }
        [Column(Ignore = true, Hidden = true)]
        public virtual UserProfile CreateUser { get; set; }
        [Column(Ignore = true, Hidden = true)]
        public virtual UserProfile UpdateUser { get; set; }
        [Column(Ignore = true, Hidden = true)]
        public virtual bool IsDelete { get; set; }
    }
}
