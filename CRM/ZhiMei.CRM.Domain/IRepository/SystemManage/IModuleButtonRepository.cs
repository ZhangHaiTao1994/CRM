using ZhiMei.CRM.Domain.Entity.SystemManage;
using System.Collections.Generic;
using ZhiMei.CRM.Data.Repository;

namespace ZhiMei.CRM.Domain.IRepository.SystemManage
{
    public interface IModuleButtonRepository : IRepositoryBase<ModuleButtonEntity>
    {
        void SubmitCloneButton(List<ModuleButtonEntity> entitys);
    }
}
