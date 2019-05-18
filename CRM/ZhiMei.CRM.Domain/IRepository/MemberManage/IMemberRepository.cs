using ZhiMei.CRM.Data.Repository;
using ZhiMei.CRM.Domain.Entity.MemberManage;

namespace ZhiMei.CRM.Domain.IRepository.MemberManage
{
    public interface IMemberRepository : IRepositoryBase<MemberEntity>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(MemberEntity memberEntity, string keyValue);
    }
}
