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
        public string Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsDelete { get; set; }
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
