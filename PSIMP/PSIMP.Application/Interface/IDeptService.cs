using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Infrastructure.IOC;
using PSIMP.Application.DTOModel;
using PSIMP.Business.Model;

namespace PSIMP.Application.Interface
{
    public interface IDeptService
    {
        IEnumerable<Dept> GetAll();
        [Transaction]
        void Add(Dept obj);
    }
}
