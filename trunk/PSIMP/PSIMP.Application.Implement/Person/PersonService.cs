using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Application.DTOModel;
using PSIMP.Application.Interface;
using PSIMP.Business.Model;
using PSIMP.Infrastructure.BasicRepository;
using Microsoft.Practices.Unity;
using PSIMP.Business.Interface.Person;
using PSIMP.Application.Interface.Person;
using PSIMP.Models;


namespace PSIMP.Application.Implement
{
    public class PersonService : IPersonService
    {
        [Dependency]
        public IPersonBaseRepository PersonBaseRepository { get; set; }
        [Dependency]
        public IUnitOfWork UnitOfWork { get; set; }

        public IEnumerable<PSIMP.Models.PM_PersonBaseInfo> GetAll()
        {
            return PersonBaseRepository.GetAll();
        }
        public void Add(PM_PersonBaseInfo obj)
        {
            PersonBaseRepository.Add(obj);
            UnitOfWork.Commit();
        }

        public void Update(PM_PersonBaseInfo obj)
        {
            PersonBaseRepository.Update(obj);
            UnitOfWork.Commit();
        }

        public PM_PersonBaseInfo Get(string id)
        {
            return PersonBaseRepository.Get(m => m.ID == id);
        }
    }
}
