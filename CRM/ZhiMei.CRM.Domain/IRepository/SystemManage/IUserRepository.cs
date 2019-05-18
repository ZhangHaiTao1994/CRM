﻿using ZhiMei.CRM.Data.Repository;
using ZhiMei.CRM.Domain.Entity.SystemManage;

namespace ZhiMei.CRM.Domain.IRepository.SystemManage
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(UserEntity userEntity, UserLogOnEntity userLogOnEntity, string keyValue);
    }
}
