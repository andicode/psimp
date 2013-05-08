using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace PSIMP.Business.BaseModel
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual string Id { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual string UpdateUser { get; set; }
        public virtual DateTime? UpdateTime { get; set; }
        public virtual bool IsDelete { get; set; }
        [Timestamp]
        public virtual byte[] RowVersion { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
            IsDelete = false;
        }
    }
}
