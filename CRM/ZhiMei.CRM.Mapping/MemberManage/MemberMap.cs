using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.MemberManage;

namespace ZhiMei.CRM.Mapping.MemberManage
{
    public class MemberMap : EntityTypeConfiguration<MemberEntity>
    {
        public MemberMap()
        {
            this.ToTable("Sys_Member");
            this.HasKey(t => t.F_Id);
        }
    }
}
