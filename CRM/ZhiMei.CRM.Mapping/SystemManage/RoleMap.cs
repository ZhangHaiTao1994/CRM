using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemManage;

namespace ZhiMei.CRM.Mapping.SystemManage
{
    public class RoleMap : EntityTypeConfiguration<RoleEntity>
    {
        public RoleMap()
        {
            this.ToTable("Sys_Role");
            this.HasKey(t => t.F_Id);
        }
    }
}
