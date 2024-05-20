using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SiamMaintenance.Data;
using Volo.Abp.DependencyInjection;

namespace SiamMaintenance.EntityFrameworkCore;

public class EntityFrameworkCoreSiamMaintenanceDbSchemaMigrator
    : ISiamMaintenanceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSiamMaintenanceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SiamMaintenanceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SiamMaintenanceDbContext>()
            .Database
            .MigrateAsync();
    }
}
