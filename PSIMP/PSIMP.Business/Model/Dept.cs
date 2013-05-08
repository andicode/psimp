using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using PSIMP.Business.BaseModel;

namespace PSIMP.Business.Model
{
    [Table("system_dept")]
    public class Dept : BaseEntity
    {
        [Column(TypeName = "varchar")]
        [StringLength(80)]
        [Required]
        public string Name { get; set; }
        public string Remark { get; set; }
        public virtual IEnumerable<Employee> listEmp { get; set; }
    }
}
