using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemManage;

namespace ZhiMei.CRM.Mapping.SystemManage
{
    public class ModuleButtonMap : EntityTypeConfiguration<ModuleButtonEntity>
    {
        public ModuleButtonMap()
        {
            this.ToTable("Sys_ModuleButton");
            this.HasKey(t => t.F_Id);
        }
    }
}
