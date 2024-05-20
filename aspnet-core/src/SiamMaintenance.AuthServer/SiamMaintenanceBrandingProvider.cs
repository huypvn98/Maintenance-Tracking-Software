using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SiamMaintenance;

[Dependency(ReplaceServices = true)]
public class SiamMaintenanceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SiamMaintenance";
}
