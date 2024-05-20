using Volo.Abp.Settings;

namespace SiamMaintenance.Settings;

public class SiamMaintenanceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SiamMaintenanceSettings.MySetting1));
    }
}
