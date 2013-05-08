using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace PSIMP.Application.DTOModel
{
    public class DeptDTO
    {
      
        public string Name { get; set; }
        public string Remark { get; set; }
        public virtual IEnumerable<EmployeeDTO> listEmp { get; set; }
    }
}
