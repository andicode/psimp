using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Infrastructure.BasicRepository;
using PSIMP.Models;
using PSIMP.Business.Interface.Person;

namespace PSIMP.Business.Interface.Person
{
    public class PersonCertificateInfoRepository : Repository<PM_PersonCertificateInfo>,IPersonCertificateInfoRepository
    {
        public PersonCertificateInfoRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
