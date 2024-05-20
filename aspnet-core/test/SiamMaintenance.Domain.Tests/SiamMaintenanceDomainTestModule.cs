using SiamMaintenance.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SiamMaintenance;

[DependsOn(
    typeof(SiamMaintenanceEntityFrameworkCoreTestModule)
    )]
public class SiamMaintenanceDomainTestModule : AbpModule
{

}
