using System;
using System.Collections.Generic;
using System.Text;
using SiamMaintenance.Localization;
using Volo.Abp.Application.Services;

namespace SiamMaintenance;

/* Inherit your application services from this class.
 */
public abstract class SiamMaintenanceAppService : ApplicationService
{
    protected SiamMaintenanceAppService()
    {
        LocalizationResource = typeof(SiamMaintenanceResource);
    }
}
