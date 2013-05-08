using PSIMP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PSIMP.Repository_test
{
    public class PersonRepository:DBContext<PM_PersonBaseInfo>
    {
        public override PM_PersonBaseInfo Update(PM_PersonBaseInfo entity)
        {
            this.db.PM_PersonBaseInfoSet.Attach(entity);
            
            var saveEntity = db.Entry<PM_PersonBaseInfo>(entity);
            //如果修改的时候照片为空则将数据库中的值赋给当前对象
            if (entity.TwoInchPhoto == null)
            {
                saveEntity.Property<byte[]>("TwoInchPhoto").CurrentValue = saveEntity.GetDatabaseValues().GetValue<byte[]>("TwoInchPhoto");
            }
            saveEntity.State = EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
