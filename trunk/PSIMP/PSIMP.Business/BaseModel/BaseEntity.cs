using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace PSIMP.Business.BaseModel
{
    using X = Ext.Net.MVC;
    public abstract partial class BaseEntity
    {
        private string _id = "";
        [Key]
        public string ID
        {
            get
            {
                return _id;
            }
            set 
            {
                IsCreate = false;
                _id = value;
            }
        }

        [X.Column(Ignore = true)]
        [X.Field(Ignore = true)]
        public DateTime CreateTime { get; set; }

        [X.Column(Ignore = true)]
        [X.Field(Ignore = true)]
        public string CreateUser { get; set; }

        [X.Column(Ignore = true)]
        [X.Field(Ignore = true)]
        public string UpdateUser { get; set; }

        [X.Column(Ignore = true)]
        [X.Field(Ignore = true)]
        public DateTime? UpdateTime { get; set; }

        [X.Column(Ignore = true)]
        [X.Field(Ignore = true)]
        public bool IsDelete { get; set; }

        private bool _isCreate=true;

        [NotMapped]
        [X.Column(Ignore = true)]
        [X.Field(Ignore = true)]
        public bool IsCreate
        {
            get { return _isCreate=true; }
            private set { _isCreate = value; }
        }

        [Timestamp]
        [X.Column(Ignore = true)]
        [X.Field(Ignore = true)]
        public virtual byte[] RowVersion { get; set; }
        public BaseEntity()
        {
            _id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
            IsDelete = false;
            IsCreate = true;
        }
    }
}
