using System.Collections.Generic;
using ZhiMei.CRM.Code.Extend;
using ZhiMei.CRM.Code.Web;
using ZhiMei.CRM.Domain.Entity.MemberManage;
using ZhiMei.CRM.Domain.IRepository.MemberManage;
using ZhiMei.CRM.Repository.MemberManage;

namespace ZhiMei.CRM.BLL.MemberManage
{
    public class MemberApp
    {
        private IMemberRepository service = new MemberRepository();

        /// <summary>
        /// 查询会员列表
        /// </summary>
        /// <param name="pagination">分页信息</param>
        /// <param name="keyword">查询条件</param>
        /// <returns></returns>
        public List<MemberEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<MemberEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_MemberCode.Contains(keyword));
                expression = expression.Or(t => t.F_MemberName.Contains(keyword));
                expression = expression.Or(t => t.F_TelePhoneNo.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

        public MemberEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keyValue"></param>
        public void DeleteForm(string keyValue)
        {
            service.DeleteForm(keyValue);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="memberEntity"></param>
        /// <param name="keyValue"></param>
        public void SubmitForm(MemberEntity memberEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                memberEntity.Modify(keyValue);
            }
            else
            {
                memberEntity.Create();
                memberEntity.F_MemberCode = string.Format("2" + memberEntity.F_Id.PadLeft(7, '0'));
            }
            service.SubmitForm(memberEntity, keyValue);
        }
    }
}
