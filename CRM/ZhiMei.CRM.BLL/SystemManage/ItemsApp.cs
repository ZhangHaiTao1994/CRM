using System;
using System.Collections.Generic;
using System.Linq;
using ZhiMei.CRM.Domain.Entity.SystemManage;
using ZhiMei.CRM.Domain.IRepository.SystemManage;
using ZhiMei.CRM.Repository.SystemManage;

namespace ZhiMei.CRM.BLL.SystemManage
{
    public class ItemsApp
    {
        private IItemsRepository service = new ItemsRepository();

        public List<ItemsEntity> GetList()
        {
            return service.IQueryable().ToList();
        }
        public ItemsEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            if (service.IQueryable().Count(t => t.F_ParentId.Equals(keyValue)) > 0)
            {
                throw new Exception("ɾ��ʧ�ܣ������Ķ���������¼����ݡ�");
            }
            else
            {
                service.Delete(t => t.F_Id == keyValue);
            }
        }
        public void SubmitForm(ItemsEntity itemsEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                itemsEntity.Modify(keyValue);
                service.Update(itemsEntity);
            }
            else
            {
                itemsEntity.Create();
                service.Insert(itemsEntity);
            }
        }
    }
}

