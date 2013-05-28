using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Infrastructure.BasicRepository;
using PSIMP.Models;
using PSIMP.Business.Interface.Person;
using System.Data;

namespace PSIMP.Repository.Person
{
    public class PersonBaseRepository : Repository<PM_PersonBaseInfo>, IPersonBaseRepository
    {
        public PersonBaseRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
           
        }
    }
}
