using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Business.Context;
using PSIMP.Models;
using PSIMP.Infrastructure.BasicRepository;

namespace PSIMP.Business.Interface.Person
{
    public class PersonTrainingRepository : Repository<PM_PersonTrainingExperience>, IPersonTrainingRepository
    {
        public PersonTrainingRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
