using System.Data.Entity.ModelConfiguration;
using ZhiMei.CRM.Domain.Entity.SystemSecurity;

namespace ZhiMei.CRM.Mapping.SystemSecurity
{
    public class FilterIPMap : EntityTypeConfiguration<FilterIPEntity>
    {
        public FilterIPMap()
        {
            this.ToTable("Sys_FilterIP");
            this.HasKey(t => t.F_Id);
        }
    }
}
