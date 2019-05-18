using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemManage;

namespace ZhiMei.CRM.Mapping.SystemManage
{
    public class OrganizeMap : EntityTypeConfiguration<OrganizeEntity>
    {
        public OrganizeMap()
        {
            this.ToTable("Sys_Organize");
            this.HasKey(t => t.F_Id);
        }
    }
}
