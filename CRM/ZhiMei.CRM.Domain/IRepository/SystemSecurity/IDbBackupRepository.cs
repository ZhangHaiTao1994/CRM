using ZhiMei.CRM.Data.Repository;
using ZhiMei.CRM.Domain.Entity.SystemSecurity;

namespace ZhiMei.CRM.Domain.IRepository.SystemSecurity
{
    public interface IDbBackupRepository : IRepositoryBase<DbBackupEntity>
    {
        void DeleteForm(string keyValue);
        void ExecuteDbBackup(DbBackupEntity dbBackupEntity);
    }
}
