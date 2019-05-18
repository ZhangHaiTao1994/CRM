using ZhiMei.CRM.Data.Repository;
using ZhiMei.CRM.Domain.Entity.MemberManage;
using ZhiMei.CRM.Domain.IRepository.MemberManage;

namespace ZhiMei.CRM.Repository.MemberManage
{
    public class MemberRepository : RepositoryBase<MemberEntity>, IMemberRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<MemberEntity>(t => t.F_Id == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(MemberEntity memberEntity, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(memberEntity);
                }
                else
                {
                    db.Insert(memberEntity);
                }
                db.Commit();
            }
        }
    }
}
