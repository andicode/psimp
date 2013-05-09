using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Business.Context;
using PSIMP.Models;
using PSIMP.Infrastructure.BasicRepository;

namespace PSIMP.Business.Interface.Person
{
    public class PMCertificateManageRepository : Repository<PM_CertificateManage>, IPMCertificateManageRepository
    {
        public PMCertificateManageRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
