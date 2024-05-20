using SiamMaintenance.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SiamMaintenance.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SiamMaintenanceController : AbpControllerBase
{
    protected SiamMaintenanceController()
    {
        LocalizationResource = typeof(SiamMaintenanceResource);
    }
}
