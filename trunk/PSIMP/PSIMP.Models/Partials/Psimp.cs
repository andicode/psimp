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
            return this.Id == default(long);
        }       
    }

    public class Psimp_MetaData
    {
        
        [Column(Hidden = true)]
        public virtual long Id { get; set; }
        [Column(Hidden = true)]
        public virtual Nullable<System.DateTime> CreateTime { get; set; }
        [Column(Hidden = true)]
        public virtual Nullable<System.DateTime> UpdateTime { get; set; }
        [Column(Hidden = true)]
        public virtual string CreateUser { get; set; }
        [Column(Hidden = true)]
        public virtual string UpdateUser { get; set; }
    }
}
