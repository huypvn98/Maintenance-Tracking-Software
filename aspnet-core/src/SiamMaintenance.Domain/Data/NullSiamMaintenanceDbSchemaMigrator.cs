using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SiamMaintenance.Data;

/* This is used if database provider does't define
 * ISiamMaintenanceDbSchemaMigrator implementation.
 */
public class NullSiamMaintenanceDbSchemaMigrator : ISiamMaintenanceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
