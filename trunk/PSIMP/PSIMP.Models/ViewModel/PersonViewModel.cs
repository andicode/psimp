using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    public class PersonViewModel
    {
        public PM_PersonBaseInfo PersonBaseInfo { get; set; }

        public IEnumerable<PM_PersonEducationalBackground> EducationalBackgrounds { get; set; }
    }
}
