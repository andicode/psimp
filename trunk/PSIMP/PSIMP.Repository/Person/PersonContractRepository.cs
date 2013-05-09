using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Business.Context;
using PSIMP.Models;
using PSIMP.Infrastructure.BasicRepository;

namespace PSIMP.Business.Interface.Person
{
    public class PersonContractRepository : Repository<PM_PersonContractInfo>, IPersonContractRepository
    {
        public PersonContractRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
