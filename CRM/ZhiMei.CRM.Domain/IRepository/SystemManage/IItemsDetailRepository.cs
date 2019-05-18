using ZhiMei.CRM.Domain.Entity.SystemManage;
using System.Collections.Generic;
using ZhiMei.CRM.Data.Repository;

namespace ZhiMei.CRM.Domain.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
