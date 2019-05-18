using System.Collections.Generic;
using ZhiMei.CRM.Data.Repository;
using ZhiMei.CRM.Domain.Entity.SystemManage;
using ZhiMei.CRM.Domain.IRepository.SystemManage;

namespace ZhiMei.CRM.Repository.SystemManage
{
    public class ModuleButtonRepository : RepositoryBase<ModuleButtonEntity>, IModuleButtonRepository
    {
        public void SubmitCloneButton(List<ModuleButtonEntity> entitys)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                foreach (var item in entitys)
                {
                    db.Insert(item);
                }
                db.Commit();
            }
        }
    }
}
