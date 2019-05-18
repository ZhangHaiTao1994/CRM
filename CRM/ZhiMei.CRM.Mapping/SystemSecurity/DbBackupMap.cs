using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemSecurity;

namespace ZhiMei.CRM.Mapping.SystemSecurity
{
    public class DbBackupMap : EntityTypeConfiguration<DbBackupEntity>
    {
        public DbBackupMap()
        {
            this.ToTable("Sys_DbBackup");
            this.HasKey(t => t.F_Id);
        }
    }
}
