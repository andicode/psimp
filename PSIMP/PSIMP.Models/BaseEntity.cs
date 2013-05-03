using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            _id = Guid.NewGuid();
        }
        private bool _isCreate = true;
        [Ext.Net.MVC.Column(Ignore=true)]
        [Ext.Net.MVC.Field(Ignore=true)]
        [Newtonsoft.Json.JsonIgnore]
        public bool IsCreate { get { return _isCreate; } }

        private Guid _id = Guid.Empty;
        public virtual Guid ID
        {
            get
            {
                return _id;
            }
            set
            {
                _isCreate = false;
                _id = value;
            }
        }
    }
}
