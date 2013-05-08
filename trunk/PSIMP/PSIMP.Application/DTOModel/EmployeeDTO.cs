using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace PSIMP.Application.DTOModel
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public virtual DeptDTO Dept { get; set; }
    }
}
