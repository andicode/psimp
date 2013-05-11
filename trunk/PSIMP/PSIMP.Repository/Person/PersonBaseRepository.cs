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
        /// <summary>
        /// 人员修改方法，如果对象中照片为空，则使用数据库的值
        /// </summary>
        /// <param name="entity"></param>
        public override void Update(PM_PersonBaseInfo entity)
        {
            this.DataContext.PM_PersonBaseInfo.Attach(entity);
            if (entity.TwoInchPhoto == null)
            {
                this.DataContext.Entry(entity).Property(m => m.TwoInchPhoto).CurrentValue = this.DataContext.Entry(entity).GetDatabaseValues().GetValue<byte[]>("TwoInchPhoto");
            }
            this.DataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
