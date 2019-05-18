using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemSecurity;

namespace ZhiMei.CRM.Mapping.SystemSecurity
{
    public class LogMap : EntityTypeConfiguration<LogEntity>
    {
        public LogMap()
        {
            this.ToTable("Sys_Log");
            this.HasKey(t => t.F_Id);
        }
    }
}
