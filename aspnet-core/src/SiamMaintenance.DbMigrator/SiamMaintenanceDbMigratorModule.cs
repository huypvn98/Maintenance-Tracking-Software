using SiamMaintenance.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SiamMaintenance.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SiamMaintenanceEntityFrameworkCoreModule),
    typeof(SiamMaintenanceApplicationContractsModule)
    )]
public class SiamMaintenanceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
