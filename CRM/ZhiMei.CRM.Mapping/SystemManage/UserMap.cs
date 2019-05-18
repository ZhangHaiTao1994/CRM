using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemManage;

namespace ZhiMei.CRM.Mapping.SystemManage
{
    public class UserMap : EntityTypeConfiguration<UserEntity>
    {
        public UserMap()
        {
            this.ToTable("Sys_User");
            this.HasKey(t => t.F_Id);
        }
    }
}
