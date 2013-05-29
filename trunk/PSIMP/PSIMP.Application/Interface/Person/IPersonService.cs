﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Infrastructure.IOC;
using PSIMP.Models;

namespace PSIMP.Application.Interface.Person
{
    public interface IPersonService
    {
        IEnumerable<PM_PersonBaseInfo> GetAll();
        void Add(PM_PersonBaseInfo obj);
        void Update(PM_PersonBaseInfo obj);
        PM_PersonBaseInfo Get(string id);
    }
}
