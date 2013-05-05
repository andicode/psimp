using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    public class EduViewModel
    {
        public PM_PersonBaseInfo PersonBaseInfo { get; set; }

        public PM_PersonEducationalBackground EducationalBackground { get; set; }
        public PM_PersonTrainingExperience PersonTrainingExperience { get; set; }
    }
}
