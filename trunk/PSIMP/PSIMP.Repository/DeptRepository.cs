using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Infrastructure.BasicRepository;
using PSIMP.Business.Model;
using PSIMP.Business.Interface;

namespace PSIMP.Repository
{
    public class DeptRepository:Repository<Dept>,IDeptRepository
    {
        public DeptRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
