using System.Collections.Generic;
using ZhiMei.CRM.Data.Repository;
using ZhiMei.CRM.Domain.Entity.SystemManage;

namespace ZhiMei.CRM.Domain.IRepository.SystemManage
{
    public interface IRoleRepository : IRepositoryBase<RoleEntity>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(RoleEntity roleEntity, List<RoleAuthorizeEntity> roleAuthorizeEntitys, string keyValue);
    }
}
