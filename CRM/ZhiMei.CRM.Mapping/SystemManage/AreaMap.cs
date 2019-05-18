using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemManage;

namespace ZhiMei.CRM.Mapping.SystemManage
{
    public class AreaMap : EntityTypeConfiguration<AreaEntity>
    {
        public AreaMap()
        {
            this.ToTable("Sys_Area");
            this.HasKey(t => t.F_Id);
        }
    }
}
