using Volo.Abp.Modularity;

namespace SiamMaintenance;

[DependsOn(
    typeof(SiamMaintenanceApplicationModule),
    typeof(SiamMaintenanceDomainTestModule)
    )]
public class SiamMaintenanceApplicationTestModule : AbpModule
{

}
