using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using PSIMP.Business.BaseModel;


namespace PSIMP.Business.Model
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public virtual Dept Dept { get; set; }
    }
}
