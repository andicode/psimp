using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Application.DTOModel;
using PSIMP.Application.Interface;
using PSIMP.Business.Model;
using PSIMP.Infrastructure.BasicRepository;
using Microsoft.Practices.Unity;
using PSIMP.Business.Interface;


namespace PSIMP.Application.Implement
{
    public class DeptService:IDeptService
    {
        [Dependency]
        public IDeptRepository DeptRepository { get; set; }
        [Dependency]
        public IEmployeeRepository EmployeeRepository { get; set; }
        [Dependency]
        public IUnitOfWork UnitOfWork { get; set; }


        public IEnumerable<Dept> GetAll()
        {
            return DeptRepository.GetAll();
        }
        public void Add(Dept obj)
        {
            DeptRepository.Add(obj);
            UnitOfWork.Commit();
        }
    }
}
