using System.Threading.Tasks;

namespace SiamMaintenance.Data;

public interface ISiamMaintenanceDbSchemaMigrator
{
    Task MigrateAsync();
}
