using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Business.Context;
using PSIMP.Models;
using PSIMP.Infrastructure.BasicRepository;

namespace PSIMP.Business.Interface.Person
{
    public class PersonWorkExperienceRepository : Repository<PM_PersonWorkExperienceInfo>, IPersonWorkExperienceRepository
    {
        public PersonWorkExperienceRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
